
namespace CRUDEntityFrameworkRoles
{
    partial class CreateModelForm
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
            this.lblMain.Location = new System.Drawing.Point(123, 30);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(213, 35);
            this.lblMain.Text = "Додати елемент";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(60, 107);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Назва";
            this.txtName.Size = new System.Drawing.Size(332, 41);
            // 
            // txtNormalizedName
            // 
            this.txtNormalizedName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNormalizedName.Location = new System.Drawing.Point(60, 205);
            this.txtNormalizedName.Name = "txtNormalizedName";
            this.txtNormalizedName.PlaceholderText = "Повна назва";
            this.txtNormalizedName.Size = new System.Drawing.Size(332, 41);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(138, 310);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(171, 72);
            this.btnSuccess.Text = "Добавити";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // CreateModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 406);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.txtNormalizedName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMain);
            this.Name = "CreateModelForm";
            this.Text = "Створити елемент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNormalizedName;
        private System.Windows.Forms.Button btnSuccess;
    }
}