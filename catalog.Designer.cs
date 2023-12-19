
namespace oruzh
{
    partial class Catalog
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
            this.search = new System.Windows.Forms.TextBox();
            this.search_but = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.close_but = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(12, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(447, 37);
            this.search.TabIndex = 0;
            // 
            // search_but
            // 
            this.search_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_but.Location = new System.Drawing.Point(465, 22);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(116, 52);
            this.search_but.TabIndex = 1;
            this.search_but.Text = "Найти";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.Search_but_Click);
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Location = new System.Drawing.Point(12, 84);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(569, 354);
            this.productsPanel.TabIndex = 2;
            // 
            // close_but
            // 
            this.close_but.AutoSize = true;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_but.Location = new System.Drawing.Point(778, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(22, 25);
            this.close_but.TabIndex = 3;
            this.close_but.Text = "x";
            this.close_but.Click += new System.EventHandler(this.Сlose_but_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Location = new System.Drawing.Point(586, 22);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(200, 416);
            this.NavigationPanel.TabIndex = 4;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORUZH";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Label close_but;
        private System.Windows.Forms.Panel NavigationPanel;
    }
}