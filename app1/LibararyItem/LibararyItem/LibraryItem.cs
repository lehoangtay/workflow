using System;

namespace LibraryItemNamespace
{
    internal abstract class LibraryItem
    {
        private string title;
        private string author;
        private DateOnly publicationDate;
        private bool available;

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return this.title;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public string GetAuthor()
        {
            return this.author;
        }

        public void SetPublicationDate(DateOnly publicationDate)
        {
            this.publicationDate = publicationDate;
        }
        public DateOnly GetPublicationDate()
        {
            return this.publicationDate;
        }

        public void SetAvailable(bool available)
        {
            this.available = available;
        }
        public bool GetAvailable()
        {
            return this.available;
        }

        public LibraryItem(string title, string author, DateOnly publicationDate, bool available)
        {
            this.title = title;
            this.author = author;
            this.publicationDate = publicationDate;
            this.available = available;
        }

        public abstract void Checkout();
        public abstract void ReturnItem();
    }
}
