namespace GestionStore
{
    partial class Categories
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
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Text_Libelle = new System.Windows.Forms.TextBox();
            this.Text_Recherche = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Supp = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Label_id_GestionStore = new System.Windows.Forms.Label();
            this.Label_Lib_GestionStore = new System.Windows.Forms.Label();
            this.Label_Produit = new System.Windows.Forms.Label();
            this.NBR_Produit_Label = new System.Windows.Forms.Label();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.Button_RechCat = new System.Windows.Forms.Button();
            this.Lib_Recherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_ID
            // 
            this.Text_ID.Location = new System.Drawing.Point(131, 33);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(178, 20);
            this.Text_ID.TabIndex = 0;
            // 
            // Text_Libelle
            // 
            this.Text_Libelle.Location = new System.Drawing.Point(131, 82);
            this.Text_Libelle.Name = "Text_Libelle";
            this.Text_Libelle.Size = new System.Drawing.Size(178, 20);
            this.Text_Libelle.TabIndex = 1;
            // 
            // Text_Recherche
            // 
            this.Text_Recherche.Location = new System.Drawing.Point(58, 126);
            this.Text_Recherche.Name = "Text_Recherche";
            this.Text_Recherche.Size = new System.Drawing.Size(251, 20);
            this.Text_Recherche.TabIndex = 2;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(382, 30);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "Ajouter";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Supp
            // 
            this.Button_Supp.Location = new System.Drawing.Point(382, 90);
            this.Button_Supp.Name = "Button_Supp";
            this.Button_Supp.Size = new System.Drawing.Size(75, 23);
            this.Button_Supp.TabIndex = 5;
            this.Button_Supp.Text = "Supprimer";
            this.Button_Supp.UseVisualStyleBackColor = true;
            this.Button_Supp.Click += new System.EventHandler(this.Button_Supp_Click);
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(36, 194);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(415, 176);
            this.DGV.TabIndex = 7;
            // 
            // Label_id_GestionStore
            // 
            this.Label_id_GestionStore.AutoSize = true;
            this.Label_id_GestionStore.Location = new System.Drawing.Point(33, 39);
            this.Label_id_GestionStore.Name = "Label_id_GestionStore";
            this.Label_id_GestionStore.Size = new System.Drawing.Size(24, 13);
            this.Label_id_GestionStore.TabIndex = 8;
            this.Label_id_GestionStore.Text = "ID :";
            // 
            // Label_Lib_GestionStore
            // 
            this.Label_Lib_GestionStore.AutoSize = true;
            this.Label_Lib_GestionStore.Location = new System.Drawing.Point(33, 90);
            this.Label_Lib_GestionStore.Name = "Label_Lib_GestionStore";
            this.Label_Lib_GestionStore.Size = new System.Drawing.Size(43, 13);
            this.Label_Lib_GestionStore.TabIndex = 9;
            this.Label_Lib_GestionStore.Text = "Libelle :";
            // 
            // Label_Produit
            // 
            this.Label_Produit.AutoSize = true;
            this.Label_Produit.Location = new System.Drawing.Point(89, 391);
            this.Label_Produit.Name = "Label_Produit";
            this.Label_Produit.Size = new System.Drawing.Size(116, 13);
            this.Label_Produit.TabIndex = 12;
            this.Label_Produit.Text = "Nombres des Produits :";
            // 
            // NBR_Produit_Label
            // 
            this.NBR_Produit_Label.AutoSize = true;
            this.NBR_Produit_Label.Location = new System.Drawing.Point(211, 391);
            this.NBR_Produit_Label.Name = "NBR_Produit_Label";
            this.NBR_Produit_Label.Size = new System.Drawing.Size(16, 13);
            this.NBR_Produit_Label.TabIndex = 13;
            this.NBR_Produit_Label.Text = "...";
            // 
            // Button_Modifier
            // 
            this.Button_Modifier.Location = new System.Drawing.Point(382, 59);
            this.Button_Modifier.Name = "Button_Modifier";
            this.Button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Modifier.TabIndex = 14;
            this.Button_Modifier.Text = "Modifier";
            this.Button_Modifier.UseVisualStyleBackColor = true;
            this.Button_Modifier.Click += new System.EventHandler(this.Button_Modifier_Click);
            // 
            // Button_RechCat
            // 
            this.Button_RechCat.Location = new System.Drawing.Point(333, 126);
            this.Button_RechCat.Name = "Button_RechCat";
            this.Button_RechCat.Size = new System.Drawing.Size(124, 23);
            this.Button_RechCat.TabIndex = 15;
            this.Button_RechCat.Text = "Recherche Categorie";
            this.Button_RechCat.UseVisualStyleBackColor = true;
            this.Button_RechCat.Click += new System.EventHandler(this.Button_RechCat_Click);
            // 
            // Lib_Recherche
            // 
            this.Lib_Recherche.AutoSize = true;
            this.Lib_Recherche.Location = new System.Drawing.Point(55, 164);
            this.Lib_Recherche.Name = "Lib_Recherche";
            this.Lib_Recherche.Size = new System.Drawing.Size(0, 13);
            this.Lib_Recherche.TabIndex = 16;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(481, 428);
            this.Controls.Add(this.Lib_Recherche);
            this.Controls.Add(this.Button_RechCat);
            this.Controls.Add(this.Button_Modifier);
            this.Controls.Add(this.NBR_Produit_Label);
            this.Controls.Add(this.Label_Produit);
            this.Controls.Add(this.Label_Lib_GestionStore);
            this.Controls.Add(this.Label_id_GestionStore);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Button_Supp);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Text_Recherche);
            this.Controls.Add(this.Text_Libelle);
            this.Controls.Add(this.Text_ID);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Text_Libelle;
        private System.Windows.Forms.TextBox Text_Recherche;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Supp;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label Label_id_GestionStore;
        private System.Windows.Forms.Label Label_Lib_GestionStore;
        private System.Windows.Forms.Label Label_Produit;
        private System.Windows.Forms.Label NBR_Produit_Label;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button Button_RechCat;
        private System.Windows.Forms.Label Lib_Recherche;
    }
}

