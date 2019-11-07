import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { NamedEnum } from '../enums/named-enum.enum';


@Injectable({ providedIn: "root" })
export class NamedEnumService
{
	private apiUrl:string = 'api/named-enum';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<NamedEnum> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : NamedEnum) : Observable<NamedEnum> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : NamedEnum) : Observable<NamedEnum> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(id: number) : Observable<NamedEnum> {
		return this.http.get(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<NamedEnum> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
