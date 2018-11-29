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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Affiche la première question qui sert d'exemple
        private void btStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
        }


        // Crée question qui sert d'exemple
        public static void ouvrirnouveauform()
        {
            FormQuestions form1 = new FormQuestions();
            Question Q1 = new Question(0);
            form1.lbQ.Text = Q1.QuestionText;
            form1.cbRep1.Text = Q1.Answers[0];
            form1.cbRep2.Text = Q1.Answers[1];
            form1.cbRep3.Text = Q1.Answers[2];
            form1.cbRep4.Text = Q1.Answers[3];
            form1.pictureBoxQuestion.Image = Image.FromFile("..\\..\\Images\\" + Q1.Image);
            Application.Run(form1);
        }

    }
}
