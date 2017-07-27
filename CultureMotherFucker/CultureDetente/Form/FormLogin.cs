using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Alex.Boxs;

namespace CultureDetente
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MaximumSize = new Size(287, 190);
            this.MinimumSize = new Size(287, 190);
            this.Text = "";
            this.ShowInTaskbar = true;
        }



























        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Affichage FormMain si adresse mail valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsMailValid(txtMail.Text)) return;

            this.Hide();
            new FormMain().Show();
        }






























        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Verification qu'un mail est valide
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        private Boolean IsMailValid(String mail)
        {
            Regex regex = new Regex(@"^([\w]{2,})@([\w]{2,})\.([\w]{2,})$");

            if (!regex.IsMatch(txtMail.Text))
            {
                BoxError.Show("Erreur adresse mail", "L'adresse mail n'est pas valide : " + txtMail.Text);
                return false;
            }

            return true;
        }
    }
}
