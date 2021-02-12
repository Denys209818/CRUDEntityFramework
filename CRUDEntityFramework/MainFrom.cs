using CRUDEntityFramework.Config;
using CRUDEntityFramework.DAL;
using CRUDEntityFramework.DAL.Entities;
using CRUDEntityFramework.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEntityFramework
{
    public partial class MainFrom : Form
    {
        public EFContext _context { get; set; }
        public MainFrom()
        {
            _context = new EFContext();
            InitializeComponent();

            Seeder.SeedAll(_context);
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            RestartDataGried();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateElementForm form = new CreateElementForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                AspNetUser user = new AspNetUser
                {
                    UserName = SettingsParam.data.Name,
                    NormalizedUserName = SettingsParam.data.Name,
                    Email = SettingsParam.data.Email,
                    EmailConfirmed = true,
                    NormalizedEmail = SettingsParam.data.Email,
                    PhoneNumber = SettingsParam.data.Phone,
                    PhoneNumberConfirmed = true,
                    PasswordHash = "123",
                    LockoutEnd = DateTime.Now,
                    LockoutEnabled = true,
                    SecurityStamp = "",
                    ConcurrencyStamp = "",
                    AccessFailedCount = "",
                    TwoFactorEnabled = true,
                };
                this._context.AspNetUsers.Add(user);
                this._context.SaveChanges();

                this._context.AspNetUserRoles.Add(new AspNetUserRole
                {
                   RoleId = SettingsParam.data.Role.Id,
                   UserId = user.Id
                });
                this._context.SaveChanges();
                MessageBox.Show("Створено!");
            }
        }
        private void RestartDataGried() 
        {
            this.dtwUsers.Rows.Clear();
            var list = _context.AspNetUserRoles.Select(x => new {
                Id = x.User.Id,
                Name = x.User.UserName,
                Email = x.User.Email,
                Phone = x.User.PhoneNumber,
                RoleName = x.Role.Name
            });

            foreach (var item in list)
            {
                object[] obj =
                {
                    item.Id,
                    item.Name,
                    item.Email,
                    item.Phone,
                    item.RoleName
                };

                this.dtwUsers.Rows.Add(obj);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteElementForm form = new DeleteElementForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                var el = this._context.AspNetUsers.Where(x => x.Id == SettingsParam.IdDeleted)
                    .FirstOrDefault();
                if (el != null)
                {
                    var coll = this._context.AspNetUserRoles.Where(x => x.UserId == el.Id).ToArray();
                    this._context.RemoveRange(coll);
                    this._context.SaveChanges();

                    this._context.Remove(el);
                    this._context.SaveChanges();
                    MessageBox.Show("Видалено!");
                    this.RestartDataGried();
                }
                else 
                {
                    MessageBox.Show("Не знайдено елемент!");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateElementForm form = new UpdateElementForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                var element = this._context.AspNetUsers.Where(x => x.Id == SettingsParam.UpdatedData.Id).FirstOrDefault();
                if (element != null)
                {
                    if (!string.IsNullOrEmpty(SettingsParam.UpdatedData.Name))
                    {
                        element.UserName = SettingsParam.UpdatedData.Name;
                        element.NormalizedUserName = SettingsParam.UpdatedData.Name;
                    }

                    if (!string.IsNullOrEmpty(SettingsParam.UpdatedData.Email))
                    {
                        element.Email = SettingsParam.UpdatedData.Email;
                        element.NormalizedEmail = SettingsParam.UpdatedData.Email;
                    }

                    if (!string.IsNullOrEmpty(SettingsParam.UpdatedData.Phone))
                    {
                        element.PhoneNumber = SettingsParam.UpdatedData.Phone;
                        element.PhoneNumberConfirmed = true;
                    }

                    this._context.SaveChanges();
                    this.RestartDataGried();
                }
                else 
                {
                    MessageBox.Show("Поля не знайдено!");
                }
            }
        }
        private void MainFrom_Load(object sender, EventArgs e)
        {
            this.RestartDataGried();
        }
    }
}
