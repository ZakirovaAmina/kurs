using System;
using System.Collections.Generic;
using HotelDatabaseImplement.Models;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HotelDatabaseImplement
{
    public class HotelDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HotelDB5;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);

        }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<ConfRoom> ConfRooms { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Payment> Payments { set; get; }
        public virtual DbSet<Expense> Expenses { set; get; }
        public virtual DbSet<Conf> Confs { set; get; }
        public virtual DbSet<Room> Rooms { set; get; }
    }
}

