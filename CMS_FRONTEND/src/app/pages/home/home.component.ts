import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  pages: any[] = [];
  newPageTitle: string = '';

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.fetchPages();
  }

  fetchPages() {
    this.http.get('https://localhost:7138/api/StaticPages').subscribe((data: any) => {
      this.pages = data;
    });
  }

  createPage() {
    if (!this.newPageTitle.trim()) return;
    const newPage = { title: this.newPageTitle };
    this.http.post('https://localhost:7138/api/StaticPages', newPage).subscribe(() => {
      this.newPageTitle = '';
      this.fetchPages();
    });
  }

  deletePage(id: number) {
    this.http.delete(`https://localhost:7138/api/StaticPages/${id}`).subscribe(() => {
      this.fetchPages();
    });
  }

  updatePage(id: number) {
    const updatedTitle = prompt('Enter new title:', '');
    if (updatedTitle) {
      this.http.put(`https://localhost:7138/api/StaticPages/${id}`, { id, title: updatedTitle }).subscribe(() => {
        this.fetchPages();
      });
    }
  }
}
