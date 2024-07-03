using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Theme_32_Lesson_3_Manage_DB;

public partial class TitanicPassengersContext : DbContext
{
    public TitanicPassengersContext()
    {
    }

    public TitanicPassengersContext(DbContextOptions<TitanicPassengersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Passenger> Passengers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\Users\\\\\\\\User\\\\\\\\source\\\\\\\\repos\\\\\\\\DB_Projects\\\\\\\\Theme_32_Lesson_3_Manage_DB\\\\\\\\bin\\\\\\\\Debug\\\\\\\\net8.0\\\\\\\\TitanicPassengers.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
