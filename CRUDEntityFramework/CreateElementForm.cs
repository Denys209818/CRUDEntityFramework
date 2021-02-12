using CRUDEntityFramework.Config;
using CRUDEntityFramework.DAL;
using CRUDEntityFramework.DAL.Entities;
using CRUDEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUDEntityFramework
{
    public partial class CreateElementForm : Form
    {
        private EFContext _context { get; set; }
        public CreateElementForm()
        {
            _context = new EFContext();
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text)
                && !string.IsNullOrEmpty(this.txtEmail.Text)
                && !string.IsNullOrEmpty(this.txtPhone.Text))
            {
                SettingsParam.data = new Models.DialogResultData
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Role =  cbRoles.SelectedItem as RoleObject
                };
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Заповніть усі поля!");
            }
        }

        private void CreateElementForm_Load(object sender, EventArgs e)
        {
            var list = this._context.AspNetRoles.Select(x => new RoleObject
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
            this.cbRoles.Items.AddRange(list);

            this.cbRoles.SelectedIndex = 0;
        }
    }
}
