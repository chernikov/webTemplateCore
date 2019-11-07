import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { Login } from '../classes/login.class';
import { Token } from '../classes/token.class';
import { BadRequestMessage } from '../classes/bad-request-message.class';


@Injectable({ providedIn: "root" })
export class AuthService
{
	private apiUrl:string = 'api/auth';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	post(body : Login) : Observable<Token> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

}
