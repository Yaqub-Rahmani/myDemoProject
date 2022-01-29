using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<AdminLar> AdminLars { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contect> Contects { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<HomeTopCont> HomeTopConts { get; set; }
        public DbSet<infoContect> infoContects { get; set; }
        public DbSet<WeOffer> WeOffers { get; set; }
        public DbSet<WhatWeDo> whatWeDos { get; set; }
    }
}
