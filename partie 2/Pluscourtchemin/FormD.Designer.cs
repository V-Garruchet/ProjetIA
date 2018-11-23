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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.tbPCC = new System.Windows.Forms.RichTextBox();
            this.tbResPCC = new System.Windows.Forms.TextBox();
            this.pbBox = new System.Windows.Forms.GroupBox();
            this.nxtButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.algoBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cheminBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.pbBox.SuspendLayout();
            this.algoBox.SuspendLayout();
            this.cheminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vérifier ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(217, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 108);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(369, 64);
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
            this.tbNO.Text = "";
            this.tbNO.TextChanged += new System.EventHandler(this.tbNO_TextChanged_1);
            // 
            // tbNF
            // 
            this.tbNF.Location = new System.Drawing.Point(541, 45);
            this.tbNF.Name = "tbNF";
            this.tbNF.Size = new System.Drawing.Size(189, 133);
            this.tbNF.TabIndex = 18;
            this.tbNF.Text = "";
            // 
            // tbRepOuv
            // 
            this.tbRepOuv.Location = new System.Drawing.Point(154, 196);
            this.tbRepOuv.Name = "tbRepOuv";
            this.tbRepOuv.Size = new System.Drawing.Size(136, 26);
            this.tbRepOuv.TabIndex = 19;
            this.tbRepOuv.Text = "";
            // 
            // tbRepFer
            // 
            this.tbRepFer.Location = new System.Drawing.Point(571, 196);
            this.tbRepFer.Name = "tbRepFer";
            this.tbRepFer.Size = new System.Drawing.Size(116, 26);
            this.tbRepFer.TabIndex = 20;
            this.tbRepFer.Text = "";
            // 
            // tbPCC
            // 
            this.tbPCC.Location = new System.Drawing.Point(32, 64);
            this.tbPCC.Name = "tbPCC";
            this.tbPCC.Size = new System.Drawing.Size(96, 119);
            this.tbPCC.TabIndex = 21;
            this.tbPCC.Text = "";
            // 
            // tbResPCC
            // 
            this.tbResPCC.Location = new System.Drawing.Point(233, 193);
            this.tbResPCC.Name = "tbResPCC";
            this.tbResPCC.Size = new System.Drawing.Size(96, 20);
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
            this.pbBox.Controls.Add(this.button1);
            this.pbBox.Controls.Add(this.label1);
            this.pbBox.Controls.Add(this.label2);
            this.pbBox.Location = new System.Drawing.Point(40, 98);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(418, 252);
            this.pbBox.TabIndex = 23;
            this.pbBox.TabStop = false;
            this.pbBox.Text = "Problème à résoudre : Aller du noeud A au noeud B, liés par le graphe G";
            this.pbBox.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(789, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 26;
            this.button5.Text = "Suivant";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cheminBox
            // 
            this.cheminBox.Controls.Add(this.label7);
            this.cheminBox.Controls.Add(this.label6);
            this.cheminBox.Controls.Add(this.label5);
            this.cheminBox.Controls.Add(this.tbResPCC);
            this.cheminBox.Controls.Add(this.tbPCC);
            this.cheminBox.Controls.Add(this.treeView1);
            this.cheminBox.Controls.Add(this.listBox1);
            this.cheminBox.Controls.Add(this.button2);
            this.cheminBox.Location = new System.Drawing.Point(628, 98);
            this.cheminBox.Name = "cheminBox";
            this.cheminBox.Size = new System.Drawing.Size(532, 270);
            this.cheminBox.TabIndex = 25;
            this.cheminBox.TabStop = false;
            this.cheminBox.Text = "Chemin le plus court pour aller du noeud A au noeud B";
            this.cheminBox.Visible = false;
            this.cheminBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Arbre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chemin le plus court";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Entrez le chemin le plus court : ";
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(1041, 36);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 26;
            this.btnRes.Text = "Résultats";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 637);
            this.Controls.Add(this.btnRes);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.RichTextBox tbPCC;
        private System.Windows.Forms.TextBox tbResPCC;
        private System.Windows.Forms.GroupBox pbBox;
        private System.Windows.Forms.GroupBox algoBox;
        private System.Windows.Forms.GroupBox cheminBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRes;
    }
}

