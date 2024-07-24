using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    internal class Magazine: Publication
    {

        public int OderQty { get; set; }
        public int CurrentIssue { get; set; }
        public Magazine(string title, decimal price, int copies, int oderQty, int currentIssue)
            : base(title, price, copies)
        {
            OderQty = oderQty;
            CurrentIssue = currentIssue;
        }
        public void AdjustQty(int adjustment)
        {
            Copies += adjustment;
            Console.WriteLine($"Adjusted quantity of '{Title}' by {adjustment}.total copies: {Copies}");
        }
        public void RecNewIssue()
        {
            CurrentIssue++;
            Console.WriteLine($"Recorded a new issue of '{Title}'. Current issue:{CurrentIssue}");
        }
    }
}
