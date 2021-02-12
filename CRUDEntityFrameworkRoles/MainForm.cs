using CRUDEntityFramework.DAL;
using CRUDEntityFramework.DAL.Entities;
using CRUDEntityFrameworkRoles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEntityFrameworkRoles
{
    public partial class MainForm : Form
    {
        public EFContext _context { get; set; }
        public MainForm()
        {
            this._context = new EFContext();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadData();
        }
        private void ReadData() 
        {
            var list = this._context.AspNetRoles.Select(x => new { 
            Id = x.Id,
            Name = x.Name,
            NormalizedName = x.NormalizedName
            });

            foreach (var item in list) 
            {
                object[] obj = 
                {
                    item.Id,
                    item.Name,
                    item.NormalizedName
                };
                this.dtwRole.Rows.Add(obj);
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            this.dtwRole.Rows.Clear();
            ReadData();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateModelForm form = new CreateModelForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                AspNetRole role = new AspNetRole 
                {
                    Name = SettingsConfig.createModelElement.Name,
                    NormalizedName = SettingsConfig.createModelElement.NormalizedName,
                    ConcurrencyStamp = ""
                };

                this._context.AspNetRoles.Add(role);
                this._context.SaveChanges();
                MessageBox.Show("Створено!");
            }
            this.dtwRole.Rows.Clear();
            this.ReadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteModelForm form = new DeleteModelForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                var el = this._context.AspNetRoles.Where(x => x.Id == SettingsConfig.DeletedId).FirstOrDefault();
                if (el != null)
                {
                    this._context.AspNetRoles.Remove(el);
                    this._context.SaveChanges();
                    MessageBox.Show("Видалено!");
                    this.dtwRole.Rows.Clear();
                    this.ReadData();
                }
                else 
                {
                    MessageBox.Show("Не знайдено елемента!");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateModelForm form = new UpdateModelForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                var el = this._context.AspNetRoles.Where(x => x.Id == SettingsConfig.UpdateElement.Id).FirstOrDefault();
                if (el != null)
                {
                    if (!string.IsNullOrEmpty(SettingsConfig.UpdateElement.Name)) 
                    {
                        el.Name = SettingsConfig.UpdateElement.Name;
                    }
                    if (!string.IsNullOrEmpty(SettingsConfig.UpdateElement.NormalizedName)) 
                    {
                        el.NormalizedName = SettingsConfig.UpdateElement.NormalizedName;
                    }

                    this._context.SaveChanges();
                }
                else 
                {
                    MessageBox.Show("Елемент не знайдено!");
                }
            }
            this.dtwRole.Rows.Clear();
            this.ReadData();
        }
    }
}
