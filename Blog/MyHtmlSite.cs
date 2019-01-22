using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class MyHtmlSite
    {
        private readonly IHtmlItem item;

        //DI przez konstruktor
        public MyHtmlSite(IHtmlItem item)
        {
            this.item = item;

        }

        public void AddToMyHtmlSite()
        {
           if(item!=null)
            {
                item.AddToSite( "My site DI");
            }

        }

        //DI przez metode
        public void AddElementToMyHtml(IHtmlItem element, string content)
        {
            
            if (element!= null)
            {
                element.AddToSite(content);
            }
        }


    }
}
