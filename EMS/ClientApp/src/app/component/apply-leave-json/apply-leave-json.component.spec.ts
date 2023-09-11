import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplyLeaveJsonComponent } from './apply-leave-json.component';

describe('ApplyLeaveJsonComponent', () => {
  let component: ApplyLeaveJsonComponent;
  let fixture: ComponentFixture<ApplyLeaveJsonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplyLeaveJsonComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApplyLeaveJsonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
