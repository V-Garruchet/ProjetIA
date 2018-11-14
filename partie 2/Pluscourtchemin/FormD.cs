using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Pluscourtchemin
{
    public partial class FormD : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        public FormD()
        {
            InitializeComponent();
        }


        // Crée la matrice correpondant au graphe
        private void button1_Click(object sender, EventArgs e)         
        {
           
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3;      matrice[1, 0] = 3;
            matrice[0, 2] = 5;      matrice[2, 0] = 5;
            matrice[0, 3] = 7;      matrice[3, 0] = 7;
            matrice[1, 4] = 8;      matrice[4, 1] = 8;
            matrice[2, 4] = 3;      matrice[4, 2] = 3;
            matrice[4, 5] = 7;      matrice[5, 4] = 7;
            matrice[5, 6] = 4;      matrice[6, 5] = 4;
        }


        // Affiche le plus court chemin sous la forme 0 --> 3
        private void button2_Click(object sender, EventArgs e)      
        {

            string res = "";                // Ces 2 lignes permettent d'éviter que lorsqu'on rappuie sur le bouton, les informations s'ajoutent à nouveau en dessous
            listBox1.Items.Clear();


            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            Node2 N1 = N0;
            for (int i=1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero) 
                     + "--->"  + Convert.ToString(N2.numero)
                     + "   : " +Convert.ToString(matrice[N1.numero,N2.numero]));


                res += Convert.ToString(N1.numero) + "--->" + Convert.ToString(N2.numero) + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]);  // ajouté par moi


                N1 = N2;
            }

            g.GetSearchTree(treeView1);



            // Cette partie de vérifier que l'entrée de l'utilisateur est la bonne

            string rep = "";

            int nbreLigne = tbPCC.Lines.Length;
            for (int l = 0; l < nbreLigne; l++)
            {
                rep += tbPCC.Lines[l];
            }

            if (res == rep)
                tbResPCC.Text = "Vrai";
            else
                tbResPCC.Text = "Faux";

        }


        // Affiche le graphe sous la forme 0 --> 3
        private void button3_Click(object sender, EventArgs e)
        {

            listBoxgraphe.Items.Clear(); // ajouté par moi

            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length) { strnbnoeuds = strnbnoeuds + ligne[i];
                i++; 
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] !=' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));            

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }



        // Permet de vérifier que les ouverts et fermés entrés par l'utilisateur sont les bons
        private void btnVerifO_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            List<int> listeOuvert = new List<int> { numinitial };
            List<int> listeFerme = new List<int> {  };
            List<string> ouverts = new List<string> { "0" };
            List<string> fermes = new List<string> { "-" };

            while (listeFerme.Count()==0 || listeFerme[listeFerme.Count()-1] != numfinal) 
            {

                listeFerme.Add(numinitial);
                listeOuvert.RemoveAt(0);

                for (int i = 0; i < nbnodes; i++)
                {
                    if (matrice[numinitial, i] != -1 && listeFerme.Contains(i)==false && listeOuvert.Contains(i) == false)
                    {
                        listeOuvert.Add(i);
                    }
                }

                if (listeOuvert.Count != 0)
                {
                    string ligneOuv = "";
                    for (int j = 0; j < listeOuvert.Count; j++)
                    {
                        if (j == listeOuvert.Count - 1)
                        {
                            ligneOuv += listeOuvert[j];
                        }
                        else
                        {
                            ligneOuv += listeOuvert[j] + ",";
                        }
                    }
                    ouverts.Add(ligneOuv);
                }

                string ligneFer = "";
                for (int k = 0; k < listeFerme.Count; k++)
                {
                    if (k == listeFerme.Count - 1)
                    {
                        ligneFer += listeFerme[k];
                    }
                    else
                    {
                        ligneFer += listeFerme[k] + ",";
                    }
                }
                fermes.Add(ligneFer);



                if (listeOuvert.Count() != 0)
                {
                    numinitial = listeOuvert[0];
                }            

            }

            if (listeOuvert.Count() == 0)
            {
                ouverts.Add("-");
            }


            int nbreLigneNO = tbNO.Lines.Length;
            string resNO = "Vrai";
            if (nbreLigneNO == ouverts.Count())
            {
                for (int lNO = 0; lNO < nbreLigneNO; lNO++)
                {
                    if (tbNO.Lines[lNO] != ouverts[lNO])
                    {
                        resNO = "Faux";
                        break;
                    }
                }
            }
            else
                resNO = "Faux";
            tbRepOuv.Text = resNO;


            int nbreLigneNF = tbNF.Lines.Length;
            string resNF = "Vrai";
            if (nbreLigneNF == fermes.Count())
            {
                for (int lNF = 0; lNF < nbreLigneNF; lNF++)
                {
                    if (tbNF.Lines[lNF] != fermes[lNF])
                    {
                        resNF = "Faux";
                        break;
                    }
                }
            }
            else
                resNF = "Faux";

            tbRepFer.Text = resNF;

        }



        private void tbNO_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
