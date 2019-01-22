using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    /* program zawiera przykladowa strone na której umieszczamy poszczegolne bloki.
     klasa Body reprezentuje naglowek dokumentu i ladowana jest przez konstruktor
    pozostale elementy left, center z wykorzystaniem metody
     */
    class Program
    {
        static void Main(string[] args)
        {
            Body myBody = new Body();
            MyHtmlSite myHtmlSite = new MyHtmlSite(myBody);
            myHtmlSite.AddToMyHtmlSite();
           
            LeftMenu lftMnu =new  LeftMenu();
            myHtmlSite.AddElementToMyHtml(lftMnu,"\n1. info \n2. help");
            Console.WriteLine();

            Center cntr = new Center();
            myHtmlSite.AddElementToMyHtml(cntr, "Lorem ipsum dolor met");

            Console.ReadLine();
        }
    }
}
