using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Alex.Controls;

namespace CultureDetente
{
    /// <summary>
    /// Enumération pour les Header des colonnes du DGV
    /// </summary>
    public enum EnumColumns { Id, Cote, TypeDoc, DateAchat, Disponible, Titre, Auteur, Genre, NombrePages, Caution }

    public partial class FormMain : Form
    {
        private ArrayList _alNameColumns = new ArrayList(new String[] { "Id", "cote", "Type Doc", "Date Achat", "Disponible", "Titre", "Auteur", "Genre", "Nombre Pages", "Caution" });


















        /// <summary>
        /// Constructeur
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeForm();
            InitializeGrid();
            FillCmbAuteurs();
            FillCmbTitres();
            FillDGV(Document.GetDocuments());
        }























        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initialisation de la grille
        /// </summary>
        private void InitializeGrid()
        {
            dgvLivreInfos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLivreInfos.ReadOnly = true;
            dgvLivreInfos.AllowUserToAddRows = false;
            dgvLivreInfos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (String columnName in _alNameColumns)
                dgvLivreInfos.Columns.Add(columnName, columnName);
        }



























        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Remplissage de la DGV
        /// </summary>
        /// <param name="documents">Liste des documents (OBJET)</param>
        private void FillDGV(List<Document> documents)
        {
            dgvLivreInfos.Rows.Clear();

            foreach (Document document in documents)
            {
                dgvLivreInfos.Rows.Add
                (
                    document.IdDocument,
                    document.Cote,
                    (document.TypeDocument == "L" ? "Livre" : "DVD"),
                    document.DateAchat.ToShortDateString(),
                    (document.Disponible ? "Oui" : "Non"),
                    document.Titre,
                    document.Auteur.NomAuteur,
                    document.Genre.NomGenre,
                    document.NombrePages,
                    document.Caution
                );
            }
        }
























        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initialisation d'une ComboBox
        /// </summary>
        /// <param name="cmb">_ComboBox</param>
        private void InitializeCmb(_ComboBox cmb)
        {
            cmb.Sorted = true;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
























        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Remplissage cmb auteurs
        /// </summary>
        private void FillCmbAuteurs()
        {
            cmbAuteurs.Items.Clear();

            InitializeCmb(cmbAuteurs);
            List<Auteur> auteurs = Auteur.GetAuteurs();

            foreach (Auteur auteur in auteurs)
                cmbAuteurs.Items.Add(new ItemData(auteur.IdAuteur, auteur.NomAuteur));

            //-----------------------------------
            //Insertion d'un Item "TOUS" au debut
            //-----------------------------------
            cmbAuteurs.Items.Insert(0, new ItemData(-1, "<  Tous  >"));

            //-----------------------------------
            // On choisi l'item "TOUS" par default
            //-----------------------------------
            cmbAuteurs.SelectedItem = (Object)cmbAuteurs.Items.Cast<ItemData>().Single(s => (Int32)s.Item == -1);
        }































        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Remplissage cmb titres
        /// </summary>
        private void FillCmbTitres()
        {
            cmbTitres.Items.Clear();

            InitializeCmb(cmbTitres);
            List<Document> documments = Document.GetDocuments();

            foreach (Document document in documments)
                cmbTitres.Items.Add(new ItemData(document.IdDocument, document.Titre));

            //-----------------------------------
            //Insertion d'un Item "TOUS" au debut
            //-----------------------------------
            cmbTitres.Items.Insert(0, new ItemData(-1, "<  Tous  >"));

            //-----------------------------------
            // On choisi l'item "TOUS par default
            //-----------------------------------
            cmbTitres.SelectedItem = (Object)cmbTitres.Items.Cast<ItemData>().Single(s => (Int32)s.Item == -1);
        }























        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initialisation de la FORM
        /// </summary>
        private void InitializeForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Culture & Détente";
            this.ShowInTaskbar = true;
        }































        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bouton rechercher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int32 idTitre = (Int32)(((ItemData)cmbTitres.SelectedItem).Item);
            Int32 idAuteur = (Int32)(((ItemData)cmbAuteurs.SelectedItem).Item);

            //--------------------
            //Si aucun item choisi
            //--------------------
            if ((idTitre == -1) && (idAuteur == -1))
            {
                FillDGV(Document.GetDocuments());
                return;
            }

            //------------------------------
            //Si les 2 cmb on un item choisi
            //------------------------------
            if ((idTitre != -1) && (idAuteur != -1))
            {
                FillDGV(Document.GetDocuments_IdAuteur_IdTitre(idAuteur, idTitre));
                return;
            }

            //------------------------
            //Si juste un titre choisi
            //-------------------------
            if (idTitre != -1)
            {
                FillDGV(Document.GetDocuments_IdTitre(idTitre));
                return;
            }

            //-------------------------
            //Si juste un auteur choisi
            //-------------------------
            if (idAuteur != -1)
            {
                FillDGV(Document.GetDocuments_IdAuteur(idAuteur));
                return;
            }
        }


























        //--------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// On quite l'application quand on ferme la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
