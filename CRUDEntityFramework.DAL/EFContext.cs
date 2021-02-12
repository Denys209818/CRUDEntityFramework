using CRUDEntityFramework.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDEntityFramework.DAL
{
    public class EFContext : DbContext
    {
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=denysdb;Username=denys;Password=qwerty1*;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AspNetUserRole>(data => {

                //  Вибірка полів, до яких буде застосовано Constraint PRIMARY KEY
                data.HasKey(userRolePrimaryKey => new { userRolePrimaryKey.RoleId, userRolePrimaryKey.UserId });

                //
                //  ---------------------------------
                //

                //  Вибірка віртуального поля з класу AspNetUser, по якому здійснюється звязок з AspNetUserRole
                data.HasOne(userRoleVirtualColumnFromUser => userRoleVirtualColumnFromUser.User)
                //  Вибірка віртуальної колекції з класу AspNetUserRole, для встановлення звязку з класом AspNetUser
                .WithMany(userRoleVirtualCollectionFromUserRole => userRoleVirtualCollectionFromUserRole.UserRoles)
                //  Вибірка поля(INT), до якого будуть застосовані налаштування ForeignKey
                .HasForeignKey(userRoleIntColumnWithForeignKeySettings => userRoleIntColumnWithForeignKeySettings.UserId)
                //  Встановлю чи поле обовязкове для заповнення
                .IsRequired();

                //
                //  ---------------------------------
                //

                //  Вибірка віртуального поля з класу AspNetRole, для встановлення звязку з AspNetUserRole
                data.HasOne(userRoleVirtualColumnFromRole => userRoleVirtualColumnFromRole.Role)
                //  Вибірка віртуальної колекції з класу AspNetUserRole, для встановлення звязку з AspNetRole
                .WithMany(userRoleVirtualCollectionFromUserRole => userRoleVirtualCollectionFromUserRole.UserRoles)
                //  Вибірка поля (INT), для якого застосовуються налаштування ForeignKey
                .HasForeignKey(userRoleIntColumnFromRoleWithForeignKeySettings => 
                userRoleIntColumnFromRoleWithForeignKeySettings.RoleId)
                //  Встановлює Constraint, що поле є обовязковим для заповенння
                .IsRequired();
            });
        }
    }
}
