﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMS.Models;

namespace PMS.Data;

public class PMSDbContext: IdentityDbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=pmsdb_BIT;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
