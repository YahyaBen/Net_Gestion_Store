namespace GestionStore
{
    partial class Commandes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Categorie = new System.Windows.Forms.TextBox();
            this.Btn_Client = new System.Windows.Forms.Button();
            this.CmBox_Client = new System.Windows.Forms.ComboBox();
            this.CmBox_Produit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Produit = new System.Windows.Forms.Button();
            this.Txt_Qte = new System.Windows.Forms.TextBox();
            this.Txt_Montant = new System.Windows.Forms.TextBox();
            this.Txt_Facture = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimePiker = new System.Windows.Forms.DateTimePicker();
            this.RdButton_Banque = new System.Windows.Forms.RadioButton();
            this.RdButton_Cash = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Stock = new System.Windows.Forms.TextBox();
            this.Btn_Actualiser_1 = new System.Windows.Forms.Button();
            this.Btn_Actualiser_2 = new System.Windows.Forms.Button();
            this.Btn_Cmd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Produit = new System.Windows.Forms.TextBox();
            this.labbol = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Prenom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Cmd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero du Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero du produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montant en $ :";
            // 
            // Txt_Categorie
            // 
            this.Txt_Categorie.Enabled = false;
            this.Txt_Categorie.Location = new System.Drawing.Point(145, 48);
            this.Txt_Categorie.Name = "Txt_Categorie";
            this.Txt_Categorie.Size = new System.Drawing.Size(121, 20);
            this.Txt_Categorie.TabIndex = 7;
            // 
            // Btn_Client
            // 
            this.Btn_Client.Location = new System.Drawing.Point(158, 34);
            this.Btn_Client.Name = "Btn_Client";
            this.Btn_Client.Size = new System.Drawing.Size(118, 23);
            this.Btn_Client.TabIndex = 8;
            this.Btn_Client.Text = "Nouveau Client";
            this.Btn_Client.UseVisualStyleBackColor = true;
            this.Btn_Client.Click += new System.EventHandler(this.Btn_Client_Click);
            // 
            // CmBox_Client
            // 
            this.CmBox_Client.FormattingEnabled = true;
            this.CmBox_Client.Location = new System.Drawing.Point(155, 7);
            this.CmBox_Client.Name = "CmBox_Client";
            this.CmBox_Client.Size = new System.Drawing.Size(121, 21);
            this.CmBox_Client.TabIndex = 10;
            this.CmBox_Client.SelectedIndexChanged += new System.EventHandler(this.CmBox_Client_SelectedIndexChanged);
            // 
            // CmBox_Produit
            // 
            this.CmBox_Produit.FormattingEnabled = true;
            this.CmBox_Produit.Location = new System.Drawing.Point(155, 146);
            this.CmBox_Produit.Name = "CmBox_Produit";
            this.CmBox_Produit.Size = new System.Drawing.Size(121, 21);
            this.CmBox_Produit.TabIndex = 11;
            this.CmBox_Produit.SelectedIndexChanged += new System.EventHandler(this.CmBox_Produit_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Categories :";
            // 
            // Btn_Produit
            // 
            this.Btn_Produit.Location = new System.Drawing.Point(155, 173);
            this.Btn_Produit.Name = "Btn_Produit";
            this.Btn_Produit.Size = new System.Drawing.Size(121, 23);
            this.Btn_Produit.TabIndex = 13;
            this.Btn_Produit.Text = "Nouveau Produit";
            this.Btn_Produit.UseVisualStyleBackColor = true;
            this.Btn_Produit.Click += new System.EventHandler(this.Btn_Produit_Click);
            // 
            // Txt_Qte
            // 
            this.Txt_Qte.Location = new System.Drawing.Point(155, 202);
            this.Txt_Qte.Name = "Txt_Qte";
            this.Txt_Qte.Size = new System.Drawing.Size(121, 20);
            this.Txt_Qte.TabIndex = 14;
            this.Txt_Qte.TextChanged += new System.EventHandler(this.Txt_Qte_TextChanged);
            this.Txt_Qte.Leave += new System.EventHandler(this.Txt_Qte_Leave);
            // 
            // Txt_Montant
            // 
            this.Txt_Montant.Enabled = false;
            this.Txt_Montant.Location = new System.Drawing.Point(145, 100);
            this.Txt_Montant.Name = "Txt_Montant";
            this.Txt_Montant.Size = new System.Drawing.Size(121, 20);
            this.Txt_Montant.TabIndex = 15;
            // 
            // Txt_Facture
            // 
            this.Txt_Facture.Enabled = false;
            this.Txt_Facture.Location = new System.Drawing.Point(90, 30);
            this.Txt_Facture.Name = "Txt_Facture";
            this.Txt_Facture.Size = new System.Drawing.Size(178, 20);
            this.Txt_Facture.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimePiker);
            this.groupBox1.Controls.Add(this.RdButton_Banque);
            this.groupBox1.Controls.Add(this.RdButton_Cash);
            this.groupBox1.Controls.Add(this.Txt_Facture);
            this.groupBox1.Location = new System.Drawing.Point(24, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 130);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paiments :";
            // 
            // TimePiker
            // 
            this.TimePiker.Location = new System.Drawing.Point(33, 83);
            this.TimePiker.Name = "TimePiker";
            this.TimePiker.Size = new System.Drawing.Size(285, 20);
            this.TimePiker.TabIndex = 21;
            // 
            // RdButton_Banque
            // 
            this.RdButton_Banque.AutoSize = true;
            this.RdButton_Banque.Location = new System.Drawing.Point(19, 60);
            this.RdButton_Banque.Name = "RdButton_Banque";
            this.RdButton_Banque.Size = new System.Drawing.Size(133, 17);
            this.RdButton_Banque.TabIndex = 18;
            this.RdButton_Banque.TabStop = true;
            this.RdButton_Banque.Text = "prélèvement bancaire :";
            this.RdButton_Banque.UseVisualStyleBackColor = true;
            // 
            // RdButton_Cash
            // 
            this.RdButton_Cash.AutoSize = true;
            this.RdButton_Cash.Checked = true;
            this.RdButton_Cash.Location = new System.Drawing.Point(19, 31);
            this.RdButton_Cash.Name = "RdButton_Cash";
            this.RdButton_Cash.Size = new System.Drawing.Size(49, 17);
            this.RdButton_Cash.TabIndex = 9;
            this.RdButton_Cash.TabStop = true;
            this.RdButton_Cash.Text = "Cash";
            this.RdButton_Cash.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Stock Diponible :";
            // 
            // Txt_Stock
            // 
            this.Txt_Stock.Enabled = false;
            this.Txt_Stock.Location = new System.Drawing.Point(145, 74);
            this.Txt_Stock.Name = "Txt_Stock";
            this.Txt_Stock.Size = new System.Drawing.Size(121, 20);
            this.Txt_Stock.TabIndex = 20;
            // 
            // Btn_Actualiser_1
            // 
            this.Btn_Actualiser_1.Location = new System.Drawing.Point(279, 5);
            this.Btn_Actualiser_1.Name = "Btn_Actualiser_1";
            this.Btn_Actualiser_1.Size = new System.Drawing.Size(22, 23);
            this.Btn_Actualiser_1.TabIndex = 21;
            this.Btn_Actualiser_1.Text = "🗘";
            this.Btn_Actualiser_1.UseVisualStyleBackColor = true;
            this.Btn_Actualiser_1.Click += new System.EventHandler(this.Btn_Actualiser_1_Click);
            // 
            // Btn_Actualiser_2
            // 
            this.Btn_Actualiser_2.Location = new System.Drawing.Point(279, 146);
            this.Btn_Actualiser_2.Name = "Btn_Actualiser_2";
            this.Btn_Actualiser_2.Size = new System.Drawing.Size(22, 23);
            this.Btn_Actualiser_2.TabIndex = 22;
            this.Btn_Actualiser_2.Text = "🗘";
            this.Btn_Actualiser_2.UseVisualStyleBackColor = true;
            this.Btn_Actualiser_2.Click += new System.EventHandler(this.Btn_Actualiser_2_Click);
            // 
            // Btn_Cmd
            // 
            this.Btn_Cmd.Location = new System.Drawing.Point(136, 524);
            this.Btn_Cmd.Name = "Btn_Cmd";
            this.Btn_Cmd.Size = new System.Drawing.Size(130, 48);
            this.Btn_Cmd.TabIndex = 23;
            this.Btn_Cmd.Text = "Commandez";
            this.Btn_Cmd.UseVisualStyleBackColor = true;
            this.Btn_Cmd.Click += new System.EventHandler(this.Btn_Cmd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Produit);
            this.groupBox2.Controls.Add(this.labbol);
            this.groupBox2.Controls.Add(this.Txt_Categorie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_Stock);
            this.groupBox2.Controls.Add(this.Txt_Montant);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(24, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 143);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos Commande :";
            // 
            // Txt_Produit
            // 
            this.Txt_Produit.Enabled = false;
            this.Txt_Produit.Location = new System.Drawing.Point(145, 19);
            this.Txt_Produit.Name = "Txt_Produit";
            this.Txt_Produit.Size = new System.Drawing.Size(121, 20);
            this.Txt_Produit.TabIndex = 21;
            // 
            // labbol
            // 
            this.labbol.AutoSize = true;
            this.labbol.Location = new System.Drawing.Point(18, 26);
            this.labbol.Name = "labbol";
            this.labbol.Size = new System.Drawing.Size(46, 13);
            this.labbol.TabIndex = 22;
            this.labbol.Text = "Produit :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_Nom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Txt_Prenom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(24, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 82);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infos Client :";
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Enabled = false;
            this.Txt_Nom.Location = new System.Drawing.Point(145, 19);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(121, 20);
            this.Txt_Nom.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nom  :";
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.Enabled = false;
            this.Txt_Prenom.Location = new System.Drawing.Point(145, 45);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(121, 20);
            this.Txt_Prenom.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Penom :";
            // 
            // Txt_Cmd
            // 
            this.Txt_Cmd.Enabled = false;
            this.Txt_Cmd.Location = new System.Drawing.Point(352, 7);
            this.Txt_Cmd.Name = "Txt_Cmd";
            this.Txt_Cmd.Size = new System.Drawing.Size(55, 20);
            this.Txt_Cmd.TabIndex = 23;
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 584);
            this.Controls.Add(this.Txt_Cmd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Cmd);
            this.Controls.Add(this.Btn_Actualiser_2);
            this.Controls.Add(this.Btn_Actualiser_1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_Qte);
            this.Controls.Add(this.Btn_Produit);
            this.Controls.Add(this.CmBox_Produit);
            this.Controls.Add(this.CmBox_Client);
            this.Controls.Add(this.Btn_Client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Categorie;
        private System.Windows.Forms.Button Btn_Client;
        private System.Windows.Forms.ComboBox CmBox_Client;
        private System.Windows.Forms.ComboBox CmBox_Produit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Produit;
        private System.Windows.Forms.TextBox Txt_Qte;
        private System.Windows.Forms.TextBox Txt_Montant;
        private System.Windows.Forms.TextBox Txt_Facture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdButton_Cash;
        private System.Windows.Forms.RadioButton RdButton_Banque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Stock;
        private System.Windows.Forms.DateTimePicker TimePiker;
        private System.Windows.Forms.Button Btn_Actualiser_1;
        private System.Windows.Forms.Button Btn_Actualiser_2;
        private System.Windows.Forms.Button Btn_Cmd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Prenom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Produit;
        private System.Windows.Forms.Label labbol;
        private System.Windows.Forms.TextBox Txt_Cmd;
    }
}