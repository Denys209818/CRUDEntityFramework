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
    public partial class CreateModelForm : Form
    {
        public CreateModelForm()
        {
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text) &&
                !string.IsNullOrEmpty(this.txtNormalizedName.Text))
            {
                SettingsConfig.createModelElement = new CreateModelElement 
                {
                    Name = this.txtName.Text,
                    NormalizedName = this.txtNormalizedName.Text
                };

                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Заповніть усі поля!");
            }
        }
    }
}
