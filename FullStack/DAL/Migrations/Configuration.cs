namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PostConext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PostConext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for(int i=1; i<=10; i++)
            {
                context.users.AddOrUpdate(new Models.User
                {
                    Name=Guid.NewGuid().ToString().Substring(0,12),
                    Uname="user-"+i,
                    Type="General",
                    Email="user"+i+"@gmail.com",
                    Password=Guid.NewGuid().ToString().Substring(0,8),
                });
            }
            Random random= new Random();
            for(int i=1; i<=20; i++)
            {
                context.posts.AddOrUpdate(new Models.Post
                {
                    Id=i,
                    Title=Guid.NewGuid().ToString().Substring(0,5),
                    Description=Guid.NewGuid().ToString(),
                    Date=DateTime.Now,
                    PostedBy = "user-"+random.Next(1,11),
                });
            }
        }
    }
}
