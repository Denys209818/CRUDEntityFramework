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
    public partial class DeleteElementForm : Form
    {
        public DeleteElementForm()
        {
            InitializeComponent();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId.Text))
            {
                try
                {
                    SettingsParam.IdDeleted = int.Parse(this.txtId.Text);
                    this.DialogResult = DialogResult.OK;
                }
                catch 
                {
                    MessageBox.Show("Не корректний ввід!");
                }
            } 
            else 
            {
                MessageBox.Show("Заповніть поле!");
            }
        }
    }
}
