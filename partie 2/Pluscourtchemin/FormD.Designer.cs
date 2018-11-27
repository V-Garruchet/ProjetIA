namespace Pluscourtchemin
{
    partial class FormD
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.btnVerifO = new System.Windows.Forms.Button();
            this.lbNO = new System.Windows.Forms.Label();
            this.lbNF = new System.Windows.Forms.Label();
            this.tbNO = new System.Windows.Forms.RichTextBox();
            this.tbNF = new System.Windows.Forms.RichTextBox();
            this.tbRepOuv = new System.Windows.Forms.RichTextBox();
            this.tbRepFer = new System.Windows.Forms.RichTextBox();
            this.tbResPCC = new System.Windows.Forms.TextBox();
            this.pbBox = new System.Windows.Forms.GroupBox();
            this.nxtButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.algoBox = new System.Windows.Forms.GroupBox();
            this.tbEntreFerme = new System.Windows.Forms.TextBox();
            this.tbEntreOuvert = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cheminBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnVerifNoeud = new System.Windows.Forms.Button();
            this.rtbResumeArbre = new System.Windows.Forms.RichTextBox();
            this.tbDistParent = new System.Windows.Forms.TextBox();
            this.lbIndic = new System.Windows.Forms.Label();
            this.tbNoeudEnCours = new System.Windows.Forms.TextBox();
            this.lbNoeudEnCours = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBox.SuspendLayout();
            this.algoBox.SuspendLayout();
            this.cheminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud B";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(364, 77);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(143, 142);
            this.treeView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(16, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "Générer le graphe";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(189, 119);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(98, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // btnVerifO
            // 
            this.btnVerifO.Location = new System.Drawing.Point(375, 196);
            this.btnVerifO.Name = "btnVerifO";
            this.btnVerifO.Size = new System.Drawing.Size(129, 21);
            this.btnVerifO.TabIndex = 11;
            this.btnVerifO.Text = "Vérifier";
            this.btnVerifO.UseVisualStyleBackColor = true;
            this.btnVerifO.Click += new System.EventHandler(this.btnVerifO_Click);
            // 
            // lbNO
            // 
            this.lbNO.AutoSize = true;
            this.lbNO.Location = new System.Drawing.Point(87, 32);
            this.lbNO.Name = "lbNO";
            this.lbNO.Size = new System.Drawing.Size(281, 13);
            this.lbNO.TabIndex = 15;
            this.lbNO.Text = "Entrez la liste des noeuds ouverts aux différentes étapes  :";
            // 
            // lbNF
            // 
            this.lbNF.AutoSize = true;
            this.lbNF.Location = new System.Drawing.Point(506, 29);
            this.lbNF.Name = "lbNF";
            this.lbNF.Size = new System.Drawing.Size(277, 13);
            this.lbNF.TabIndex = 16;
            this.lbNF.Text = "Entrez la liste des noeuds fermés aux différentes étapes  :";
            // 
            // tbNO
            // 
            this.tbNO.Location = new System.Drawing.Point(126, 48);
            this.tbNO.Name = "tbNO";
            this.tbNO.Size = new System.Drawing.Size(199, 130);
            this.tbNO.TabIndex = 17;
            this.tbNO.Text = "0\n";
            // 
            // tbNF
            // 
            this.tbNF.Location = new System.Drawing.Point(541, 45);
            this.tbNF.Name = "tbNF";
            this.tbNF.Size = new System.Drawing.Size(199, 133);
            this.tbNF.TabIndex = 18;
            this.tbNF.Text = "-\n";
            // 
            // tbRepOuv
            // 
            this.tbRepOuv.Location = new System.Drawing.Point(39, 99);
            this.tbRepOuv.Name = "tbRepOuv";
            this.tbRepOuv.Size = new System.Drawing.Size(59, 26);
            this.tbRepOuv.TabIndex = 19;
            this.tbRepOuv.Text = "";
            // 
            // tbRepFer
            // 
            this.tbRepFer.Location = new System.Drawing.Point(769, 99);
            this.tbRepFer.Name = "tbRepFer";
            this.tbRepFer.Size = new System.Drawing.Size(74, 26);
            this.tbRepFer.TabIndex = 20;
            this.tbRepFer.Text = "";
            // 
            // tbResPCC
            // 
            this.tbResPCC.Location = new System.Drawing.Point(81, 203);
            this.tbResPCC.Name = "tbResPCC";
            this.tbResPCC.Size = new System.Drawing.Size(61, 20);
            this.tbResPCC.TabIndex = 22;
            // 
            // pbBox
            // 
            this.pbBox.Controls.Add(this.nxtButton);
            this.pbBox.Controls.Add(this.label4);
            this.pbBox.Controls.Add(this.listBoxgraphe);
            this.pbBox.Controls.Add(this.button3);
            this.pbBox.Controls.Add(this.textBox2);
            this.pbBox.Controls.Add(this.textBox1);
            this.pbBox.Controls.Add(this.label1);
            this.pbBox.Controls.Add(this.label2);
            this.pbBox.Location = new System.Drawing.Point(40, 98);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(418, 252);
            this.pbBox.TabIndex = 23;
            this.pbBox.TabStop = false;
            this.pbBox.Text = "Problème à résoudre : Aller du noeud A au noeud B, liés par le graphe G";
            // 
            // nxtButton
            // 
            this.nxtButton.Location = new System.Drawing.Point(316, 196);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(86, 32);
            this.nxtButton.TabIndex = 11;
            this.nxtButton.Text = "Suivant";
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Visible = false;
            this.nxtButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Graphe G";
            // 
            // algoBox
            // 
            this.algoBox.Controls.Add(this.tbEntreFerme);
            this.algoBox.Controls.Add(this.tbEntreOuvert);
            this.algoBox.Controls.Add(this.button5);
            this.algoBox.Controls.Add(this.tbRepFer);
            this.algoBox.Controls.Add(this.tbRepOuv);
            this.algoBox.Controls.Add(this.tbNF);
            this.algoBox.Controls.Add(this.tbNO);
            this.algoBox.Controls.Add(this.lbNO);
            this.algoBox.Controls.Add(this.lbNF);
            this.algoBox.Controls.Add(this.btnVerifO);
            this.algoBox.Location = new System.Drawing.Point(190, 391);
            this.algoBox.Name = "algoBox";
            this.algoBox.Size = new System.Drawing.Size(899, 234);
            this.algoBox.TabIndex = 24;
            this.algoBox.TabStop = false;
            this.algoBox.Text = "Appliquez l\'algorithme de Dijkstra pour aller du noeud A au noeud B";
            this.algoBox.Visible = false;
            // 
            // tbEntreFerme
            // 
            this.tbEntreFerme.Location = new System.Drawing.Point(541, 197);
            this.tbEntreFerme.Name = "tbEntreFerme";
            this.tbEntreFerme.Size = new System.Drawing.Size(199, 20);
            this.tbEntreFerme.TabIndex = 28;
            // 
            // tbEntreOuvert
            // 
            this.tbEntreOuvert.Location = new System.Drawing.Point(126, 197);
            this.tbEntreOuvert.Name = "tbEntreOuvert";
            this.tbEntreOuvert.Size = new System.Drawing.Size(199, 20);
            this.tbEntreOuvert.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(789, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 26;
            this.button5.Text = "Suivant";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cheminBox
            // 
            this.cheminBox.Controls.Add(this.label5);
            this.cheminBox.Controls.Add(this.btnRes);
            this.cheminBox.Controls.Add(this.btnVerifNoeud);
            this.cheminBox.Controls.Add(this.rtbResumeArbre);
            this.cheminBox.Controls.Add(this.tbDistParent);
            this.cheminBox.Controls.Add(this.lbIndic);
            this.cheminBox.Controls.Add(this.tbNoeudEnCours);
            this.cheminBox.Controls.Add(this.lbNoeudEnCours);
            this.cheminBox.Controls.Add(this.label7);
            this.cheminBox.Controls.Add(this.tbResPCC);
            this.cheminBox.Controls.Add(this.treeView1);
            this.cheminBox.Location = new System.Drawing.Point(628, 98);
            this.cheminBox.Name = "cheminBox";
            this.cheminBox.Size = new System.Drawing.Size(532, 270);
            this.cheminBox.TabIndex = 25;
            this.cheminBox.TabStop = false;
            this.cheminBox.Text = "Arbre pour aller du noeud A au noeud B";
            this.cheminBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Noeuds et distances";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(312, 229);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 26;
            this.btnRes.Text = "Résultats";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnVerifNoeud
            // 
            this.btnVerifNoeud.Location = new System.Drawing.Point(60, 168);
            this.btnVerifNoeud.Name = "btnVerifNoeud";
            this.btnVerifNoeud.Size = new System.Drawing.Size(96, 20);
            this.btnVerifNoeud.TabIndex = 27;
            this.btnVerifNoeud.Text = "Vérifier ";
            this.btnVerifNoeud.UseVisualStyleBackColor = true;
            this.btnVerifNoeud.Click += new System.EventHandler(this.btnVerifNoeud_Click);
            // 
            // rtbResumeArbre
            // 
            this.rtbResumeArbre.Location = new System.Drawing.Point(221, 77);
            this.rtbResumeArbre.Name = "rtbResumeArbre";
            this.rtbResumeArbre.Size = new System.Drawing.Size(111, 142);
            this.rtbResumeArbre.TabIndex = 27;
            this.rtbResumeArbre.Text = "";
            // 
            // tbDistParent
            // 
            this.tbDistParent.Location = new System.Drawing.Point(130, 121);
            this.tbDistParent.Name = "tbDistParent";
            this.tbDistParent.Size = new System.Drawing.Size(42, 20);
            this.tbDistParent.TabIndex = 28;
            // 
            // lbIndic
            // 
            this.lbIndic.AutoSize = true;
            this.lbIndic.Location = new System.Drawing.Point(6, 128);
            this.lbIndic.Name = "lbIndic";
            this.lbIndic.Size = new System.Drawing.Size(103, 13);
            this.lbIndic.TabIndex = 28;
            this.lbIndic.Text = "Distance au parent :";
            // 
            // tbNoeudEnCours
            // 
            this.tbNoeudEnCours.Location = new System.Drawing.Point(130, 77);
            this.tbNoeudEnCours.Name = "tbNoeudEnCours";
            this.tbNoeudEnCours.Size = new System.Drawing.Size(42, 20);
            this.tbNoeudEnCours.TabIndex = 27;
            // 
            // lbNoeudEnCours
            // 
            this.lbNoeudEnCours.AutoSize = true;
            this.lbNoeudEnCours.Location = new System.Drawing.Point(6, 80);
            this.lbNoeudEnCours.Name = "lbNoeudEnCours";
            this.lbNoeudEnCours.Size = new System.Drawing.Size(89, 13);
            this.lbNoeudEnCours.TabIndex = 26;
            this.lbNoeudEnCours.Text = "Noeud en cours :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Arbre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "L\'algorithme de Dijkstra";
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cheminBox);
            this.Controls.Add(this.algoBox);
            this.Controls.Add(this.pbBox);
            this.Name = "FormD";
            this.Text = "Form1";
            this.pbBox.ResumeLayout(false);
            this.pbBox.PerformLayout();
            this.algoBox.ResumeLayout(false);
            this.algoBox.PerformLayout();
            this.cheminBox.ResumeLayout(false);
            this.cheminBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.Button btnVerifO;
        private System.Windows.Forms.Label lbNO;
        private System.Windows.Forms.Label lbNF;
        private System.Windows.Forms.RichTextBox tbNO;
        private System.Windows.Forms.RichTextBox tbNF;
        private System.Windows.Forms.RichTextBox tbRepOuv;
        private System.Windows.Forms.RichTextBox tbRepFer;
        private System.Windows.Forms.TextBox tbResPCC;
        private System.Windows.Forms.GroupBox pbBox;
        private System.Windows.Forms.GroupBox algoBox;
        private System.Windows.Forms.GroupBox cheminBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox tbEntreFerme;
        private System.Windows.Forms.TextBox tbEntreOuvert;
        private System.Windows.Forms.TextBox tbDistParent;
        private System.Windows.Forms.Label lbIndic;
        private System.Windows.Forms.TextBox tbNoeudEnCours;
        private System.Windows.Forms.Label lbNoeudEnCours;
        private System.Windows.Forms.RichTextBox rtbResumeArbre;
        private System.Windows.Forms.Button btnVerifNoeud;
        private System.Windows.Forms.Label label5;
    }
}

