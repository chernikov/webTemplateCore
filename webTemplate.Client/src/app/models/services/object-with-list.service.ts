import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { ObjectWithList } from '../classes/object-with-list.class';


@Injectable({ providedIn: "root" })
export class ObjectWithListService
{
	private apiUrl:string = 'api/object-with-list';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<ObjectWithList> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : ObjectWithList) : Observable<ObjectWithList> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : ObjectWithList) : Observable<ObjectWithList> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(param: string) : Observable<ObjectWithList> {
		return this.http.get(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<ObjectWithList> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
