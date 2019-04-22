import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GridExpensesComponent } from './grid-expenses.component';

describe('GridExpensesComponent', () => {
  let component: GridExpensesComponent;
  let fixture: ComponentFixture<GridExpensesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridExpensesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridExpensesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
