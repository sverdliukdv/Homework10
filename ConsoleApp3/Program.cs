/*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Book. Створити класи Title, Author та Content, 
 * кожен з яких повинен містити одне рядкове поле та метод void Show(). Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. 
 * Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.*/

using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        class Book {
            private Title title;
            private Author author;
            private Content content;

            public Book (string title, string author, string content)
            {
                this.title = new Title(title);
                this.author = new Author(author);
                this.content = new Content(content);
            }

            public void Show()
            {
                title.Show();
                author.Show();
                content.Show();
            }
        }
        class Title {
            private string title;
            public Title (string title)
            {
                this.title = title;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Назва книги: {title}");
                Console.ResetColor(); ;
            }
        }
        class Author {
            private string author;
            public Author(string author)
            {
                this.author = author;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Автор: {author}");
                Console.ResetColor(); ;
            }
        }
        class Content {
            private string content;
            public Content(string content)
            {
                this.content = content;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Зміст: {content}");
                Console.ResetColor(); ;
            }
        }

        static void Main(string[] args)
        {
            Book book = new Book("Кобзар", "Тарас Шевченко", "Зміст книги");
            book.Show();
            Console.ReadLine();

        }
    }
}
