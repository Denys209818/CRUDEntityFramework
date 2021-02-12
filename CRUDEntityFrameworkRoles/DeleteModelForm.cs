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
    public partial class DeleteModelForm : Form
    {
        public DeleteModelForm()
        {
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId.Text))
            {
                int a = 0;
                if (int.TryParse(this.txtId.Text, out a))
                {
                    SettingsConfig.DeletedId = int.Parse(this.txtId.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Некорректно введено ідентифікатор!");
                }
            }
            else 
            {
                MessageBox.Show("Заповніть усі поля!");
            }
        }
    }
}
