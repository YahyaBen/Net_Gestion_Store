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
    public partial class Commandes : Form
    {
        public Commandes()
        {
            InitializeComponent();
        }
        // Objet de connexion Objet de connexion pour appliquer tout nos requetes et nos connexions
        Sql_Raccourcis Raccourcis = new Sql_Raccourcis();

        public string DateFacture()
        {
            if (RdButton_Cash.Checked == true) return Txt_Facture.Text;
            else return TimePiker.Value.ToString();
            // Cette fonction nous permet de retourner la date du paiment ou du prelevement banque dans les mois prochaines 
        }
        public static bool IsNumeric(string s) // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        public void Reset_Load() // Recharcger les combos Box et Nbr de commande 
        {
            CBproduit_Load();
            CBclient_Load();
            Txt_Cmd.Text = Nbrcommande().ToString();
        }
        public void CBclient_Load() // Methode Recharger le Combos Box Client
        {
            if (CmBox_Client.Items.Count != 0)
            {
                CmBox_Client.Items.Clear();
            }
            Raccourcis.Comm.CommandText = "select id from clients";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read())
            {
                CmBox_Client.Items.Add(Raccourcis.Rd[0]);
            }
            Raccourcis.Rd.Close();
            Txt_Facture.Text = DateTime.Now.ToString();
        }
        public int Nbrcommande()// Calcule de Nobres des commandes
        {
            Raccourcis.Comm.CommandText = "Select count(ID) from commandes";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return (int)Raccourcis.Comm.ExecuteScalar();
        }
        public void CBproduit_Load() //Methode Recharger le Combos Box Client
        {
            if (CmBox_Produit.Items.Count != 0)
            {
                CmBox_Produit.Items.Clear();
            }
            Raccourcis.Comm.CommandText = "select id from produits";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read())
            {
                CmBox_Produit.Items.Add(Raccourcis.Rd[0]);
            }
            Raccourcis.Rd.Close();
        }
        private void Btn_Client_Click(object sender, EventArgs e)// Renvoi vers interface Client
        {
            Clients A = new Clients();
            A.ShowDialog();
        }
        private void Btn_Produit_Click(object sender, EventArgs e)// Renvoi vers interface Produit
        {
            Produits A = new Produits();
            A.ShowDialog();
        }
        private void Commandes_Load(object sender, EventArgs e) // Connexion et Rechargement de l'interface
        {
            Raccourcis.CONNECTER();
            CBproduit_Load();
            CBclient_Load();
            Txt_Cmd.Text = Nbrcommande().ToString();
        }
        private void Btn_Actualiser_1_Click(object sender, EventArgs e) // Apres Suppression/Ajout/Supp Client On Actualise Combo Box
        {
            CBclient_Load();
        }
        private void Btn_Actualiser_2_Click(object sender, EventArgs e)// Apres Suppression/Ajout/Supp produit On Actualise Combo Box
        {
            CBproduit_Load();
        }
        private void CmBox_Produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Recharge les zones textes et les informations du produits et de categorie apres le choix du produit - Libelle  
            Raccourcis.Comm.CommandText = "select categories.libelle from categories inner join produits  on categories.id=produits.id_categories where produits.id='" + CmBox_Produit.SelectedItem + "';";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read()) Txt_Categorie.Text = Raccourcis.Rd[0].ToString();
            Raccourcis.Rd.Close();

            //Recharge les zones textes et les informations du produits et de categorie apres le choix du produit - Stock
            Raccourcis.Comm.CommandText = "select qte_stock from produits where id='" + CmBox_Produit.SelectedItem + "';";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read()) Txt_Stock.Text = Raccourcis.Rd[0].ToString();
            Raccourcis.Rd.Close();

            //Recharge les zones textes et les informations du produits et de categorie apres le choix du produit - Produit
            Raccourcis.Comm.CommandText = "select libelle from produits where id='" + CmBox_Produit.SelectedItem + "';";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read()) Txt_Produit.Text = Raccourcis.Rd[0].ToString();
            Raccourcis.Rd.Close();
        }
        private void Txt_Qte_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric(Txt_Qte.Text))// Verifier que input et numerique
            {
                //Calcule du montant de la commande
                Raccourcis.Comm.CommandText = "select pu*'" + Txt_Qte.Text + "' from produits where id='" + CmBox_Produit.SelectedItem + "';";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
                while (Raccourcis.Rd.Read()) Txt_Montant.Text = Raccourcis.Rd[0].ToString();
                Raccourcis.Rd.Close();
            }
            else MessageBox.Show("Merci de saisir un entier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void CmBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Recharge les zones textes Client- Nom
            Raccourcis.Comm.CommandText = "select nom from clients where id='" + CmBox_Client.SelectedItem + "';";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read()) Txt_Nom.Text = Raccourcis.Rd[0].ToString();
            Raccourcis.Rd.Close();
            //Recharge les zones textes Client- Prenom
            Raccourcis.Comm.CommandText = "select prenom from clients where id='" + CmBox_Client.SelectedItem + "';";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            while (Raccourcis.Rd.Read()) Txt_Prenom.Text = Raccourcis.Rd[0].ToString();
            Raccourcis.Rd.Close();
        }
        private void Btn_Cmd_Click(object sender, EventArgs e)
        {
            // Remplissage du Tableau Commandes
            if (CmBox_Produit.SelectedIndex.ToString() == "" || CmBox_Client.SelectedIndex.ToString() == "" || Txt_Qte.Text == "" || int.Parse(Txt_Qte.Text) > int.Parse(Txt_Stock.Text))
            {
                MessageBox.Show("Merci de Remplir les donnees principale de la commande !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Raccourcis.Comm.CommandText = "insert into commandes values('"
                + Txt_Produit.Text + "','"
                + DateFacture() + "',@id_client)";
                // Insertion de Cle Etrangere avec la Commande suivantes  
                Raccourcis.Comm.Parameters.AddWithValue("@id_client", CmBox_Client.SelectedItem);
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Tres important, Ou cas ou plusieurs cle primaires sont saisie, faut clear le parameter 
                //avec la commande suivant(sinon la pochaine insertion aura @id_client comme parametre et pas @id_commande

                Raccourcis.Comm.Parameters.Clear();

                // Remplissage du Tableau Lignes Commandes
                Raccourcis.Comm.CommandText = "insert into Ligne_Commande(id_commande,id_poduit) values(@id_commande,@id_poduit);";
                Raccourcis.Comm.Parameters.AddWithValue("@id_commande", Txt_Cmd.Text);
                Raccourcis.Comm.Parameters.AddWithValue("@id_poduit", CmBox_Produit.SelectedItem);
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Nettoyage du parametre
                Raccourcis.Comm.Parameters.Clear();

                // Remplissage du Tableau Paiment
                Raccourcis.Comm.CommandText = "insert into paiments(date_paiment,montant,id_commande) values('"
                + DateFacture() + "','"
                + float.Parse(Txt_Montant.Text) + "',@id_commande);";
                Raccourcis.Comm.Parameters.AddWithValue("@id_commande", Txt_Cmd.Text);
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Nettoyage du parametre
                Raccourcis.Comm.Parameters.Clear();

                // Remplissage du Tableau factures
                Raccourcis.Comm.CommandText = "insert into factues(date_facture,id_commande) values('"
                 + DateFacture() + "',@id_commande);";
                Raccourcis.Comm.Parameters.AddWithValue("@id_commande", Txt_Cmd.Text);
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Nettoyage du parametre
                Raccourcis.Comm.Parameters.Clear();

                // La mise a jour du stock du produit bien sur !
                int A = int.Parse(Txt_Stock.Text);
                int B = int.Parse(Txt_Qte.Text);
                int C = A - B;
                Raccourcis.Comm.CommandText = "update produits set qte_stock='" + C.ToString() + "' where id ='" + CmBox_Produit.SelectedItem + "'";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                MessageBox.Show("Commander enregistre avec succee !", "Operation Effectuer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Nettoyage du parametre
            Raccourcis.Comm.Parameters.Clear();
        }

        private void Txt_Qte_Leave(object sender, EventArgs e)// Changement Couleur du Texte !
        {
            try { 
            if (int.Parse(Txt_Stock.Text) < int.Parse(Txt_Qte.Text))
            {
                Txt_Qte.Focus();
                Txt_Qte.BackColor = Color.Red;
            }
            else Txt_Qte.BackColor = Color.Green;
            }
            catch(Exception)
            {
                MessageBox.Show("Stock insuffisant", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
