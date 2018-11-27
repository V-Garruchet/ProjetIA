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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbQuote_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbScorePart2.Text) < 10)
            {
                lbQuote.Text = "La peine emplie mon coeur.";
            }

            if (Int32.Parse(lbScorePart2.Text) > 10)
            {
                lbQuote.Text = "La joie emplie mon coeur.";
            }
        }
    }
}
