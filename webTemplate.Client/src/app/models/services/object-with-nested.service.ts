import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { ObjectWithNested } from '../classes/object-with-nested.class';


@Injectable({ providedIn: "root" })
export class ObjectWithNestedService
{
	private apiUrl:string = 'api/object-with-nested';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<ObjectWithNested> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : ObjectWithNested) : Observable<ObjectWithNested> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : ObjectWithNested) : Observable<ObjectWithNested> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(param: string) : Observable<ObjectWithNested> {
		return this.http.get(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<ObjectWithNested> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
