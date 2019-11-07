import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { SimpleObject } from '../classes/simple-object.class';


@Injectable({ providedIn: "root" })
export class SimpleObjectService
{
	private apiUrl:string = 'api/simple-object';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<SimpleObject> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : SimpleObject) : Observable<SimpleObject> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : SimpleObject) : Observable<SimpleObject> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(param: string) : Observable<SimpleObject> {
		return this.http.get(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<SimpleObject> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
