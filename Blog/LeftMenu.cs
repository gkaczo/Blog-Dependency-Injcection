using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class LeftMenu : IHtmlItem
    {
        public void AddToSite(string content)
        {
            Console.WriteLine("< div id=Left Panel>" + content+ "\n</div>");
        }
    }
}
