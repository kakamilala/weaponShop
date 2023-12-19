
namespace oruzh
{
    partial class ClosedListDescription
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
            this.clientLab = new System.Windows.Forms.Label();
            this.costLab = new System.Windows.Forms.Label();
            this.dateLab = new System.Windows.Forms.Label();
            this.close_but = new System.Windows.Forms.Label();
            this.productsLab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clientLab
            // 
            this.clientLab.AutoSize = true;
            this.clientLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLab.Location = new System.Drawing.Point(12, 60);
            this.clientLab.Name = "clientLab";
            this.clientLab.Size = new System.Drawing.Size(70, 29);
            this.clientLab.TabIndex = 13;
            this.clientLab.Text = "client";
            // 
            // costLab
            // 
            this.costLab.AutoSize = true;
            this.costLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLab.Location = new System.Drawing.Point(14, 102);
            this.costLab.Name = "costLab";
            this.costLab.Size = new System.Drawing.Size(57, 29);
            this.costLab.TabIndex = 12;
            this.costLab.Text = "cost";
            // 
            // dateLab
            // 
            this.dateLab.AutoSize = true;
            this.dateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLab.Location = new System.Drawing.Point(10, 9);
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(91, 40);
            this.dateLab.TabIndex = 11;
            this.dateLab.Text = "date";
            // 
            // close_but
            // 
            this.close_but.AutoSize = true;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_but.Location = new System.Drawing.Point(581, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(22, 25);
            this.close_but.TabIndex = 15;
            this.close_but.Text = "x";
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // productsLab
            // 
            this.productsLab.BackColor = System.Drawing.SystemColors.Info;
            this.productsLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsLab.Location = new System.Drawing.Point(17, 134);
            this.productsLab.Multiline = true;
            this.productsLab.Name = "productsLab";
            this.productsLab.ReadOnly = true;
            this.productsLab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productsLab.Size = new System.Drawing.Size(571, 154);
            this.productsLab.TabIndex = 16;
            this.productsLab.TabStop = false;
            // 
            // ClosedListDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.productsLab);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.clientLab);
            this.Controls.Add(this.costLab);
            this.Controls.Add(this.dateLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClosedListDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClosedListDescription";
            this.Load += new System.EventHandler(this.ClosedListDescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clientLab;
        private System.Windows.Forms.Label costLab;
        private System.Windows.Forms.Label dateLab;
        private System.Windows.Forms.Label close_but;
        private System.Windows.Forms.TextBox productsLab;
    }
}