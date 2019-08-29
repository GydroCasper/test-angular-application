import { Component, Input } from '@angular/core';
import { ResourceItem } from '../common/ResourceItem';
import { ResourceTypesService } from '../services/resourceTypes.service';

@Component({
  selector: 'app-resource-table',
  templateUrl: './resource-table.component.html',
  styleUrls: ['./resource-table.component.css']
})
export class ResourceTableComponent {
  @Input() resourceItems: ResourceItem[] = [];
  private originalResourceTypes: string[] = [];
  private resourceTypes: string[] = [];
  private newResourceItem: ResourceItem = { resourceType: "", amount: null };

  constructor(private resourceTypesService: ResourceTypesService) {
    resourceTypesService.get().subscribe(resourceTypes => {
      this.originalResourceTypes = [...resourceTypes];
      this.resourceTypes = [...resourceTypes];
      this.refreshResourceTypes();
    });
  }

  newResourceAdded() {
    this.resourceItems.push({ ...this.newResourceItem });
    this.resourceTypes = this.resourceTypes.filter(resourceType => resourceType !== this.newResourceItem.resourceType);
    this.newResourceItem = { resourceType: "", amount: null };
  }

  resourceDeleted(index: number) {
    this.resourceItems.splice(index, 1);
    this.refreshResourceTypes();
  }

  private refreshResourceTypes() {
    const addedResourceTypes = this.resourceItems.map(item => item.resourceType);
    this.resourceTypes = [...this.originalResourceTypes].filter(resourceType => {
      return !addedResourceTypes.includes(resourceType)
    });
  }
}
