using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluscourtchemin
{
    public partial class ResultatsPart2 : Form
    {
        public ResultatsPart2(int resultatPart2)
        {                     
            InitializeComponent();
            lbScorePart2.Text = resultatPart2.ToString();
            int score = Int32.Parse(lbScorePart2.Text);
            if (score == 0)
            {
                lbQuote.Text = "La peine emplie mon coeur.";
            }

            if (score < 3 && score > 0)
            {
                lbQuote.Text = "Pas trop mal.";
            }

            if (score == 3)
            {
                lbQuote.Text = "La joie emplie mon coeur.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
