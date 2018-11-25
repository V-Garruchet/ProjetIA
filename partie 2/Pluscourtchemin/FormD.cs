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


        static public int scorePart2 = 2;

        static List<int> listeOuvert = new List<int> { };
        static List<int> listeFerme = new List<int> { };
        static List<string> ouverts = new List<string> { "0" };
        static List<string> fermes = new List<string> { "-" };


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
            {
                tbResPCC.Text = "Vrai";
                scorePart2 += 1;
            }
            else
                tbResPCC.Text = "Faux";


            // On affiche le bouton pour aller aux résultats et on bloque la modification de la réponse saisie pour éviter la triche

            btnRes.Visible = true;
        }


        // Affiche le graphe sous la forme 0 --> 3
        private void button3_Click(object sender, EventArgs e)
        {
            nxtButton.Visible = true; 
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
            if (listeFerme.Count() == 0 && listeOuvert.Count() == 0)
            {
                numinitial = Convert.ToInt32(textBox1.Text);
                listeOuvert.Add(numinitial);
                numfinal = Convert.ToInt32(textBox2.Text);
            }



            if (listeFerme.Count() == 0 || listeFerme[listeFerme.Count() - 1] != numfinal)
            {

                listeFerme.Add(numinitial);     // On ajoute dans les fermés le premier de la listed des ouverts
                listeOuvert.RemoveAt(0);        // On supprime le premier terme de la liste des ouverts qui passe dans les fermés


                // On crée la liste des ouverts par rapport au dernier fermé ajouté
                for (int i = 0; i < nbnodes; i++)
                {
                    if (matrice[numinitial, i] != -1 && listeFerme.Contains(i) == false && listeOuvert.Contains(i) == false)
                    {
                        listeOuvert.Add(i);
                    }
                }

                // On met la liste des ouverts à un format particulier pour pouvoir le comparer à l'entrée de l'utilisateur
                string ligneOuv = "";
                if (listeOuvert.Count != 0)
                {
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
                // On ajoute le caractère - à la dernière liste d'ouvert pour montrer qu'elle est vide
                else
                {
                    ligneOuv+="-";
                    button5.Visible = true;
                }               


                // On met la liste des fermés à un format particulier pour pouvoir le comparer à l'entrée de l'utilisateur
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


                // On prépare l'échange du premier terme des ouverts en fermé
                if (listeOuvert.Count() != 0)
                {
                    numinitial = listeOuvert[0];
                }


                // On va maintenant comparer l'entrée de l'utilisateur à la liste des ouverts et fermés actuel
                string resNF = "Vrai";
                string resNO = "Vrai";
                if (tbEntreFerme.Text != ligneFer)
                {
                    resNF = "Faux";
                }

                if (tbEntreOuvert.Text != ligneOuv)
                {
                    resNO = "Faux";
                }

                tbRepFer.Text = resNF;
                tbRepOuv.Text = resNO;

                tbNO.Text += ligneOuv + Environment.NewLine;
                tbNF.Text += ligneFer + Environment.NewLine;
                tbEntreFerme.Text = "";
                tbEntreOuvert.Text = "";

                if (resNF != "Vrai" || resNO != "Vrai")
                {
                    scorePart2 = 0;
                }
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            pbBox.Visible = false; 
            algoBox.Visible = true; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            algoBox.Visible = false;
            cheminBox.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread2 = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirRes));
            monthread2.Start();
            this.Close();
        }


        // Lance les résultats
        public static void ouvrirRes()
        {
            ResultatsPart2 formRes = new ResultatsPart2(scorePart2);
            Application.Run(formRes);
            
        }

    }
}
