using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetII_B56
{
    public partial class frmInfoDepense : Form
    {
        public frmInfoDepense(
       string nomAbo,
    DateTime dateDepense,
    decimal montant,
    string typeService,
    string nomEmploye,
    decimal totalDepenses,
    decimal restant)
        {
            InitializeComponent();

            lblNomAbo.Text = nomAbo;
            lblDate.Text = dateDepense.ToShortDateString();
            lblMontant.Text = montant.ToString("0.00$");
            lblTypeService.Text = typeService;
            lblNomEmploye.Text = nomEmploye;
            lblTotalDepenses.Text = totalDepenses.ToString("0.00$");
            lblMontantRestant.Text = restant.ToString("0.00$");
        }

    }
}
