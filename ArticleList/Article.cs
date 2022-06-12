using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    public class Article
    {
        string titlu;
        string[] autori;
        string continut;
        DateTime dataPublicare;
        DateTime dataModificare;
        int likes;
        int dislikes;
        string tag;
      
        public Article(string titlu, string[] autori, string continut, DateTime dataPublicare, DateTime dataModificare, int likes, int dislikes, string tag)
        {
            this.titlu = titlu;
            this.autori = autori;
            this.continut = continut;
            this.dataPublicare = dataPublicare;
            this.dataModificare = dataModificare;
            this.likes = likes;
            this.dislikes = dislikes;
            this.tag = tag;
        }
        public string Titlu { get { return titlu; } set { titlu = value; } }
        public string[] Autori { get { return autori; } set { autori= value; } }
        public string Continut { get { return continut; } set { continut = value; } }
        public DateTime DataPublicare { get { return dataPublicare; } set { dataPublicare = value; } }
        public DateTime DataModificare { get { return dataModificare; } set { dataModificare = value; } }
        public int Likes { get { return likes; } set { likes = value; } }
        public int Dislikes { get { return dislikes; } set { dislikes = value; } }
        public string Tag { get { return tag; } set { tag = value; } }

    }
}
