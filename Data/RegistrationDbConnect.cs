using Microsoft.EntityFrameworkCore;
using RegistrationByASPdotNetCoreMVC.Models;

namespace RegistrationByASPdotNetCoreMVC.Data
{
    public class RegistrationDbConnect: DbContext
    {



        // this is by sagar for create table in database
        // Constructor to pass the DbContextOptions to the base class.
        public RegistrationDbConnect(DbContextOptions<RegistrationDbConnect> options) : base(options)
        {
        }


        // this is by sagar for create table in database
        public DbSet<Registration> Registration { get; set; }


    }
}
