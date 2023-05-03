using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace Hackthon_test_1
{
    class It
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
    class Resource
    {
        List<It> its=new List<It>();
       static int c = 1;
        public void CreateDetails()
        {
            
            Console.WriteLine("Enter the title");
            string title=Console.ReadLine();
            Console.WriteLine("Enter description");
            string description=Console.ReadLine();
            int id=c++;
            Console.WriteLine(id);
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            its.Add(new It() { Title=title,Description=description,Id=id,Date=date});

        }
        public void ViewDetailsId()
        {
            Console.WriteLine("Enter id");
            int id=Convert.ToInt32(Console.ReadLine());
            foreach(It it in its)
            {
                if(it.Id==id)
                {
                    Console.WriteLine("id\ttitle\tdescription\tdate");
                    Console.WriteLine($"{it.Id}\t{it.Title}\t{it.Description}\t{it.Date}");
                    
                }
            }
        }
        public void ViewAllNotes()
        {
            foreach(It it in its)
            {
                Console.WriteLine("id\ttitle\tdescription\tdate");
                Console.WriteLine($"{it.Id}\t{it.Title}\t{it.Description}\t{it.Date}");
                Console.WriteLine($"Total Notes{it.Id}");
            }
        }
       public void UpdateNote()
       {
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (It it in its)
            {
                if(it.Id==id)
                {
                    Console.WriteLine("Enter the update title");
                    it.Title = Console.ReadLine();
                    Console.WriteLine("Enter the update description");
                    it.Description = Console.ReadLine();
                }
            }
       }
        public bool DeleteNote()
        {
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach(It it in its)
            {
                if (it.Id==id)
                {
                    its.Remove(it);
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Resource sc=new Resource();
            //Console.WriteLine("Hello, World!");
            while (true)
            {
                Console.WriteLine("1 for Createdetails");
                Console.WriteLine("2 for VIewDetailsId");
                Console.WriteLine("3 for ViewallNotes");
                Console.WriteLine("4 for UpdateNotes");
                Console.WriteLine("5 for DeleteNote");
                try
                {

                    Console.WriteLine("Enter the choice");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            {
                                sc.CreateDetails();
                                break;
                            }
                        case 2:
                            {
                                sc.ViewDetailsId();
                                break;
                            }
                        case 3:
                            {
                                sc.ViewAllNotes();
                                break;
                            }
                        case 4:
                            {
                                sc.UpdateNote();
                                break;
                            }
                        case 5:
                            {
                                if (sc.DeleteNote())
                                {
                                    Console.WriteLine("Successfully Deleted");
                                }
                                else
                                {
                                    Console.WriteLine("Id not found");
                                }
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Enter valid option");
                                break;

                            }
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Enter only Numbers From 1 to 5");
                }
            }


        }
    }
}