import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";


@Injectable({ providedIn: "root" })
export class StringService
{
	private apiUrl:string = 'api/string';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<string> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : string) : Observable<string> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : string) : Observable<string> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(param: string) : Observable<string> {
		return this.http.get(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

	delete(param: string) : Observable<string> {
		return this.http.delete(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

}
