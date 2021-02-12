using CRUDEntityFrameworkRoles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUDEntityFrameworkRoles
{
    public partial class UpdateModelForm : Form
    {
        public UpdateModelForm()
        {
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId.Text))
            {
                int a;
                if (int.TryParse(this.txtId.Text, out a))
                {
                    SettingsConfig.UpdateElement = new UpdateModelElement
                    {
                        Id = int.Parse(this.txtId.Text),
                        Name = string.IsNullOrEmpty(this.txtName.Text) ? string.Empty : this.txtName.Text,
                        NormalizedName = string.IsNullOrEmpty(this.txtNormalizedName.Text) ? string.Empty : this.txtNormalizedName.Text
                    };
                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("Введіть коректний ідентифікатор!");
                }
            }
            else 
            {
                MessageBox.Show("Поле ідентифікатор пусте!");
            }
        }
    }
}
