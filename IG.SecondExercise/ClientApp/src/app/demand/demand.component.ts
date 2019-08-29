import { Component, Inject } from '@angular/core';
import { Store } from '../store/Store';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-demand',
  templateUrl: './demand.component.html'
})
export class DemandComponent {
  private checkingResults: any[] = [];

  constructor(private store: Store, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    
  }

  check() {
    this.http.post<any[]>(this.baseUrl + 'api/Resources/check', this.store).subscribe(result => this.checkingResults = result);
  }
}