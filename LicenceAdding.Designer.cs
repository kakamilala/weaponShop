
namespace oruzh
{
    partial class LicenceAdding
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
            this.id_licence = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLicence = new System.Windows.Forms.TextBox();
            this.typelic = new System.Windows.Forms.TextBox();
            this.period = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_licence
            // 
            this.id_licence.AutoSize = true;
            this.id_licence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_licence.Location = new System.Drawing.Point(12, 9);
            this.id_licence.Name = "id_licence";
            this.id_licence.Size = new System.Drawing.Size(195, 37);
            this.id_licence.TabIndex = 0;
            this.id_licence.Text = "ID лицензии";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(15, 67);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(64, 32);
            this.type.TabIndex = 1;
            this.type.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок действия";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idLicence
            // 
            this.idLicence.Location = new System.Drawing.Point(227, 19);
            this.idLicence.Name = "idLicence";
            this.idLicence.Size = new System.Drawing.Size(348, 26);
            this.idLicence.TabIndex = 3;
            // 
            // typelic
            // 
            this.typelic.Location = new System.Drawing.Point(227, 73);
            this.typelic.Name = "typelic";
            this.typelic.Size = new System.Drawing.Size(348, 26);
            this.typelic.TabIndex = 4;
            this.typelic.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(227, 129);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(348, 26);
            this.period.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(581, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveBut
            // 
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.Location = new System.Drawing.Point(205, 207);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(176, 46);
            this.saveBut.TabIndex = 12;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // LicenceAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.period);
            this.Controls.Add(this.typelic);
            this.Controls.Add(this.idLicence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.id_licence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicenceAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicenceAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_licence;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idLicence;
        private System.Windows.Forms.TextBox typelic;
        private System.Windows.Forms.TextBox period;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBut;
    }
}