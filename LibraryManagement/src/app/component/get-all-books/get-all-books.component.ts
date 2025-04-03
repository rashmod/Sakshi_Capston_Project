import { Component } from '@angular/core';
import { Book, BookServiceService } from '../../services/book-service.service';
import { concatWith } from 'rxjs';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-get-all-books',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './get-all-books.component.html',

  styleUrl: './get-all-books.component.css',
})
export class GetAllBooksComponent {
  books: Book[] = [];
  private bookService: BookServiceService;
  constructor(bookService: BookServiceService) {
    this.bookService = bookService;
  }

  ngOnInit() {
    this.bookService.getBooks().subscribe((data) => {
      console.log(data);

      this.books = data;
    });
  }
  cardColors: string[] = [
    '#FF6B6B',
    '#6B5B95',
    '#F7CAC9',
    '#88B04B',
    '#92A8D1',
    '#FFCC5C',
    '#D65076',
  ];
}
