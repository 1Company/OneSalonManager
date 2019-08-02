import { Injectable } from '@angular/core';
declare let alertify: any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

constructor() { }

confirm (message: string, okCallBaxk: () => any) {
  alertify.confirm(message, function(e) {
    if(e) {
      okCallBaxk();
    } else {}
  });
}

success(message: string) {
  alertify.success(message);
}

error(message: string) {
  alertify.error(message);
}

warining(message: string) {
  alertify.warining(message);
}

message(message: string) {
  alertify.message(message);
}

}
