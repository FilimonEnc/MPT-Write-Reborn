using DomainLair.DataBase.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase
{
    public class DataBaseContext : DbContext
    {
        private const string standartPath = "./MPTList.db";
        private static bool isFirstConnection = true;

        public DataBaseContext() : base()
        {
            if(isFirstConnection)
            {
                Database.Migrate();
                isFirstConnection = false;
            }
        }
        public DbSet<GroupEntity> GroupsEntitys { get; set; }
        public DbSet<TeacherEntity> TeachersEntitys { get; set; }
        public DbSet<SubjectEntity> SubjectsEntitys { get; set; }
        public DbSet<SubjectTeacherEntity> SubjectsTeachers { get; set; }
        public DbSet<GroupTeacherEntity> GroupsTeachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options )=> options.UseSqlite($"Data Source={standartPath}");

    }
}
//Add-Migration Init -Project DomainLair
