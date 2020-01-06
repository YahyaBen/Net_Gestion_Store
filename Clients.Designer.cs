namespace GestionStore
{
    partial class Clients
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
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Text_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Recherche = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Supp = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.Button_Recherche = new System.Windows.Forms.Button();
            this.Lab_Infos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Button_Commentaire = new System.Windows.Forms.Button();
            this.Lab_NbrClients = new System.Windows.Forms.Label();
            this.Rich_Text_Com = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // Text_ID
            // 
            this.Text_ID.Enabled = false;
            this.Text_ID.Location = new System.Drawing.Point(117, 29);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(192, 20);
            this.Text_ID.TabIndex = 1;
            // 
            // Text_Nom
            // 
            this.Text_Nom.Location = new System.Drawing.Point(117, 71);
            this.Text_Nom.Name = "Text_Nom";
            this.Text_Nom.Size = new System.Drawing.Size(192, 20);
            this.Text_Nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom : ";
            // 
            // Text_Prenom
            // 
            this.Text_Prenom.Location = new System.Drawing.Point(117, 116);
            this.Text_Prenom.Name = "Text_Prenom";
            this.Text_Prenom.Size = new System.Drawing.Size(192, 20);
            this.Text_Prenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom :";
            // 
            // Text_Recherche
            // 
            this.Text_Recherche.Location = new System.Drawing.Point(489, 26);
            this.Text_Recherche.Name = "Text_Recherche";
            this.Text_Recherche.Size = new System.Drawing.Size(192, 20);
            this.Text_Recherche.TabIndex = 7;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(330, 26);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 8;
            this.Button_Add.Text = "Ajouter";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Supp
            // 
            this.Button_Supp.Location = new System.Drawing.Point(330, 113);
            this.Button_Supp.Name = "Button_Supp";
            this.Button_Supp.Size = new System.Drawing.Size(75, 23);
            this.Button_Supp.TabIndex = 9;
            this.Button_Supp.Text = "Supprimer";
            this.Button_Supp.UseVisualStyleBackColor = true;
            this.Button_Supp.Click += new System.EventHandler(this.Button_Supp_Click);
            // 
            // Button_Modifier
            // 
            this.Button_Modifier.Location = new System.Drawing.Point(330, 68);
            this.Button_Modifier.Name = "Button_Modifier";
            this.Button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Modifier.TabIndex = 9;
            this.Button_Modifier.Text = "Modifier";
            this.Button_Modifier.UseVisualStyleBackColor = true;
            this.Button_Modifier.Click += new System.EventHandler(this.Button_Modifier_Click_1);
            // 
            // Button_Recherche
            // 
            this.Button_Recherche.Location = new System.Drawing.Point(701, 26);
            this.Button_Recherche.Name = "Button_Recherche";
            this.Button_Recherche.Size = new System.Drawing.Size(149, 23);
            this.Button_Recherche.TabIndex = 10;
            this.Button_Recherche.Text = "Recherche Client";
            this.Button_Recherche.UseVisualStyleBackColor = true;
            this.Button_Recherche.Click += new System.EventHandler(this.Button_Recherche_Click);
            // 
            // Lab_Infos
            // 
            this.Lab_Infos.AutoSize = true;
            this.Lab_Infos.Location = new System.Drawing.Point(494, 61);
            this.Lab_Infos.Name = "Lab_Infos";
            this.Lab_Infos.Size = new System.Drawing.Size(16, 13);
            this.Lab_Infos.TabIndex = 11;
            this.Lab_Infos.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre des clients : ";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(44, 151);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(361, 150);
            this.DGV.TabIndex = 14;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Button_Commentaire
            // 
            this.Button_Commentaire.Location = new System.Drawing.Point(489, 183);
            this.Button_Commentaire.Name = "Button_Commentaire";
            this.Button_Commentaire.Size = new System.Drawing.Size(361, 23);
            this.Button_Commentaire.TabIndex = 16;
            this.Button_Commentaire.Text = "Ajout Commentaire";
            this.Button_Commentaire.UseVisualStyleBackColor = true;
            this.Button_Commentaire.Click += new System.EventHandler(this.Button_Commentaire_Click);
            // 
            // Lab_NbrClients
            // 
            this.Lab_NbrClients.AutoSize = true;
            this.Lab_NbrClients.Location = new System.Drawing.Point(438, 320);
            this.Lab_NbrClients.Name = "Lab_NbrClients";
            this.Lab_NbrClients.Size = new System.Drawing.Size(16, 13);
            this.Lab_NbrClients.TabIndex = 17;
            this.Lab_NbrClients.Text = "...";
            // 
            // Rich_Text_Com
            // 
            this.Rich_Text_Com.Location = new System.Drawing.Point(489, 108);
            this.Rich_Text_Com.Name = "Rich_Text_Com";
            this.Rich_Text_Com.Size = new System.Drawing.Size(361, 69);
            this.Rich_Text_Com.TabIndex = 18;
            this.Rich_Text_Com.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Remarques sur le client :";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rich_Text_Com);
            this.Controls.Add(this.Lab_NbrClients);
            this.Controls.Add(this.Button_Commentaire);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lab_Infos);
            this.Controls.Add(this.Button_Recherche);
            this.Controls.Add(this.Button_Modifier);
            this.Controls.Add(this.Button_Supp);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Text_Recherche);
            this.Controls.Add(this.Text_Prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Text_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Recherche;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Supp;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button Button_Recherche;
        private System.Windows.Forms.Label Lab_Infos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button Button_Commentaire;
        private System.Windows.Forms.Label Lab_NbrClients;
        private System.Windows.Forms.RichTextBox Rich_Text_Com;
        private System.Windows.Forms.Label label4;
    }
}