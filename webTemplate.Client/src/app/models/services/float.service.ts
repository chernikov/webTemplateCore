import { Http, Headers, RequestOptions } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { map } from "rxjs/operators";


@Injectable({ providedIn: "root" })
export class FloatService
{
	private apiUrl:string = 'api/float';

	private headers = new Headers({
		"content-type": "application/json",
		"Accept": "application/json"
	});
	private options = new RequestOptions({
		headers : this.headers
	})

	constructor(private http: Http) {}

	getAll() : Observable<number> {
		return this.http.get(this.apiUrl, this.options).pipe(map(res => res.json()));
	}

	post(body : number) : Observable<number> {
		return this.http.post(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	put(body : number) : Observable<number> {
		return this.http.put(this.apiUrl, body, this.options).pipe(map(res => res.json()));
	}

	get(id: number) : Observable<number> {
		return this.http.get(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

	delete(id: number) : Observable<number> {
		return this.http.delete(this.apiUrl + "/" + id, this.options).pipe(map(res => res.json()));
	}

}
