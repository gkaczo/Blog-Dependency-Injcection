using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Center : IHtmlItem
    {
        public void AddToSite(string content)
        {
            Console.WriteLine("< div id=Center Panel>" + content + "\n</div>");
        }
    }
}
