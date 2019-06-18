using System;
using ProjetBdd;

namespace ConsoleApp.ExistingDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AirAtlantiqueEntities())
            {
                Console.WriteLine(db.Warehouse);
                db.Airport.Add(new Airport { id = 10, id_City = 10, Name = "John F. Kennedy", Code_AITA = "JFK" });
                Console.WriteLine(db.Airport);
                Console.ReadKey();
                db.Billet.Add(new Billet { id = 10, id_Passenger = 10, id_Price = 10, id_Trip = 10 });
                Console.WriteLine(db.Billet);
                Console.ReadKey();
                db.BilletGP.Add(new BilletGP { id = 10, id_Flight = 10, id_Passenger = 10, id_Salaried = 10, Price = 150 });
                Console.WriteLine(db.BilletGP);
                Console.ReadKey();
                db.City.Add(new City { id = 10, Name = "New York" });
                Console.WriteLine(db.City);
                Console.ReadKey();
                db.Classes.Add(new Classes { id = 10, Prem = "Premiere", Eco_Prem = "EcoPremieres", Eco = "Economique", Business = "Business" });
                Console.WriteLine(db.Classes);
                Console.ReadKey();
                db.Flight.Add(new Flight { id = 10, id_Airport_Start = 10, id_Airport_End = 1, id_Airport_End_Real = 1, Hours_Departure = DateTime.Now, Hours_Arrival = DateTime.Today, Hours_Lift_OFF = DateTime.Now, Hours_Landing = DateTime.Today });
                Console.WriteLine(db.Flight);
                Console.ReadKey();
                db.Incident.Add(new Incident { id = 10, id_Plane = 10, id_Salaried = 10, Severity = 8, Comment = "Trou dans la cabine de pilotage", Date = DateTime.Now });
                Console.WriteLine(db.Incident);
                Console.ReadKey();
                db.Luggage.Add(new Luggage { id = 10, id_Flight = 10, id_Billet = 10, Weight = 20 });
                Console.WriteLine(db.Luggage);
                Console.ReadKey();
                db.Maintenance.Add(new Maintenance { id = 10, id_Incident = 10, id_Warehouse = 10, Date_Start = DateTime.Now, Date_End = DateTime.Today, Description = "Trou dans la carlingue", Place = "New Yrok" });
                Console.WriteLine(db.Maintenance);
                Console.ReadKey();
                db.Passenger.Add(new Passenger { id = 10, First_Name = "Antoine", Name = "Mazoyer", Mail_Address = "a.mazoyer@gmail.com" });
                Console.WriteLine(db.Passenger);
                Console.ReadKey();
                db.Plane.Add(new Plane { id = 10, id_Type=10, id_Warehouse=10, Status=false, Rent=true });
                Console.WriteLine(db.Plane);
                Console.ReadKey();
                db.Price.Add(new Price { id = 10, id_Trip=10, id_Classes=10, id_TypePrice=10, Prix=200, Date=DateTime.Today });
                Console.WriteLine(db.Price);
                Console.ReadKey();
                db.Salaried.Add(new Salaried { id = 10, id_Airport=10, id_Speciality=10, Name="Janio", First_Name="Mathieu", Registration_Number=10, Availability=true, Date_Birth=DateTime.Parse("10/08/2005"), Date_Hiring=DateTime.Now, Nationality="Mexicain", License=true });
                Console.WriteLine(db.Salaried);
                Console.ReadKey();
                db.Speciality.Add(new Speciality { id = 10, Entitled="Pilote", Description="10ans d'expérience dans les longs courriers" });
                Console.WriteLine(db.Speciality);
                Console.ReadKey();
                db.Ticket_Boarding.Add(new Ticket_Boarding { id = 10, id_Flight=10, id_Billet=10, id_BilletGP=10, Number=1010 });
                Console.WriteLine(db.Ticket_Boarding);
                Console.ReadKey();
                db.Trip.Add(new Trip { id = 10, Max_Weight=45 });
                Console.WriteLine(db.Trip);
                Console.ReadKey();
                db.TypePrice.Add(new TypePrice { id = 10, Child="Réduction pour les enfants de moins de 10ans", Reduce="15%", Norm="Le prix de base était de 150€" });
                Console.WriteLine(db.TypePrice);
                Console.ReadKey();
                db.Warehouse.Add(new Warehouse { id = 10, id_Airport=10, Name="Hangar New Yrokais", Available=true });
                Console.WriteLine(db.Warehouse);
                Console.ReadKey();
                Console.WriteLine("Ajout des données dans la base de donnée effectué avec succès ! ");
                Console.ReadKey();

                db.SaveChanges();
            }
        }
    }
}

        
    
