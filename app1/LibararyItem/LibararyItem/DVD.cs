using System;

namespace LibraryItemNamespace
{
    internal class DVD : LibraryItem
    {
        private int runtime; // Runtime in minutes

        public DVD(string title, string director, DateOnly publicationDate, bool available, int runtime)
            : base(title, director, publicationDate, available)
        {
            this.runtime = runtime;
        }

        public int GetRuntime()
        {
            return this.runtime;
        }

        public void SetRuntime(int runtime)
        {
            this.runtime = runtime;
        }

        public override void Checkout()
        {
            SetAvailable(false);
            Console.WriteLine($"The DVD '{GetTitle()}' has been checked out.");
        }

        public override void ReturnItem()
        {
            SetAvailable(true);
            Console.WriteLine($"The DVD '{GetTitle()}' has been returned.");
        }

        public override string ToString()
        {
            return $"DVD: {GetTitle()}, Director: {GetAuthor()}, Runtime: {runtime} minutes, Publication Date: {GetPublicationDate()}, Available: {GetAvailable()}";
        }
    }
}
