import { HttpClient } from '@angular/common/http';
import { Inject } from '@angular/core';

export class ResourceTypesService {
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    }

    get() {
        return this.http.get<string[]>(this.baseUrl + 'api/ResourceType');   
    }
}