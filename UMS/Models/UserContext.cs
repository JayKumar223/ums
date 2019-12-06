using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class UserContext : DbContext /*This is just usercontext not model*/
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {



        }

        public DbSet <User> user {get; set;}


    }
}
