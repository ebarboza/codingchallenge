namespace CodingChallenge.WebApi.Migrations
{
    using CodingChallenge.WebApi.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CodingChallenge.WebApi.Models.CodingChallengeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodingChallenge.WebApi.Models.CodingChallengeContext context)
        {
            
            context.User.AddOrUpdate(x => x.Id,
                new User() { Id = 1, FirstName = "Jonh", LastName="Doe" },
                new User() { Id = 2, FirstName = "Charles", LastName = "Soller" },
                new User() { Id = 3, FirstName = "Mike", LastName = "Dickson" }
            );

            context.Project.AddOrUpdate(x => x.Id,
                new Project() { Id = 1, StartDate = DateTime.Now.AddDays(-30) , EndDate = DateTime.Now.AddDays(40), Credits = 2 },
                new Project() { Id = 2, StartDate = DateTime.Now.AddDays(5), EndDate = DateTime.Now.AddDays(100), Credits = 3 },
                new Project() { Id = 3, StartDate = DateTime.Now.AddDays(-90), EndDate = DateTime.Now.AddDays(30), Credits = 1 },
                new Project() { Id = 4, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(45), Credits = 4 },
                new Project() { Id = 5, StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddDays(60), Credits = 3 },
                new Project() { Id = 6, StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(90), Credits = 5 },
                new Project() { Id = 7, StartDate = DateTime.Now.AddDays(90), EndDate = DateTime.Now.AddDays(360), Credits = 2 },
                new Project() { Id = 8, StartDate = DateTime.Now.AddDays(45), EndDate = DateTime.Now.AddDays(180), Credits = 4 },
                new Project() { Id = 9, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(150), Credits = 1 },
                new Project() { Id = 10, StartDate = DateTime.Now.AddDays(-60), EndDate = DateTime.Now.AddDays(120), Credits = 2 }
            );

            //User #1 
            context.UserProject.AddOrUpdate(x => new { x.UserId , x.ProjectId },
                new UserProject() { UserId = 1, ProjectId = 1, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) },
                new UserProject() { UserId = 1, ProjectId = 3, IsActive = true, AssignedDate = DateTime.Now.AddDays(5) },
                new UserProject() { UserId = 1, ProjectId = 5, IsActive = false, AssignedDate = DateTime.Now.AddDays(30) },
                new UserProject() { UserId = 1, ProjectId = 7, IsActive = true, AssignedDate = DateTime.Now.AddDays(-15) },
                new UserProject() { UserId = 1, ProjectId = 9, IsActive = false, AssignedDate = DateTime.Now.AddDays(2) }
                );

            //User #2
            context.UserProject.AddOrUpdate(x => new { x.UserId , x.ProjectId },
                 new UserProject() { UserId = 2, ProjectId = 2, IsActive = false, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 2, ProjectId = 4, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 2, ProjectId = 6, IsActive = false, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 2, ProjectId = 8, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 2, ProjectId = 10, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) }
                 );

             //User #3 
             context.UserProject.AddOrUpdate(x => new { x.UserId , x.ProjectId },
                 new UserProject() { UserId = 3, ProjectId = 1, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 3, ProjectId = 2, IsActive = true, AssignedDate = DateTime.Now.AddDays(-10) },
                 new UserProject() { UserId = 3, ProjectId = 5, IsActive = true, AssignedDate = DateTime.Now.AddDays(15) },
                 new UserProject() { UserId = 3, ProjectId = 8, IsActive = true, AssignedDate = DateTime.Now.AddDays(5) },
                 new UserProject() { UserId = 3, ProjectId = 9, IsActive = false, AssignedDate = DateTime.Now.AddDays(-10) }
                 );
        }
    }
}
