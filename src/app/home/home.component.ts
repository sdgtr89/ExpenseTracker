import { ExpenseService } from './../expense.service';
import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public expenseData: Array<any>;
  public currentExpense: any;
  constructor(private expenseService: ExpenseService) {
    expenseService.get().subscribe((data: any) => this.expenseData = data);
    this.currentExpense = this.setInitialValuesForExpenseData();
   }

  ngOnInit() {
  }

  private setInitialValuesForExpenseData() {
    return {
      id: undefined,
      date: '',
      amount: 0.0
    };
  }

public createOrUpdateExpense = function(expense: any) {
    // if jogging is present in joggingData, we can assume this is an update
    // otherwise it is adding a new element
    let expenseWithId;
    expenseWithId = _.find(this.expenseData, (et => et.id === expense.id));

    if (expenseWithId) {
      const updateIndex = _.findIndex(this.expenseData, {id: expenseWithId.id});
      this.expenseService.update(expense).subscribe(
        expenseRecord =>  this.expenseData.splice(updateIndex, 1, expense)
      );
    } else {
      this.expenseService.add(expense).subscribe(
        expenseRecord => this.expenseData.push(expense)
      );
    }

    this.currentExpense = this.setInitialValuesForExpenseData();
  };

  public editClicked = function(record) {
    this.currentExpense = record;
  };

  public newClicked = function() {
    this.currentExpense = this.setInitialValuesForExpenseData();
  };

  public deleteClicked(record) {
    const deleteIndex = _.findIndex(this.expenseData, {id: record.id});
    this.expenseService.remove(record).subscribe(
      result => this.expenseData.splice(deleteIndex, 1)
    );
  }
}
