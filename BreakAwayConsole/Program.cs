using Model;
using DataAccess;
using System.Data.Entity;
using System.Linq;


namespace BreakAwayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BreakAwayContext>());
            InsertDestination();
        }


        private static void InsertDestination()
        {
            var destination = new Destination()
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bali"
            };

            using (var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }

            var c = new BreakAwayContext();
            foreach (Destination d in c.Destinations)
            {
                System.Console.WriteLine("name is: " + d.Name + " - description is: " + d.Description);
            }


            foreach (Destination d in c.Destinations)
            {
                d.Description += "a test change";
            }

            c.SaveChanges();


            foreach (Destination d in c.Destinations)
            {
                System.Console.WriteLine("name is: " + d.Name + " - description is: " + d.Description);
            }

            using (c)
            {
                var destQueryResult = from d in c.Destinations
                                      where d.Country == "Indonesia"
                                        select d;

                foreach (Destination d in destQueryResult)
                {
                    System.Console.WriteLine("i foud one at destinationid " + d.DestinationId);
                }

            }

            System.Console.ReadLine();
            

        }
    }

   
}
