import { Injectable } from '@angular/core';
import { map, catchError } from 'rxjs/operators';
import { ApiService } from './api.service';
import { RegisterResponse } from '../models';
import { HttpErrorResponse } from '@angular/common/http';
import { throwError, Observable } from 'rxjs';
import {environment} from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private apiService: ApiService) { }

  register(username: string): Observable<RegisterResponse> {
    if (!environment.production && environment.useDevRegisterEndpoint && environment.devPassword) {
      console.warn('Using dev token endpoint --> can register as anyone! Disable before deploying.');
      return this.apiService.post<RegisterResponse>('/auth/token', {username: username, developerPassword: environment.devPassword})
        .pipe(map(response => {
            localStorage.setItem('currentUser', JSON.stringify(response));
            return response;
          })
        );
    }
    return this.apiService.post<RegisterResponse>('/auth/register', {username: username})
      .pipe(map(response => {
          localStorage.setItem('currentUser', JSON.stringify(response));
          return response;
        })
      );
  }
}
