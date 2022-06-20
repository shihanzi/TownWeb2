import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {PagerComponent, PaginationModule} from 'ngx-bootstrap/pagination';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
import {CarouselModule} from 'ngx-bootstrap/carousel';

@NgModule({
  declarations: [
    PagingHeaderComponent],
  imports: [
    CommonModule,
    PaginationModule.forRoot(),
    CarouselModule.forRoot()
  ],
  exports:[PaginationModule,
    PagingHeaderComponent,
    PaginationModule,
    CarouselModule
  ]
})
export class SharedModule { }
