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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        // Objet de connexion pour appliquer tout nos requetes et nos connexions
        Sql_Raccourcis Raccourcis = new Sql_Raccourcis();
        private void Categories_Load(object sender, EventArgs e)
        {
            Raccourcis.CONNECTER(); // Connection lors du chargement de l'interface
            DGV_Load();
            if (Nbrcategory() != 0) Text_ID.Text = IDcount().ToString();
            Text_ID.Enabled = false; // On peux l'appliquer aussi sur designe
            /* Le Test Nombre Categorie est OBLIGER Sinon "Specific cast is not possible" 
             * tout les query saisie sont pas applique vue que le tableau est vide !*/
        }
        public void DGV_Load() // Chargement du DGV
        {
            if (Raccourcis.DT.Rows != null)
            {
                Raccourcis.DT.Clear();
            }
            Raccourcis.Comm.CommandText = "Select * from categories";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            Raccourcis.DT.Load(Raccourcis.Rd);
            DGV.DataSource = Raccourcis.DT;
            Raccourcis.Rd.Close();
            if (Nbrcategory() != 0) Text_ID.Text = IDcount().ToString();
            NBR_Produit_Label.Text = Nbrcategory().ToString();
        }
        public static bool IsNumeric(string s)  // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        public int IDcount() // Fonction pour affiche le dernier ID enregistrer
        {
            int A;
            Raccourcis.Comm.CommandText = "Select MAX(ID) from categories where libelle IS NOT NULL";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            A = (int)Raccourcis.Comm.ExecuteScalar();
            return A;
        }
        public int Nbrcategory() // Fonction qui retourne le Nbr des categories
        {
            Raccourcis.Comm.CommandText = "Select count(ID) from categories";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return (int)Raccourcis.Comm.ExecuteScalar();
        }

        private void Button_Add_Click(object sender, EventArgs e) // Button Ajouter 
        {
            if (Text_Libelle.Text == "")
            {
                MessageBox.Show("Merci de Remplir 'Libelle' !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Raccourcis.Comm.CommandText = "insert into categories values('" + Text_Libelle.Text + "')";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Comm.ExecuteNonQuery();
            DGV_Load();// Mise a jour de l'affichage DGV
        }
        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentCell.Value is int)// Verifier que la cellule choisie du DGv et bien ID = int
            {
                if (MessageBox.Show("Etes-vous sur de le Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Raccourcis.Comm.CommandText = "update categories set libelle='" + Text_Libelle.Text + "' where id ='" + DGV.CurrentCell.Value.ToString() + "'";
                    Raccourcis.Comm.Connection = Raccourcis.Connex;
                    Raccourcis.Comm.ExecuteNonQuery();
                    DGV_Load();// Mise a jour de l'affichage DGV
                }
            }
            else MessageBox.Show("Merci choisir la Cellule 'ID' a Modifier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Button_Supp_Click(object sender, EventArgs e)
        {
            try
            { // le seul solution sans perturber ma base de donnees, delete cascade a revoir bien sur
                if (DGV.CurrentCell.Value is int)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Raccourcis.Comm.CommandText = "delete from categories where id ='" + DGV.CurrentCell.Value.ToString() + "'";
                        Raccourcis.Comm.Connection = Raccourcis.Connex;
                        Raccourcis.Comm.ExecuteNonQuery();
                        DGV_Load();
                    }
                }
                else MessageBox.Show("Merci choisir la Cellule 'ID' et pas libeller !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Des Commandes sont lier a cette categorie, impossile de supprimer !", "Erreur Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Button_RechCat_Click(object sender, EventArgs e)
        {
            if (IsNumeric(Text_Recherche.Text) == true)
            {
                Raccourcis.Comm.CommandText = "Select * from categories where categories.id='" + Text_Recherche.Text + "';";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
                while (Raccourcis.Rd.Read())
                {
                    Lib_Recherche.Text = " - ID  = " + Raccourcis.Rd[0] + "  ,Corresponds a la categorie : " + Raccourcis.Rd[1];
                }
                Raccourcis.Rd.Close();

            }
            else MessageBox.Show("Merci de Rechercher par ID !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
