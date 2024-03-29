import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuildDisplayListComponent } from './buildsComponenets/build-display-list/build-display-list.component';
import { BuildDisplayComponent } from './buildsComponenets/build-display/build-display.component';
import { BuildMakerComponent } from './buildsComponenets/build-maker/build-maker.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'members', component: MemberListComponent, canActivate: [AuthGuard]},
      {path: 'members/:id', component: MemberDetailComponent},
      {path: 'lists', component: ListsComponent},
      {path: 'messages', component: MessagesComponent},
      {path: 'createNewBuild', component:BuildMakerComponent},
      {path: 'builds', component:BuildDisplayListComponent},
      {path: 'builds/:id', component:BuildDisplayComponent },//Would be cool to use names as the /address for each build, but then we need to make sure no build has the same name.
      
    ]
  },
  {path: 'errors', component: TestErrorsComponent},
  {path: 'not-found', component: NotFoundComponent },
  {path: 'server-error', component: ServerErrorComponent },
  {path: '**', component: NotFoundComponent, pathMatch: 'full'},

  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
