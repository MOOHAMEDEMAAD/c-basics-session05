using System;
using System.Collections.Generic;
using System.Text;

namespace s5_assi
{
    internal class Book
    {
        private string Password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre Genre { get; set; }
    }
}
