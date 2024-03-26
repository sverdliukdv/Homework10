/*
 Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас із ім'ям Address. 
У тілі класу потрібно створити поля: index, country, city, street, house, apartment. Для кожного поля створити властивість з двома методами доступу. 
Створити екземпляр класу Address. У поля екземпляра записати інформацію про поштову адресу. Виведіть на екран значення полів, що описують адресу.
 */

using System;

namespace ConsoleApp5
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = "11111";
            address.Country = "США";
            address.City = "Медісон";
            address.Street = "Бандери";
            address.House = "4";
            address.Apartment = "1";

            Console.WriteLine($"Індекс: {address.Index}");
            Console.WriteLine($"Країна: {address.Country}");
            Console.WriteLine($"Місто: {address.City}");
            Console.WriteLine($"Вулця: {address.Street}");
            Console.WriteLine($"Будинок: {address.House}");
            Console.WriteLine($"Квартира: {address.Apartment}");
        }
        
    }
}
