using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    public class Functii
    {
        #region Filtrare
        public void FiltrareDupaAutor(List<Article> lista, string numeAutor)
        { 
            Console.WriteLine("Articolele scrise de " + numeAutor+" sunt : ");
            foreach (var articol in lista)
            {
                foreach ( var autor in articol.Autori)
                {
                    if (autor==numeAutor)
                    {
                        Console.WriteLine($" - {articol.Titlu}");
                    }
                }
            }

        }
        public void FiltrareDupaTag(List<Article> lista, string tag)
        {
            Console.WriteLine($"Articolele cu tagul {tag} sunt : ");
            foreach (var articol in lista)
            {
                if (articol.Tag==tag)
                {
                    Console.WriteLine($" - {articol.Titlu}");
                }
            }
        }
        public void FiltrareDupaPerioada(List<Article> lista, DateTime start, DateTime end)
        {
            Console.WriteLine($" Articolele publicate in perioada {start} - {end} sunt : ");
            foreach (var articol in lista)
            {
                if (articol.DataPublicare>=start&&articol.DataPublicare<=end)
                {
                    Console.WriteLine($" - {articol.Titlu}");
                }
            }
        }
        public void FiltrarePublicateWeekend(List<Article> lista)
        {
            Console.WriteLine($" Articolele publicate in perioada weekend sunt : ");
            foreach (var articol in lista)
            {
                if (articol.DataPublicare.DayOfWeek==DayOfWeek.Saturday|| articol.DataPublicare.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine($" - {articol.Titlu}");
                }
            }
        }
        #endregion
        #region Sortare

        //a folosit Bubble Sort pentru sortare

        public void AfisareOrdineCronologica(List<Article> lista)
        {
            List<Article> listaOrdonataCronologic = new List<Article>();
            bool sortat = false;
            for (int i = 0; i < lista.Count && sortat==false; i++)
            {
                sortat = true;
                for (int j = 0; j < lista.Count-i-1; j++)
                {
                    if (lista[j].DataPublicare>lista[j+1].DataPublicare)
                    {
                        sortat=false;
                        (lista[j],lista[j+1])=(lista[j+1],lista[i]);
                    }
                }
            }
            Console.WriteLine("Articolele ordonate cronologic : ");
            foreach (var articol in listaOrdonataCronologic)
            {
                Console.WriteLine($" - {articol.Titlu}");
            }
        }
        public void AfisareOrdineLikes(List<Article> lista)
        {
            List<Article> listaOrdonataDupaLikes = new List<Article>();
            bool sortat = false;
            for (int i = 0; i < lista.Count && sortat == false; i++)
            {
                sortat = true;
                for (int j = 0; j < lista.Count - i - 1; j++)
                {
                    if (lista[j].Likes > lista[j + 1].Likes)
                    {
                        sortat = false;
                        (lista[j], lista[j + 1]) = (lista[j + 1], lista[i]);
                    }
                }
            }
            Console.WriteLine("Articolele ordonate dupa likeuri : ");
            foreach (var articol in listaOrdonataDupaLikes)
            {
                Console.WriteLine($" - {articol.Titlu}");
            }
        }
        #endregion
    }
}
