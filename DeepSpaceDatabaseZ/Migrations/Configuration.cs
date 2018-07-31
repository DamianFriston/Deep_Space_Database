namespace DeepSpaceDatabaseZ.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DeepSpaceDatabaseZ.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DeepSpaceDatabaseZ.Models.SpaceObjectDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DeepSpaceDatabaseZ.Models.SpaceObjectDBContext context)
        {
            context.SpaceObjects.AddOrUpdate(i => i.Name,
                new SpaceObject
                {
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Andromeda_Galaxy_%28with_h-alpha%29.jpg/1200px-Andromeda_Galaxy_%28with_h-alpha%29.jpg",
                    Name = "Andromeda Galaxy",
                    Magnitude = 3.44f,
                    Category = "Spiral Galaxy",
                    Distance = "2.537 million"
                },

                 new SpaceObject
                 {
                     URL = "https://upload.wikimedia.org/wikipedia/commons/3/3f/NGC_2244_Rosette_Nebula.jpg",
                     Name = "Rosette Nebula",
                     Magnitude = 9,
                     Category = "Nebula",
                     Distance = "5,200"
                 },

                 new SpaceObject
                 {
                     URL = "http://www.nightsky.at/Photo/Neb/B33_Newton.jpg",
                     Name = "Horse head Nebula",
                     Magnitude = 6.8f,
                     Category = "Nebula",
                     Distance = "1,500"
                 },

                 new SpaceObject
                 {
                     URL = "https://c1.staticflickr.com/6/5477/12167738066_2f37740ee3_b.jpg",
                     Name = "Cigar Galaxy",
                     Magnitude = 8.41f,
                     Category = "Starburst Galaxy",
                     Distance = "11.42 million"
                 },

                new SpaceObject
                {
                    URL = "https://i.ytimg.com/vi/EOSDDiMOA08/maxresdefault.jpg",
                    Name = "Eagle Neblula",
                    Magnitude = 6,
                    Category = "Nebula",
                    Distance = "7,000"

                },

                new SpaceObject
                {
                    URL = "http://www.dl-digital.com/images/Astronomy/Messier-Images/Trifid-Redo-Comb-CPNR5.jpg",
                    Name = "Trifid Nebula",
                    Magnitude = 6.3f,
                    Category = "Nebula",
                    Distance = "5,200"

                },

                new SpaceObject
                {
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/M33_-_Triangulum_Galaxy.jpg/1200px-M33_-_Triangulum_Galaxy.jpg",
                    Name = "Triangulum Galaxy",
                    Magnitude = 5.72f,
                    Category = "Spiral Galaxy",
                    Distance = "2.723 million"

                }

           );

        }

    }

}

    
