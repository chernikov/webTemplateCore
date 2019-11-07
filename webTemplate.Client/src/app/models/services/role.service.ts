import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { Role } from '../classes/role.class';


@Injectable({ providedIn: "root" })
export class RoleService
{
	private apiUrl:string = 'api/role';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<Role[]> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	get(id: number) : Observable<Role> {
		return this.http.get(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
