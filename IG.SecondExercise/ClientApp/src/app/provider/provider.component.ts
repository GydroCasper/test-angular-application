import { Component } from '@angular/core';
import { Store } from '../store/Store';

@Component({
  selector: 'app-provider',
  templateUrl: './provider.component.html'
})
export class ProviderComponent {
  constructor(private store: Store) {
    
  }
} 