using StarTedModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;           // DbContext is in this namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTedSystem.DAL
{
    // Our DAL class will inherit from EF's DbContext class
    // in order to get all the functionality to map our
    // Entity classes to the database tables.
    // You can think of this context class as being a
    // virtual representation of the database.
    internal class StarTedContext : DbContext
    {
        #region Constructors
        public StarTedContext() : base("name=STdb")
        {
            // We can programmatically prevent the default behavior
            // that EF uses, which is to create the database if it
            // can't find it based on the connection string name above.
            Database.SetInitializer<StarTedContext>(null); // Prevent initialization
        }
        #endregion

        #region Properties
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CurrentOffering> CurrentOfferings { get; set; }
        #endregion
    }
}
