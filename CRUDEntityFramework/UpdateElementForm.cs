using CRUDEntityFramework.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUDEntityFramework
{
    public partial class UpdateElementForm : Form
    {
        public UpdateElementForm()
        {
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (!string.IsNullOrEmpty(this.txtId.Text))
            {
                if (int.TryParse(this.txtId.Text, out a))
                {
                    SettingsParam.UpdatedData = new Models.DialogResultData
                    {
                        Id = int.Parse(this.txtId.Text),
                        Name = string.IsNullOrEmpty(this.txtName.Text) ? string.Empty : this.txtName.Text,
                        Email = string.IsNullOrEmpty(this.txtEmail.Text) ? string.Empty : this.txtEmail.Text,
                        Phone = string.IsNullOrEmpty(this.txtPhone.Text) ? string.Empty : this.txtPhone.Text
                    };

                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("Не коректно введено ідентифікатор!");
                }
            }
            else 
            {
                MessageBox.Show("Заповніть поле Id!");
            }
        }
    }
}
