import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ThisReceiver } from '@angular/compiler';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourService {

  constructor(private http:HttpClient) { }
  apiurl="https://localhost:44307/api/Courier";

  GetCourierData(){
    return this.http.get(this.apiurl);
  }
  PostCourierData(courform:any){
    return this.http.post(this.apiurl,courform)
  }
  PutCourierData(courUform:any){
    return this.http.put(this.apiurl,courUform)
  }
  DeleteCourierData(cId:any){
    return this.http.delete(this.apiurl+"/"+cId)
  }
  GetCourierById(cId:any){
    return this.http.get(this.apiurl+"/"+cId)
  }

}
