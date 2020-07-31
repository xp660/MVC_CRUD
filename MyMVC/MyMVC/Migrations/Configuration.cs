namespace MyMVC.Migrations
{
    using MyMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMVC.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyMVC.Models.MovieDBContext";
        }

        protected override void Seed(MyMVC.Models.MovieDBContext context)
        {
                    //  This method will be called after migrating to the latest version.

                    //  You can use the DbSet<T>.AddOrUpdate() helper extension method
                    //  to avoid creating duplicate seed data.
                    context.Movies.AddOrUpdate(i => i.Title,
                        new Movie
                        {
                            Title = "高年級實習生",
                            ReleaseDate = DateTime.Parse("2015-9-25"),
                            Genre = "喜劇",
                            Rating = "保護級",
                            Price = 100
                        },
                        new Movie
                        {
                            Title = "走鋼索的人 ",
                            ReleaseDate = DateTime.Parse("2015-10-8"),
                            Genre = "劇情",
                            Rating = "普遍級",
                            Price = 100
                        },

                    new Movie
                    {
                        Title = "動物方城市",
                        ReleaseDate = DateTime.Parse("2016-2-26"),
                        Genre = "動畫",
                        Rating = "普遍級",
                        Price = 150
                    },

                  new Movie
                  {
                      Title = "我就要你好好的",
                      ReleaseDate = DateTime.Parse("2016-6-17"),
                      Genre = "愛情",
                      Rating = "保護級",
                      Price = 200
                  }
             );

        }
    }
}
