using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantiqueORM
{
    class Program
    {
        private void AjoutEnBDD()
        {
            Airport airport = new Airport
            {
                id = 10,
                id_City = 10,
                Name = "John F. Kennedy",
                Code_AITA = "JFK"
            };

            Billet billet = new Billet
            {
                id = 10,
                id_Passenger = 10,
                id_Price = 10,
                id_Trip = 10
            };

            BilletGP billetgp = new BilletGP
            {
                id = 10,
                id_Flight = 10,
                id_Passenger = 10,
                id_Salaried = 10,
                Price = 250
            };

            City city = new City
            {
                id = 10,
                Name = "New York"
            };

            Classes classes = new Classes
            {
                id = 10,
                Prem = "Premieres",
                Eco_Prem = "EcoPremieres",
                Eco = "Economiques",
                Business = "Businesses"
            };

            Flight flight = new Flight
            {
                id = 10,
                id_Airport_Start = 10,
                id_Airport_End = 1,
                id_Airport_End_Real = 1,
                Hours_Departure = DateTime.Now,
                Hours_Arrival = DateTime.Today,
                Hours_Lift_OFF = DateTime.Now,
                Hours_Landing = DateTime.Today
            };

            Incident incident = new Incident
            {
                id = 10,
                id_Plane = 10,
                id_Salaried = 10,
                Severity = 8,
                Comment = "Troue dans la cabine de pilotage.",
                Date = DateTime.Now
            };

            Luggage luggage = new Luggage
            {
                id = 10,
                id_Flight = 10,
                id_Billet = 10,
                Weight = 20
            };

            Maintenance maintenance = new Maintenance
            {
                id = 10,
                id_Incident = 10,
                id_Warehouse = 10,
                Date_Start = DateTime.Now,
                Date_End = DateTime.Today,
                Description = "Troue dans la carlingue.",
                Place = "New York"
            };

            Passenger passenger = new Passenger
            {
                id = 10,
                First_Name = "Antoine",
                Name = "Mazoyer",
                Mail_Address = "a.mazoyer@gmail.com"
            };

            Plane plane = new Plane
            {
                id = 10,
                id_Type = 10,
                id_Warehouse = 10,
                Status = false,
                Rent = true
            };

            Price price = new Price
            {
                id = 10,
                id_Trip = 10,
                id_Classes = 10,
                id_TypePrice = 10,
                Prix = 200,
                Date = DateTime.Today
            };

            Salaried salaried = new Salaried
            {
                id = 10,
                id_Airport = 10,
                id_Speciality = 10,
                Name = "Janio",
                First_Name = "Mathieu",
                Registration_Number = 10,
                Availability = true,
                Date_Birth = DateTime.Parse("10 / 08 / 2005"),
                Date_Hiring = DateTime.Now,
                Nationality = "Mexicaine",
                License = false
            };

            Speciality speciality = new Speciality
            {
                id = 10,
                Entitled = "Pilote",
                Description = "10ans d'espérience dans les longs courrier."
            };

            Ticket_Boarding ticket_Boarding = new Ticket_Boarding
            {
                id = 10,
                id_Flight = 10,
                id_Billet = 10,
                id_BilletGP = 10,
                Number = 1010
            };

            Trip trip = new Trip
            {
                id = 10,
                Max_Weight = 45
            };

            Type type = new Type
            {
                id = 10,
                Name = "Cargo",
                Motor = "UltraRaptor",
                Nb_Eco_Places = 150,
                Nb_EcoPrem_Places = 50,
                Nb_Business_Places = 35,
                Nb_Premiere_Places = 20,
                Nb_Crew_Places = 5
            };

            TypePrice typePrice = new TypePrice
            {
                id = 10,
                Child = "Réduction pour les enfants de moins de 10ans.",
                Reduce = "15%",
                Norm = "Le prix de base était de 150€"
            };

            Warehouse warehouse = new Warehouse
            {
                id = 10,
                id_Airport = 10,
                Name = "Hangar New Yorkais",
                Available = true
            };


            Console.WriteLine("Ajout des données dans la base de donnée effectué avec succès ! ");
            Console.ReadKey();
        }
    }
}
