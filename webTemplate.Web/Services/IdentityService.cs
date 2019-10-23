﻿using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using webTemplate.BL;
using webTemplate.Web.Dto;
using webTemplate.Web.Helpers;

namespace webTemplate.Web.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IPrincipal principal;
        private readonly AppSettings appSettings;
        private readonly IMapper mapper;
        private readonly IUserAuthBL userAuthBL;

        public IdentityService(IOptions<AppSettings> appSettings, IMapper mapper, IUserAuthBL userAuthBL)
        {
            this.appSettings = appSettings.Value;
            this.mapper = mapper;
            this.userAuthBL = userAuthBL;
        }


        public string Authenticate(string email, string password)
        {
            var user = userAuthBL.GetByEmailAndPassword(email, password);
            // return null if user not found
            if (user == null)
            {
                return null;
            }

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            var objUser = JsonConvert.SerializeObject(mapper.Map<UserDto>(user));
            var claims = new List<Claim>() {
                            new Claim(ClaimTypes.Sid, user.Id.ToString()),
                            new Claim(ClaimTypes.Name, user.Email),
                            new Claim("user", objUser)
            };
            var roles = user.UserRoles.Select(ur => ur.Role);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Code));
            }

            var identity = new ClaimsIdentity(claims);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
