using System;
using System.Collections.Generic;

namespace ArticleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> listaArticole = new List<Article>();
            listaArticole.Add(new Article("Amintiri din copilarie", new string[] { "Ion Creanga"}, "La cirese", new DateTime(1960, 11, 12), new DateTime(1980, 02, 14), 54, 2, "tag1"));
            //... puteti adauga orice articol dupa preferinta
            Functii functii = new Functii();
            functii.FiltrareDupaAutor(listaArticole, "Ion Creanga");
        }
    }
}
