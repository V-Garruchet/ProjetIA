using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex1_Questionnaire;

namespace WindowsFormsApplication1
{
    public partial class FormQuestions : Form
    {
        // Liste des questions restantes
        public static List<int> QRest = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        // Réponse de la question actuelle
        public static string RepQenCours = "B";

        // Score du participant au QCM /20
        public static int score = 0;


        // Crée le form avec la question en cours en la fixant au même emplacement que la question précédente
        public FormQuestions()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            InitializeComponent();
        }


        // Lance la question suivante (ou la page de score si on est à la fin) et vérifie si la/les réponse(s) sélectionnée(s) sont bonnes pour faire évoluer le score
        private void btSuivant_Click(object sender, EventArgs e)
        {          
            string rep = "";
            if (cbRep1.Checked)
            {
                rep += "A";
            }
            if (cbRep2.Checked)
            {
                rep += "B";
            }
            if (cbRep3.Checked)
            {
                rep += "C";
            }
            if (cbRep4.Checked)
            {
                rep += "D";
            }
            if(rep==RepQenCours && QRest.Count()!=20  && btVerif.Enabled != false)       // La 3ème condition permet de ne pas compter de point si la réponse est cochée après la vérif
            {                                                                            // La deuxième condition permet de ne pas compter de point sur la question 0 qui sert d'exemple
                score += 1;
            }
            if (QRest.Count != 0)                           // On affiche la question suivante car il en reste
            {
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
                monthread.Start();
                this.Close();                
            }
            else
            {                                               // On était à la dernière question donc on ouvre la page des résultats du QCM
                btSuivant.Text = "Résultats";
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirResultats));
                monthread.Start();
                this.Close();
            }
        }


        // Permet de générer la question et de l'associer à un form
        public static void ouvrirnouveauform()
        {
            FormQuestions form1 = new FormQuestions();
            int ind = new Random().Next(0, QRest.Count);
            int numQ = QRest[ind];
            QRest.Remove(numQ);
            Question Q = new Question(numQ);
            form1.lbQ.Text = Q.QuestionText;
            form1.cbRep1.Text = Q.Answers[0];
            form1.cbRep2.Text = Q.Answers[1];
            form1.cbRep3.Text = Q.Answers[2];
            form1.cbRep4.Text = Q.Answers[3];
            RepQenCours = Q.GoodAnswer;
            if (Q.Image != null && Q.Image != "")
                form1.pictureBoxQuestion.Image = Image.FromFile("..\\..\\Images\\" + Q.Image);
            
            Application.Run(form1);
        }


        // Lance la page de résultat
        public static void ouvrirResultats()
        {
            Resultats formRes = new Resultats();
            formRes.lbRes.Text = score.ToString()+" / 20";
            Application.Run(formRes);
        }



        // Permet de vérifier si notre réponse à la question est juste en mettant en valeur les bonnes (vertes) et mauvaises (rouges) réponses
        private void btVerif_Click(object sender, EventArgs e)
        {
            string rep = "";
            if (cbRep1.Checked)
            {
                rep += "A";
            }
            if (cbRep2.Checked)
            {
                rep += "B";
            }
            if (cbRep3.Checked)
            {
                rep += "C";
            }
            if (cbRep4.Checked)
            {
                rep += "D";
            }
            if (rep == RepQenCours && QRest.Count() != 20) 
            {
                score += 1;
            }


            if (cbRep1.Checked)
            {
                cbRep1.ForeColor= Color.Red;
            }
            if (cbRep2.Checked)
            {
                cbRep2.ForeColor = Color.Red;
            }
            if (cbRep3.Checked)
            {
                cbRep3.ForeColor = Color.Red;
            }
            if (cbRep4.Checked)
            {
                cbRep4.ForeColor = Color.Red;
            }
            if (RepQenCours.Contains("A"))
            {
                cbRep1.ForeColor = Color.Green;
            }
            if (RepQenCours.Contains("B"))
            {
                cbRep2.ForeColor = Color.Green;
            }
            if (RepQenCours.Contains("C"))
            {
                cbRep3.ForeColor = Color.Green;
            }
            if (RepQenCours.Contains("D"))
            {
                cbRep4.ForeColor = Color.Green;
            }
            btVerif.Enabled = false;
        }

    }
}
