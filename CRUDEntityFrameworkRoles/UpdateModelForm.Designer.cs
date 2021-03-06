﻿
namespace CRUDEntityFrameworkRoles
{
    partial class UpdateModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMain = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNormalizedName = new System.Windows.Forms.TextBox();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMain.Location = new System.Drawing.Point(106, 22);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(223, 35);
            this.lblMain.Text = "Головна сторінка";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(80, 93);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Ідентифікатор";
            this.txtId.Size = new System.Drawing.Size(275, 41);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(80, 173);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Назва";
            this.txtName.Size = new System.Drawing.Size(275, 41);
            // 
            // txtNormalizedName
            // 
            this.txtNormalizedName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNormalizedName.Location = new System.Drawing.Point(80, 255);
            this.txtNormalizedName.Name = "txtNormalizedName";
            this.txtNormalizedName.PlaceholderText = "Повна назва";
            this.txtNormalizedName.Size = new System.Drawing.Size(275, 41);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(110, 330);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(215, 69);
            this.btnSuccess.Text = "Обновити";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // UpdateModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 423);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.txtNormalizedName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMain);
            this.Name = "UpdateModelForm";
            this.Text = "Редагування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNormalizedName;
        private System.Windows.Forms.Button btnSuccess;
    }
}