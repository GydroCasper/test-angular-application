import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { ResourceTableComponent } from './resource-table/resource-table.component';
import { ResourceTypesService } from './services/resourceTypes.service';
import { ProviderComponent } from './provider/provider.component';
import { Store } from './store/Store';
import { DemandComponent } from './demand/demand.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ResourceTableComponent,
    ProviderComponent,
    DemandComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: ProviderComponent, pathMatch: 'full' },
      { path: 'demand', component: DemandComponent}
    ])
  ],
  providers: [ ResourceTypesService, Store ],
  bootstrap: [AppComponent]
})

export class AppModule { }
