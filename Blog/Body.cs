using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Body : IHtmlItem
    {
        public void AddToSite(string content)
        {
            Console.WriteLine(" < head > < title > " + content+ " </head > </title > " );
        }
    }
}
