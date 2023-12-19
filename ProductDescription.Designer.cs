
namespace oruzh
{
    partial class ProductDescription
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
            this.close_but = new System.Windows.Forms.Label();
            this.idProductLab = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.costLab = new System.Windows.Forms.Label();
            this.quanLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descrLab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close_but
            // 
            this.close_but.AutoSize = true;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_but.Location = new System.Drawing.Point(779, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(22, 25);
            this.close_but.TabIndex = 4;
            this.close_but.Text = "x";
            // 
            // idProductLab
            // 
            this.idProductLab.AutoSize = true;
            this.idProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idProductLab.Location = new System.Drawing.Point(12, 55);
            this.idProductLab.Name = "idProductLab";
            this.idProductLab.Size = new System.Drawing.Size(35, 29);
            this.idProductLab.TabIndex = 5;
            this.idProductLab.Text = "id";
            // 
            // nameLab
            // 
            this.nameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLab.Location = new System.Drawing.Point(12, 9);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(562, 40);
            this.nameLab.TabIndex = 6;
            this.nameLab.Text = "name";
            this.nameLab.Click += new System.EventHandler(this.nameLab_Click);
            // 
            // costLab
            // 
            this.costLab.AutoSize = true;
            this.costLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLab.Location = new System.Drawing.Point(218, 60);
            this.costLab.Name = "costLab";
            this.costLab.Size = new System.Drawing.Size(57, 29);
            this.costLab.TabIndex = 7;
            this.costLab.Text = "cost";
            this.costLab.Click += new System.EventHandler(this.costLab_Click);
            // 
            // quanLab
            // 
            this.quanLab.AutoSize = true;
            this.quanLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quanLab.Location = new System.Drawing.Point(425, 58);
            this.quanLab.Name = "quanLab";
            this.quanLab.Size = new System.Drawing.Size(95, 29);
            this.quanLab.TabIndex = 8;
            this.quanLab.Text = "quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(580, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descrLab
            // 
            this.descrLab.BackColor = System.Drawing.SystemColors.Info;
            this.descrLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrLab.Location = new System.Drawing.Point(18, 102);
            this.descrLab.Multiline = true;
            this.descrLab.Name = "descrLab";
            this.descrLab.ReadOnly = true;
            this.descrLab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descrLab.Size = new System.Drawing.Size(556, 186);
            this.descrLab.TabIndex = 11;
            this.descrLab.TabStop = false;
            // 
            // ProductDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.descrLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quanLab);
            this.Controls.Add(this.costLab);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.idProductLab);
            this.Controls.Add(this.close_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDescription";
            this.Load += new System.EventHandler(this.ProductDescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_but;
        private System.Windows.Forms.Label idProductLab;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label costLab;
        private System.Windows.Forms.Label quanLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descrLab;
    }
}