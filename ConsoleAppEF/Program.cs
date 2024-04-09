using ConsoleAppEF.DbContexts;
using ConsoleAppEF.Models;
using Microsoft.EntityFrameworkCore;

AppDbContext dbContext = new AppDbContext();

User user = new User()
{
    Name = "Akmal",
    LastName = "Sharifxo'jayev"
   

};

dbContext.Add(user);
dbContext.SaveChanges();
