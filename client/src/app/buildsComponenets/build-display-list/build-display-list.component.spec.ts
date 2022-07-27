import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildDisplayListComponent } from './build-display-list.component';

describe('BuildDisplayListComponent', () => {
  let component: BuildDisplayListComponent;
  let fixture: ComponentFixture<BuildDisplayListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuildDisplayListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildDisplayListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
