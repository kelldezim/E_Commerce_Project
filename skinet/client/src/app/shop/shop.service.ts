import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IPagination } from '../shared/models/pagination';
import { IType } from '../shared/models/productTypes';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  // service allow us to connect with API
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getProducts(brandId?: number, typeId?: number, sort?: string){
    let params = new HttpParams();

    if(brandId){
      params = params.append('brandId', brandId.toString());
    }
    if(typeId){
      params = params.append('typeId', typeId.toString());
    }
    if(sort){
      params = params.append('sort', sort)
    }

    return this.http.get<IPagination>(this.baseUrl + 'products', {observe: 'response', params})
    //pipe method is wrapping all rxjs operators
      .pipe(
        map(response => { return response.body; })
      );
  }
  getBrand(){
    return this.http.get<IBrand[]>(this.baseUrl + 'products/brands');
  }
  getTypes(){
    return this.http.get<IType[]>(this.baseUrl + 'products/types');
  }
  
}
