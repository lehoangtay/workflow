﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    internal class Publication
    {
            public string Title { get; set; }
            public decimal Price { get; set; }
            public int Copies { get; set; }
            public Publication(string title, decimal price, int copies)
            {
                Title = title;
                Price = price;
                Copies = copies;
            }
            public void Sellcopy()
            {
                if (Price > 0)
                {
                    Copies--;
                    Console.WriteLine($"sold a copy of '{Title}'. Remaining copies:{Copies}");
                }
                else
                {
                    Console.WriteLine($"'{Title}'is out of stock.");
                }
            }
        
    }
}
