using System;

namespace LibraryItemNamespace
{
    internal class Book : LibraryItem
    {
        private string genre;

        public Book(string title, string author, DateOnly publicationDate, bool available, string genre)
            : base(title, author, publicationDate, available)
        {
            this.genre = genre;
        }

        public string GetGenre()
        {
            return this.genre;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public override void Checkout()
        {
            SetAvailable(false);
            Console.WriteLine($"The book '{GetTitle()}' has been checked out.");
        }

        public override void ReturnItem()
        {
            SetAvailable(true);
            Console.WriteLine($"The book '{GetTitle()}' has been returned.");
        }

        public override string ToString()
        {
            return $"Book: {GetTitle()}, Author: {GetAuthor()}, Genre: {genre}, Publication Date: {GetPublicationDate()}, Available: {GetAvailable()}";
        }
    }
}
