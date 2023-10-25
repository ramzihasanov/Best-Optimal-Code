using ConsoleApp13.Models;
using System.Linq.Expressions;

namespace ConsoleApp13
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int chack;
            do
            {
                Console.WriteLine("<==============Menu============>");
                Console.WriteLine("1.Register \n2.Login");
                chack = int.Parse(Console.ReadLine());
                switch (chack)
                {
                    case 1:

                        Console.WriteLine("adi daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("soyadi daxil edin");
                        string surname = Console.ReadLine();
                        Console.WriteLine("passwordu daxil edin: (password en az 7 herf ve terkibinde 1 reqem olmalidir)");
                        string password = Console.ReadLine();
                        User user = new User(name, surname, password);
                        BlogDataBase.Users.Add(user);

                        break;

                    case 2:
                        bool a;
                        do
                        {
                            Console.WriteLine("username daxil edin:");
                            string username = Console.ReadLine();
                            Console.WriteLine("password daxil edin:");
                            string password1 = Console.ReadLine();
                            a = UserService.Login(username, password1);
                        } while (a = false);
                        int chack1;
                        do
                        {
                            Console.WriteLine("<==========Blog Menu===========>");
                            Console.WriteLine("1.Blog elave et \n2.Blog sil \n3.Blog detail \n4.Butun bloglara bax \n5.Bloglari filtirle \n0.Programi bitir");

                            chack1 = int.Parse(Console.ReadLine());
                            switch (chack1)
                            {
                                case 1:
                                    Console.WriteLine("title daxil edin:");
                                    string word = Console.ReadLine();
                                    Console.WriteLine("desctription daxil edin:");
                                    string task = Console.ReadLine();
                                    Console.WriteLine("BlogType daxil edin:\n1.Programming\n2.Educational\n3.Thriller");
                                    int button = int.Parse(Console.ReadLine());
                                    Blogtype th;
                                    switch (button)
                                    {
                                        case 1:
                                            th = Blogtype.Programming; break;
                                        case 2:
                                            th = Blogtype.Educational; break;
                                        case 3:
                                            th = Blogtype.Thriller; break;

                                        default:
                                            th = Blogtype.Programming;
                                            break;
                                    }
                                    Blog blog = new Blog(word, task, th);
                                    BlogService.AddBlog(blog);
                                    break;
                                case 2:
                                    Console.WriteLine("id daxil edin:");
                                    int id = int.Parse(Console.ReadLine());
                                    BlogService.RemoveBlog(id);
                                    break;
                                case 3:
                                    Console.WriteLine("id daxil edin:");
                                    int b = int.Parse(Console.ReadLine());
                                    BlogService.GetBlogById(b);
                                    break;
                                case 4:

                                    BlogService.GetAllBlogs();
                                    break;
                                case 5:
                                    Console.WriteLine("deyer daxil edin:");
                                    string value = Console.ReadLine();
                                    BlogService.GetBlogsByValue(value);
                                    break;


                                default:
                                    break;
                            }
                        } while (chack1 != 0);
                        break;
                    default: break;
                }
            } while (chack != 0);

        }
    }
}