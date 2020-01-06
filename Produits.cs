using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStore
{
    public partial class Produits : Form
    {
        public Produits()
        {
            InitializeComponent();
        }
        // Objet de connexion Objet de connexion pour appliquer tout nos requetes et nos connexions
        Sql_Raccourcis Raccourcis = new Sql_Raccourcis();
        private void Produits_Load(object sender, EventArgs e)// Connection lors du chargement de l'interface
        {
            Raccourcis.CONNECTER();
            LB_Load();
            if (NbrProduits() != 0) Txt_ID.Text = IDProduitCount().ToString();
            /* Le Test Nombre produit est OBLIGER Sinon "Specific cast is not possible" 
             * tout les query saisie sont pas applique vue que le tableau est vide !*/
        }

        public void LB_Load() // Chargement du DGV
        {
            if (List_Box.Items.Count != 0)
            {
                List_Box.Items.Clear();
            }
            Raccourcis.Comm.CommandText = "Select * from produits";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read())
            {
                List_Box.Items.Add("ID : " + Raccourcis.Rd[0] + ", Nom produit : " + Raccourcis.Rd[1] + ", prix/unite : " + Raccourcis.Rd[2] + ", Stock disponible : " + Raccourcis.Rd[3] + ", de la Categorie : " + Raccourcis.Rd[4]);
            }
            Raccourcis.Rd.Close();
            if (NbrProduits() != 0) Txt_ID.Text = IDProduitCount().ToString();
            Txt_NbrProduit.Text = NbrProduits().ToString();
            CBload();
        }

        public void CBload()// Chargement du Combos Box Categories
        {
            Raccourcis.Comm.CommandText = "select ID from categories;";// 
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read())
            {
                CmBox_Categorie.Items.Add(Raccourcis.Rd[0]);
            }
            Raccourcis.Rd.Close();
        }
        public static bool IsNumeric(string s) // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        public int NbrProduits() // Fonction pour affiche le dernier ID enregistrer
        {
            Raccourcis.Comm.CommandText = "Select count(ID) from produits";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return (int)Raccourcis.Comm.ExecuteScalar();
        }

        public int IDProduitCount() // Fonction qui retourne le Nbr des Produits
        {
            Raccourcis.Comm.CommandText = "Select MAX(ID) from produits ";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return ((int)Raccourcis.Comm.ExecuteScalar());
        }

        public int CA_produit() // Calcule Chiffre d'affaire d'un produit specifique
        {
            if (Txt_Recherche.Text != "" && IsNumeric(Txt_Recherche.Text) == true)
                Raccourcis.Comm.CommandText = "Select SUM(pu*qte_stock) from produits where id='" + Txt_Recherche.Text + "'";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return (int)Raccourcis.Comm.ExecuteScalar();
        }

        private void Btn_Add_Click(object sender, EventArgs e)// Button Ajouter 
        {
            if (Txt_Libelle.Text == "" || Txt_NbrProduit.Text == "" || Txt_PU.Text == "" || Txt_QtStock.Text == ""
                || IsNumeric(Txt_PU.Text) == false || IsNumeric(Txt_QtStock.Text) == false)
            {
                MessageBox.Show("Merci de Remplir tout les champs avec Type correspendant !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Raccourcis.Comm.CommandText = "insert into produits(libelle,pu,qte_stock,id_categories) values" +
                        "('" + Txt_Libelle.Text + "','"
                        + Txt_PU.Text + "','"
                        + Txt_QtStock.Text + "',@id_categories)";
            // La Cle etrangere ne peut pas etre saisie mais recuperer, d'ou la commande suivante dedier a cette procedure : 
            Raccourcis.Comm.Parameters.AddWithValue("@id_categories", CmBox_Categorie.SelectedItem);
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Comm.ExecuteNonQuery();
            LB_Load();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            if (Txt_Recherche.Text != "" && IsNumeric(Txt_Recherche.Text) == true)
            {
                if (MessageBox.Show("Etes-vous sur de le Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Txt_Libelle.Text == "" || Txt_NbrProduit.Text == "" || Txt_PU.Text == "" || Txt_QtStock.Text == ""
                    || IsNumeric(Txt_PU.Text) == false || IsNumeric(Txt_QtStock.Text) == false)
                    {
                        MessageBox.Show("Merci de Remplir tout les champs avec Type correspendant !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Raccourcis.Comm.CommandText = "update produits set libelle='"
                        + Txt_Libelle.Text + "',pu='"
                        + Txt_PU.Text + "',qte_stock='"
                        + Txt_QtStock.Text + "' where id='"
                        + Txt_Recherche.Text + "'";
                        Raccourcis.Comm.Connection = Raccourcis.Connex;
                        Raccourcis.Comm.ExecuteNonQuery();
                        LB_Load();
                    }
                }
            }
            else MessageBox.Show("Merci remplir la Cellule 'ID' a Modifier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)// Suppression
        {
            try
            {  // le seul solution sans perturber ma base de donnees, delete cascade a revoir bien sur
                if (Txt_Recherche.Text != "" && IsNumeric(Txt_Recherche.Text) == true)
                {
                    if (MessageBox.Show("Etes-vous sur de le supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Raccourcis.Comm.CommandText = "delete from produits where id ='" + Txt_Recherche.Text + "'";
                        Raccourcis.Comm.Connection = Raccourcis.Connex;
                        Raccourcis.Comm.ExecuteNonQuery();
                        LB_Load();
                    }
                }
                else MessageBox.Show("Merci remplir la Cellule 'ID' a supprimer!", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Des Commandes sont lier a ce poduit, impossile de supprimer !", "Erreur Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e) // a cause de list box, c difficile de recuperer les celulles, d'ou l'interet de rajout de cette Button, un DGv sera plus facile a extraire les donnees.
        {
            Txt_CA.Text = CA_produit().ToString() + " $ ";
        }

    }
}
