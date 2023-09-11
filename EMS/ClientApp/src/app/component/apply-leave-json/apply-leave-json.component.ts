import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LeaveService } from 'src/app/Services/LeaveService';
import { LeaveRequest } from 'src/app/models/apply-leave.model';

interface FormControls {
  [key: string]: AbstractControl;
}

@Component({
  selector: 'apply-leave-json',
  templateUrl: './apply-leave-json.component.html',
  styleUrls: ['./apply-leave-json.component.css']
})



export class ApplyLeaveJsonComponent implements OnInit {
  form: FormGroup = new FormGroup({});
  dateFieldsEmpty: boolean = false;
  leaveRequest: LeaveRequest | undefined;
  errorTextMessage: string | null = null;
  formData: any[] = [
    {
      type: 'date',
      name: 'startDate',
      label: 'Start Date',
      required: true,
    },
    {
      type: 'date',
      name: 'endDate',
      label: 'End Date',
      required: true,
    },
    {
      type: 'select',
      name: 'leaveType',
      label: 'Leave Type',
      required: true,
      options: [
        { value: '1', label: 'Sick Leave' },
        { value: '2', label: 'Annual Leave' },
        { value: '3', label: 'Study Leave' },
        { value: '4', label: 'Maternal Leave' }
      ],
      defaultValue: '1',
    },
    {
      type: 'select',
      name: 'leaveNature',
      label: 'Leave Nature',
      options: [
        { value: '1', label: 'Local' },
        { value: '2', label: 'Travel' },
      ],
      defaultValue: '1',
    },
    
    {
      type: 'textarea',
      name: 'reason',
      label: 'Reason',
      required: false,
    },
  ];

  constructor(
    private router: Router,
    private formBuilder: FormBuilder ,private leaveService : LeaveService) { }

  ngOnInit(): void {
    this.buildForm();
  }


  private buildForm() {
    const formControls: FormControls = {};
    this.formData.forEach((field) => {
      const validators = [
        field.required ? Validators.required : null,
        field.type === 'date' ? this.dateValidator() : null,
        field.pattern ? Validators.pattern(field.pattern) : null,
      ].filter((validator) => validator !== null) as ValidatorFn[];
  
      formControls[field.name] = this.formBuilder.control('', Validators.compose(validators));
      
    });
    this.form = new FormGroup(formControls);
  }
  dateValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      const inputDate = control.value;
      if (inputDate && !/^\d{4}-\d{2}-\d{2}$/.test(inputDate)) {
        return { invalidDate: true };
      }
      return null;
    };
  }
  

  onSubmit() {

    if (this.form?.valid) {
      // Handle form submission here
      this.leaveRequest = {
        startDate: this.form.value.startDate,
        endDate: this.form.value.endDate,
        leaveTypeId: this.form.value.leaveType,
        requestComments: this.form.value.reason,
        requestingEmployeeId: 1,
        leaveId: 0
      };
      console.log(this.leaveRequest);
      this.leaveService.applyLeave(this.leaveRequest).subscribe(
        (response) => {
          if(response.success){
            this.errorTextMessage = response.message;
            this.router.navigate(['/leave-data']);
          }else{
            this.errorTextMessage = response.message;
          }
          
        },
        (error) => {
          console.error('Error submitting leave request:', error);
          // Handle error scenarios
          if (error.status === 400) {
            // Handle Bad Request scenario
            this.errorTextMessage = 'Bad request: Please check your input data.';
          } else {
            // Handle other error scenarios
            this.errorTextMessage = 'An error occurred while submitting the leave request.';
          }
        }
      );
    }
  }
  


}

interface FormField {
  type: string;
  name: string;
  label: string;
  required: boolean;
  pattern?: string;
  options?: string[];
}