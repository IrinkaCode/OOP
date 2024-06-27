using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_DZ_
{
    internal class LibraryLoan
    {
        public string titleTextbook;
        public string author;
        public double encrypt;
        public double quantityOnSubscription;
        public double quantityInReadingRoom;

        public LibraryLoan(string titleTextbook, string author, double encrypt, double quantityOnSubscription, double quantityInReadingRoom)
        {
            this.titleTextbook = titleTextbook;
            this.author = author;
            this.encrypt = encrypt;
            this.quantityOnSubscription = quantityOnSubscription;
            this.quantityInReadingRoom = quantityInReadingRoom;
        }
        public void TakenFromSubscription(double quantity)
        {
            if (quantity <= this.quantityOnSubscription)
            {
                this.quantityOnSubscription -= quantity;
            }
            else
            {
                Console.WriteLine("Недостаточно книг на абонементе.");
            }
        }
        public void TakenFromReadingRoom(double quantity)
        {
            if (quantity <= this.quantityInReadingRoom)
            {
                this.quantityInReadingRoom -= quantity;
            }
            else
            {
                Console.WriteLine("Недостаточно книг в читальном зале.");
            }
        }

        public void ReturnedFromSubscription(double quantity)
        {
            this.quantityOnSubscription += quantity;
        }
        public void ReturnedFromReadingRoom(double quantity)
        {
            this.quantityInReadingRoom += quantity;
        }

        public void AvailabilityOnSubscription()
        {
            Console.WriteLine($"Книга: {titleTextbook}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Шифр: {encrypt}");
            Console.WriteLine($"Количество на абонементе: {quantityOnSubscription}");
            Console.WriteLine($"Оставшееся количество в наличии: {quantityOnSubscription}");
        }
        public void AvailabilityOnReadingRoom()
        {
            Console.WriteLine($"Книга: {titleTextbook}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Шифр: {encrypt}");
            Console.WriteLine($"Количество в читальном зале: {quantityInReadingRoom}");
        }
    }
}
