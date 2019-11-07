import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";

import { ObjectWithDictionary } from '../classes/object-with-dictionary.class';


@Injectable({ providedIn: "root" })
export class ObjectWithDictionaryService
{
	private apiUrl:string = 'api/object-with-dictionary';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<ObjectWithDictionary> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : ObjectWithDictionary) : Observable<ObjectWithDictionary> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : ObjectWithDictionary) : Observable<ObjectWithDictionary> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(param: string) : Observable<ObjectWithDictionary> {
		return this.http.get(this.apiUrl + "/" + param, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<ObjectWithDictionary> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}