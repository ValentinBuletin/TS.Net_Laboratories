using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            // TestPerson();
            // TestOneToMany();
            TestManyToMany();
            // Console.ReadKey();
        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                string ok = "1";
                while (ok == "1")
                {
                    Console.Write("First Name:\t");
                    string FirstName = Console.ReadLine();
                    Console.Write("Last Name:\t");
                    string LastName = Console.ReadLine();
                    Console.Write("Middle Name:\t");
                    string MiddleName = Console.ReadLine();
                    Console.Write("Telephone Number:\t");
                    string TelephoneNumber = Console.ReadLine();

                    Person p = new Person()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        MiddleName = MiddleName,
                        TelephoneNumber = TelephoneNumber
                    };
                    context.People.Add(p);
                    context.SaveChanges();
                    var items = context.People;
                    Console.Write("\n");
                    foreach (var x in items)
                        Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                    Console.Write("\n");
                    Console.Write("Insert another line? YES(1)NO(0):\t");
                    ok = Console.ReadLine();
                }
            }
        }

        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            string ok = "1";
            List<int> TotalValue = new List<int>();


            while (ok == "1")
            {
                TotalValue.Clear();
                using (Model1Container context = new Model1Container())
                {
                
                    Console.Write("Customer Name:\t");
                    string Name = Console.ReadLine();
                    Console.Write("City:\t");
                    string City = Console.ReadLine();


                    Console.Write("How many orders?:\t");
                    int index = int.Parse(Console.ReadLine());

                    for (int i = 0; i < index; i++)
                    {
                        Console.Write("Value of order {0}:\t", i + 1);
                        TotalValue.Add(int.Parse(Console.ReadLine()));
                    }

                    Customer c = new Customer()
                    {
                        Name = Name,
                        City = City
                    };
                    context.Customers.Add(c);

                    for (int i = 0; i < index; i++)
                    {
                        Order o = new Order()
                        {
                            TotalValue = TotalValue[i],
                            Date = DateTime.Now,
                            Customer = c
                        };

                        context.Orders.Add(o);
                    }
                    context.SaveChanges();

                    var items = context.Customers;
                    Console.Write("\n");
                    foreach (var x in items)
                    {
                        Console.WriteLine("Customer {0}: {1}, {2}", x.CustomerId, x.Name, x.City);
                        foreach (var ox in x.Orders)
                            Console.WriteLine("\tOrder {0}: {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                    }
                    Console.Write("\n");
                    Console.Write("Insert another line? YES(1)NO(0):\t");
                    ok = Console.ReadLine();
                }
            }
        }

        static void TestManyToMany()
        {
            Console.WriteLine("Many to many");
            string ok = "1";
            ICollection<Album> tmp = new Collection<Album>();

            while (ok == "1")
            {
                tmp.Clear();
                using (Model1Container context = new Model1Container())
                {
                
                    Console.Write("Artist First Name:\t");
                    string FirstName = Console.ReadLine();
                    Console.Write("Artist Last Name:\t");
                    string LastName = Console.ReadLine();

                    Console.Write("How many albums?:\t");
                    int index = int.Parse(Console.ReadLine());

                    for (int i = 0; i < index; i++)
                    {
                        Console.Write("Album {0} Name:\t", i+1);
                        string AlbumName = Console.ReadLine();

                        Album alb = new Album()
                        {
                            AlbumName = AlbumName
                        };
                        context.Albums.Add(alb);
                        context.SaveChanges();
                        tmp.Add(alb);
                    }

                    Artist art = new Artist()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Albums = tmp
                    };
                    context.Artists.Add(art);
                    context.SaveChanges();

                    var items = context.Artists;
                    Console.Write("\n");
                    foreach (var x in items)
                    {
                        Console.WriteLine("Artist: {0} {1}", x.FirstName, x.LastName);
                        foreach (var ox in x.Albums)
                            Console.WriteLine("\tAlbum: {0}", ox.AlbumName);
                    }
                    Console.Write("\n");
                    Console.Write("Insert another line? YES(1)NO(0):\t");
                    ok = Console.ReadLine();
                }
            }
        }
    }
}