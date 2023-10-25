
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public static class BlogService
    {

        public static void AddBlog(Blog blog)
        {
            BlogDataBase.Blogs.Add(blog);

        }

        public static void RemoveBlog(int id)
        {
            BlogDataBase.Blogs.Remove(GetBlogById(id));
        }

        public static Blog GetBlogById(int id)
        {
            foreach (var item in BlogDataBase.Blogs)
            {
                if (item.Id == id) return item;
            }
            return null;

        }
        public static List<Blog> GetAllBlogs()
        {
            List<Blog> list = new List<Blog>();
            foreach (var item in BlogDataBase.Blogs)
            {
                list.Add(item);
            }
            return list;

        }

        public static List<Blog> GetBlogsByValue(string value)
        {
            List<Blog> list = new List<Blog>();
            foreach (var item in BlogDataBase.Blogs)
            {
                if (item.Desctiption == value || item.Title == value)
                    list.Add(item);
            }
            return list;
        }



    }
}
