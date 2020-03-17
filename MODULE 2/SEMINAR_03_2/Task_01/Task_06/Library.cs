using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Library
    {
        Book _title;
        public Library()
        {
        }

        public Library(Book title)
        {
            _title = title;
        }

        public Book this[Book index]
        {
            get
            {
                return index;
            }
        }
    }
}
