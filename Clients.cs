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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        // Objet de connexion Objet de connexion pour appliquer tout nos requetes et nos connexions
        Sql_Raccourcis Raccourcis = new Sql_Raccourcis();
        private void Clients_Load(object sender, EventArgs e)// Connection lors du chargement de l'interface
        {
            Raccourcis.CONNECTER();
            DGV_Load();
            if (NbrClients() != 0) Text_ID.Text = IDClientCount().ToString();
            
        }

        public void DGV_Load()//Chargement donnees DGV
        {
            if (Raccourcis.DT.Rows != null)
            {
                Raccourcis.DT.Clear();
            }
            Raccourcis.Comm.CommandText = "Select * from clients";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            Raccourcis.DT.Load(Raccourcis.Rd);
            DGV.DataSource = Raccourcis.DT;
            Raccourcis.Rd.Close();
            if (NbrClients() != 0) Text_ID.Text = IDClientCount().ToString();
            Lab_NbrClients.Text = NbrClients().ToString();
            ///
            //Test_Commande_TWO();
            ///
            ///
        }
        public static bool IsNumeric(string s)  // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        public int NbrClients() // Fonction pour affiche le dernier ID enregistrer
        {
            Raccourcis.Comm.CommandText = "Select count(ID) from clients";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return (int)Raccourcis.Comm.ExecuteScalar();
        }

        public int IDClientCount() // Fonction qui retourne le Nbr des Produits
        {

            Raccourcis.Comm.CommandText = "Select MAX(ID) from clients where Nom IS NOT NULL";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            return ((int)Raccourcis.Comm.ExecuteScalar());
        }

        public string commentaire() // Recuperation des commentaires sur les Clients
        {
            try // Un peu de Try catch a la place des conditions if.
            {
                Raccourcis.Comm.CommandText = "select contenu from commentaires  inner join clients on commentaires.id_client='" + Text_Recherche.Text + "' and contenu IS NOT NULL;";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                return Raccourcis.Comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (Text_Nom.Text == "" || Text_Prenom.Text == "")
            {
                MessageBox.Show("Merci de Remplir 'Nom' et/Ou 'Prenom' !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Raccourcis.Comm.CommandText = "insert into clients(nom,prenom) values('" + Text_Nom.Text + "','"
                        + Text_Prenom.Text + "')";
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Comm.ExecuteNonQuery();
            DGV_Load();

        }
        private void Button_Modifier_Click_1(object sender, EventArgs e)
        {
            if (DGV.CurrentCell.Value is int)
            {
                if (MessageBox.Show("Etes-vous sur de le Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Raccourcis.Comm.CommandText = "update clients set nom='" + Text_Nom.Text +
                  "',prenom='" + Text_Prenom.Text + "' where id ='" + DGV.CurrentCell.Value.ToString() + "'";
                    Raccourcis.Comm.Connection = Raccourcis.Connex;
                    Raccourcis.Comm.ExecuteNonQuery();
                    DGV_Load();
                }
            }
            else MessageBox.Show("Merci choisir la Cellule 'ID' a Modifier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Button_Supp_Click(object sender, EventArgs e)
        {
            try
            {  // le seul solution sans perturber ma base de donnees, delete cascade a revoir bien sur
                if (DGV.CurrentCell.Value is int)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Raccourcis.Comm.CommandText = "delete from clients where id ='" + DGV.CurrentCell.Value.ToString() + "'";
                        Raccourcis.Comm.Connection = Raccourcis.Connex;
                        Raccourcis.Comm.ExecuteNonQuery();
                        DGV_Load();
                    }
                }
                else MessageBox.Show("Merci de choisir la Cellule 'ID' ou la Suppression sera appliquer !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Des Commandes sont lier a ce client, impossile de supprimer !", "Erreur Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void Button_Recherche_Click(object sender, EventArgs e)
        {
            if (IsNumeric(Text_Recherche.Text) == true)
            {
                Raccourcis.Comm.CommandText = "Select * from clients where clients.id='" + Text_Recherche.Text + "';";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
                while (Raccourcis.Rd.Read())
                {
                    Lab_Infos.Text = " - ID  = "
                        + Raccourcis.Rd[0] + "  ,Corresponds au Client : "
                        + Raccourcis.Rd[1].ToString().ToUpper() + " " //Affiche Nom en Maj
                        + Raccourcis.Rd[2];
                }
                Raccourcis.Rd.Close();
                Rich_Text_Com.Text = commentaire();
            }
            else MessageBox.Show("Merci de Rechercher par ID !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Button_Commentaire_Click(object sender, EventArgs e)
        {
            if (commentaire() != "")
            {
                Raccourcis.Comm.CommandText = "update commentaires set contenu='" + Rich_Text_Com.Text + "' where commentaires.id_client =" + Text_Recherche.Text;
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Modification et ajout d'un nouveau commentaire 
            }
            else
            {
                Raccourcis.Comm.CommandText = "insert into commentaires(id_client,contenu) values('" + Text_Recherche.Text + "','" + Rich_Text_Com.Text + "' );";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                Raccourcis.Comm.ExecuteNonQuery();
                // Ajout d'un commentaire pour la 1ere fois
            }
        }
        public void Test_Commande()
        {
            int A = NbrClients();// Read Interior ead imppossibellelelelkleek,eebhueugidj
            Raccourcis.Comm.CommandText = "Select id_client from commandes inner join clients on clients.id=commandes.id_client" ;
            Raccourcis.Comm.Connection = Raccourcis.Connex;
            Raccourcis.Rd = Raccourcis.Comm.ExecuteReader();
            //for(int i = 0; i < A; i++) {
            while (Raccourcis.Rd.Read())
            {
                    //if (Raccourcis.Rd[0].ToString().Equals(DGV.Rows[i].Cells[0].Value.ToString()))
                    if (Raccourcis.Rd[0].ToString().Equals(DGV.CurrentCell.Value.ToString()))// Cell clic
                {
                    DGV.CurrentCell.Style.BackColor = Color.Red;
                    DGV.CurrentCell.Style.ForeColor = Color.White;
                }
                                }
            Raccourcis.Rd.Close();
            //}
            
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Test_Commande();
        }

        /*public void Test_Commande_TWO() { 
            for(int i = 1; i < DGV.Rows.Count -1; i++)
            {
                Raccourcis.Comm.CommandText = "Select id_client from commandes inner join clients on clients.id=commandes.id_client where id_client='"+DGV.Rows[i].Cells[0].Value+"';";
                Raccourcis.Comm.Connection = Raccourcis.Connex;
                int A = int.Parse(Raccourcis.Comm.ExecuteScalar().ToString());
                DGV.Rows[A].DefaultCellStyle.BackColor = Color.Red;
            }
                }*/
    }
}