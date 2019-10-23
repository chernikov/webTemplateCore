using webTemplate.Domain;

namespace webTemplate.BL
{
    public interface IUserAuthBL : IBaseBL
    {
        User GetUserById(int id);

        User GetByEmailAndPassword(string email, string password);
    }
}
