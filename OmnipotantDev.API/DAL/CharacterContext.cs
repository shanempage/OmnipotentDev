
using OmnipotantDev.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OmnipotantDev.API.DAL
{
    public class CharacterContext: DbContext
    {
        public CharacterContext()
            : base("CharacterContext")
        {
            
        }

        public DbSet<Character> Characters { get; set; }
        
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            

        }

        
    }
}