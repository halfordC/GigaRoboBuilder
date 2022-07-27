import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildMakerComponent } from './build-maker.component';

describe('BuildMakerComponent', () => {
  let component: BuildMakerComponent;
  let fixture: ComponentFixture<BuildMakerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuildMakerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildMakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
