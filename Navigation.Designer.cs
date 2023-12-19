
namespace oruzh
{
    partial class Navigation
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CatalogBut = new System.Windows.Forms.Button();
            this.ListBut = new System.Windows.Forms.Button();
            this.ClosedListsBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatalogBut
            // 
            this.CatalogBut.Location = new System.Drawing.Point(3, 73);
            this.CatalogBut.Name = "CatalogBut";
            this.CatalogBut.Size = new System.Drawing.Size(194, 64);
            this.CatalogBut.TabIndex = 0;
            this.CatalogBut.Text = "Каталог";
            this.CatalogBut.UseVisualStyleBackColor = true;
            this.CatalogBut.Click += new System.EventHandler(this.CatalogBut_Click);
            // 
            // ListBut
            // 
            this.ListBut.Location = new System.Drawing.Point(3, 3);
            this.ListBut.Name = "ListBut";
            this.ListBut.Size = new System.Drawing.Size(194, 64);
            this.ListBut.TabIndex = 1;
            this.ListBut.Text = "Накладная";
            this.ListBut.UseVisualStyleBackColor = true;
            this.ListBut.Click += new System.EventHandler(this.ListBut_Click);
            // 
            // ClosedListsBut
            // 
            this.ClosedListsBut.Location = new System.Drawing.Point(3, 143);
            this.ClosedListsBut.Name = "ClosedListsBut";
            this.ClosedListsBut.Size = new System.Drawing.Size(194, 64);
            this.ClosedListsBut.TabIndex = 2;
            this.ClosedListsBut.Text = "Накладные";
            this.ClosedListsBut.UseVisualStyleBackColor = true;
            this.ClosedListsBut.Click += new System.EventHandler(this.ClosedLists_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ClosedListsBut);
            this.Controls.Add(this.ListBut);
            this.Controls.Add(this.CatalogBut);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(200, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatalogBut;
        private System.Windows.Forms.Button ListBut;
        private System.Windows.Forms.Button ClosedListsBut;
    }
}
