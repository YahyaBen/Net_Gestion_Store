namespace GestionStore
{
    partial class MDIstore
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Commandez = new System.Windows.Forms.Button();
            this.TS_Marchandises = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Produits = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Clients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Commandez
            // 
            this.Commandez.Location = new System.Drawing.Point(217, 145);
            this.Commandez.Name = "Commandez";
            this.Commandez.Size = new System.Drawing.Size(176, 98);
            this.Commandez.TabIndex = 7;
            this.Commandez.Text = "Commandez !";
            this.Commandez.UseVisualStyleBackColor = true;
            this.Commandez.Click += new System.EventHandler(this.Commandez_Click);
            // 
            // TS_Marchandises
            // 
            this.TS_Marchandises.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Categories,
            this.TS_Produits});
            this.TS_Marchandises.Name = "TS_Marchandises";
            this.TS_Marchandises.Size = new System.Drawing.Size(92, 20);
            this.TS_Marchandises.Text = "Marchandises";
            // 
            // TS_Categories
            // 
            this.TS_Categories.Name = "TS_Categories";
            this.TS_Categories.Size = new System.Drawing.Size(130, 22);
            this.TS_Categories.Text = "Categories";
            this.TS_Categories.Click += new System.EventHandler(this.TS_Categories_Click);
            // 
            // TS_Produits
            // 
            this.TS_Produits.Name = "TS_Produits";
            this.TS_Produits.Size = new System.Drawing.Size(130, 22);
            this.TS_Produits.Text = "Produits";
            this.TS_Produits.Click += new System.EventHandler(this.TS_Produits_Click);
            // 
            // TS_Clients
            // 
            this.TS_Clients.Name = "TS_Clients";
            this.TS_Clients.Size = new System.Drawing.Size(55, 20);
            this.TS_Clients.Text = "Clients";
            this.TS_Clients.Click += new System.EventHandler(this.TS_Clients_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Marchandises,
            this.TS_Clients});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MDIstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.Commandez);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIstore";
            this.Text = "MDIstore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Commandez;
        private System.Windows.Forms.ToolStripMenuItem TS_Marchandises;
        private System.Windows.Forms.ToolStripMenuItem TS_Categories;
        private System.Windows.Forms.ToolStripMenuItem TS_Produits;
        private System.Windows.Forms.ToolStripMenuItem TS_Clients;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}



