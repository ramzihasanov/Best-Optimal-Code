using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp13.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public Blogtype Type { get; set; }

        static Blog()
        {
            _id = 0;

        }
        public Blog(string title, string desctiption, Blogtype blg)
        {
            Title = title;
            Desctiption = desctiption;
            Type = blg;
            _id++;
            Id = _id;
        }
    }
}
