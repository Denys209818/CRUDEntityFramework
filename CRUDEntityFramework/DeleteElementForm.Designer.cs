
namespace CRUDEntityFramework
{
    partial class DeleteElementForm
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
            this.btnSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMain.Location = new System.Drawing.Point(80, 27);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(270, 35);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Видалення елемента";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(80, 80);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Ідентифікатор";
            this.txtId.Size = new System.Drawing.Size(270, 41);
            this.txtId.TabIndex = 1;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuccess.Location = new System.Drawing.Point(137, 156);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(156, 58);
            this.btnSuccess.TabIndex = 2;
            this.btnSuccess.Text = "Видалити";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // DeleteElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 226);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMain);
            this.Name = "DeleteElementForm";
            this.Text = "Видалення елемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSuccess;
    }
}