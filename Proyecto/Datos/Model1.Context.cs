﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DAVEntities : DbContext
    {
        public DAVEntities()
            : base("name=DAVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Contenidos> Contenidos { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Opciones> Opciones { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<Pruebas> Pruebas { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
        public virtual DbSet<Resultados> Resultados { get; set; }
        public virtual DbSet<Segmentos> Segmentos { get; set; }
    }
}
