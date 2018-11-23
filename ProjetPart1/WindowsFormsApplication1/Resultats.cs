using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pluscourtchemin;

namespace WindowsFormsApplication1
{
    public partial class Resultats : Form
    {
        public Resultats()
        {
            InitializeComponent();
        }

        private void btnPart2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread2 = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirPartie2));
            monthread2.Start();
            this.Close();
        }


        // Lance la Partie 2
        public static void ouvrirPartie2()
        {
            FormD formPart2 = new FormD();
            Application.Run(formPart2);
        }
    }
}
