namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projekat.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Projekat.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Userss.AddOrUpdate(
              p => p.UserName,
              new Models.User
              {
                  UserName = "dani.ristic@gmail.com",
                  Password = "1234",
                  RegistrationDate = new DateTime(1993, 8, 10)
              });

            context.Actors.AddOrUpdate(
             p => p.Name,
             new Models.Actor
             {

                 Name = "Dejms",
                 Surname = "Kameron",
                 BirthPlace = "London",
                 Country = "Us",
                 BirthDate = new DateTime(1999, 10, 10)
             });

            context.Films.AddOrUpdate(
               p => p.Title,
               new Models.Film
               {
                   Title = "LudiMax",
                   Country = "France",
                   Director = "Ime",
                   Genres = "Action",
                   Language = "Engleski",
                   ReleaseDate = new DateTime(2003, 2, 22)
               });
        }
    }
}
