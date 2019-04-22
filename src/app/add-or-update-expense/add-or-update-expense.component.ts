import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-or-update-expense',
  templateUrl: './add-or-update-expense.component.html',
  styleUrls: ['./add-or-update-expense.component.css']
})
export class AddOrUpdateExpenseComponent implements OnInit {

  @Output() expenseCreated = new EventEmitter<any>();
  @Input() expenseInfo: any;

  public buttonText = 'Save';

  constructor() {
    this.clearExpenseInfo();
    console.log(this.expenseInfo.date);
   }

  ngOnInit() {
  }

  private clearExpenseInfo = function() {
    // Create an empty jogging object
    this.expenseInfo = {
      id: undefined,
      date: '',
      amount: 0.0
    };
  };

  public addOrUpdateExpenseRecord = function(event) {
    this.expenseCreated.emit(this.expenseInfo);
    this.clearExpenseInfo();
  };

}
