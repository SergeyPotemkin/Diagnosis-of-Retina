﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiagnosisOfRetinal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DOR_dbEntities : DbContext
    {
        public DOR_dbEntities()
            : base("name=DOR_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area_of_folds> Area_of_folds { get; set; }
        public virtual DbSet<Corner_variability> Corner_variability { get; set; }
        public virtual DbSet<Correlation> Correlations { get; set; }
        public virtual DbSet<Critical_points> Critical_points { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<EachHole> EachHoles { get; set; }
        public virtual DbSet<Folding> Foldings { get; set; }
        public virtual DbSet<Fourier_params> Fourier_params { get; set; }
        public virtual DbSet<Fovea> Foveas { get; set; }
        public virtual DbSet<Hole> Holes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Snapshot> Snapshots { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
    }
}