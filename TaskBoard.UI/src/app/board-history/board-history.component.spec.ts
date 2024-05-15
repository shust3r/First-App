import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardHistoryComponent } from './board-history.component';

describe('BoardHistoryComponent', () => {
  let component: BoardHistoryComponent;
  let fixture: ComponentFixture<BoardHistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [BoardHistoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BoardHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
