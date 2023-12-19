
namespace oruzh
{
    partial class List
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.fio = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductPanelList = new System.Windows.Forms.Panel();
            this.DoneBut = new System.Windows.Forms.Button();
            this.fioClient = new System.Windows.Forms.TextBox();
            this.phoneClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(778, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(183, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Накладная";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Location = new System.Drawing.Point(588, 22);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(200, 416);
            this.NavigationPanel.TabIndex = 13;
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(12, 70);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(70, 29);
            this.fio.TabIndex = 14;
            this.fio.Text = "ФИО";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(12, 112);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(119, 29);
            this.phone.TabIndex = 15;
            this.phone.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Товары:";
            // 
            // ProductPanelList
            // 
            this.ProductPanelList.AutoScroll = true;
            this.ProductPanelList.Location = new System.Drawing.Point(17, 190);
            this.ProductPanelList.Name = "ProductPanelList";
            this.ProductPanelList.Size = new System.Drawing.Size(565, 187);
            this.ProductPanelList.TabIndex = 17;
            // 
            // DoneBut
            // 
            this.DoneBut.Location = new System.Drawing.Point(362, 384);
            this.DoneBut.Name = "DoneBut";
            this.DoneBut.Size = new System.Drawing.Size(197, 54);
            this.DoneBut.TabIndex = 18;
            this.DoneBut.Text = "Закрыть чек";
            this.DoneBut.UseVisualStyleBackColor = true;
            this.DoneBut.Click += new System.EventHandler(this.DoneBut_Click);
            // 
            // fioClient
            // 
            this.fioClient.Location = new System.Drawing.Point(145, 73);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(437, 26);
            this.fioClient.TabIndex = 19;
            // 
            // phoneClient
            // 
            this.phoneClient.Location = new System.Drawing.Point(145, 112);
            this.phoneClient.Name = "phoneClient";
            this.phoneClient.Size = new System.Drawing.Size(437, 26);
            this.phoneClient.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "ИТОГО:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(144, 391);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(48, 25);
            this.cost.TabIndex = 22;
            this.cost.Text = "cost";
            this.cost.Click += new System.EventHandler(this.cost_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneClient);
            this.Controls.Add(this.fioClient);
            this.Controls.Add(this.DoneBut);
            this.Controls.Add(this.ProductPanelList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ProductPanelList;
        private System.Windows.Forms.Button DoneBut;
        private System.Windows.Forms.TextBox fioClient;
        private System.Windows.Forms.TextBox phoneClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cost;
    }
}