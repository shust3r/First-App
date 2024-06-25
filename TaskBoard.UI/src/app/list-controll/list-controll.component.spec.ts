import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListControllComponent } from './list-controll.component';

describe('ListControllComponent', () => {
  let component: ListControllComponent;
  let fixture: ComponentFixture<ListControllComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListControllComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ListControllComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
