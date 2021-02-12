using CRUDEntityFramework.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDEntityFramework.DAL.Services
{
    public static class Seeder
    {
        public static void SeedAll(EFContext context) 
        {
            SeedUser(context);
            SeedRole(context);
            SeedUserRole(context);
        }
        private static void SeedUser(EFContext context) 
        {
            if (context.AspNetUsers.Count() == 0) 
            {
                context.AspNetUsers.AddRange(new List<AspNetUser> {
                new AspNetUser
                {
                    UserName = "Vasja",
                    NormalizedUserName = "Vasja Petrov",
                    Email = "vasja@gmail.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "vasja@gmail.com",
                    PhoneNumber = "28289374234",
                    PhoneNumberConfirmed = true,
                    PasswordHash = "123",
                    LockoutEnd = DateTime.Now,
                    LockoutEnabled = true,
                    SecurityStamp = "",
                    ConcurrencyStamp = "",
                    AccessFailedCount = "",
                    TwoFactorEnabled = true
                },
                new AspNetUser
                {
                    UserName = "Ivan",
                    NormalizedUserName = "Ivan Ivanov",
                    Email = "ivan@gmail.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "ivan@gmail.com",
                    PhoneNumber = "342352623226",
                    PhoneNumberConfirmed = true,
                    PasswordHash = "321",
                    LockoutEnd = DateTime.Now,
                    LockoutEnabled = true,
                    SecurityStamp = "",
                    ConcurrencyStamp = "",
                    AccessFailedCount = "",
                    TwoFactorEnabled = true
                },
                new AspNetUser
                {
                    UserName = "Dmytro",
                    NormalizedUserName = "Dmytro Modric",
                    Email = "dmytro@gmail.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "dmytro@gmail.com",
                    PhoneNumber = "5235235151",
                    PhoneNumberConfirmed = true,
                    PasswordHash = "654",
                    LockoutEnd = DateTime.Now,
                    LockoutEnabled = true,
                    SecurityStamp = "",
                    ConcurrencyStamp = "",
                    AccessFailedCount = "",
                    TwoFactorEnabled = true
                }
                });
                context.SaveChanges();
            }
        }
        private static void SeedRole(EFContext context) 
        {
            if (context.AspNetRoles.Count() == 0) 
            {
                context.AspNetRoles.AddRange(new List<AspNetRole> { 
                new AspNetRole
                {
                    Name = "Doctor",
                    NormalizedName = "Dietolog",
                    ConcurrencyStamp = ""
                },
                new AspNetRole
                {
                    Name = "Manager",
                    NormalizedName = "Manager for Sales",
                    ConcurrencyStamp = ""
                },
                new AspNetRole
                {
                    Name = "Teacher",
                    NormalizedName = "Teachet IT Technologies",
                    ConcurrencyStamp = ""
                }
                });
                context.SaveChanges();
            }
        }
        private static void SeedUserRole(EFContext context) 
        {
            if (context.AspNetUserRoles.Count() == 0) 
            {
                context.AspNetUserRoles.AddRange(new List<AspNetUserRole> { 
                    new AspNetUserRole
                    {
                        UserId = 1,
                        RoleId = 3
                    },
                    new AspNetUserRole
                    {
                        UserId = 2, 
                        RoleId = 1
                    },
                    new AspNetUserRole
                    {
                        UserId = 3,
                        RoleId = 2
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
