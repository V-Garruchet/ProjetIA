﻿namespace Pluscourtchemin
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "A*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(855, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(681, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Init2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(243, 67);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // btnVerifO
            // 
            this.btnVerifO.Location = new System.Drawing.Point(439, 423);
            this.btnVerifO.Name = "btnVerifO";
            this.btnVerifO.Size = new System.Drawing.Size(122, 23);
            this.btnVerifO.TabIndex = 11;
            this.btnVerifO.Text = "Verifier";
            this.btnVerifO.UseVisualStyleBackColor = true;
            this.btnVerifO.Click += new System.EventHandler(this.btnVerifO_Click);
            // 
            // lbNO
            // 
            this.lbNO.AutoSize = true;
            this.lbNO.Location = new System.Drawing.Point(69, 288);
            this.lbNO.Name = "lbNO";
            this.lbNO.Size = new System.Drawing.Size(102, 13);
            this.lbNO.TabIndex = 15;
            this.lbNO.Text = "Noeud(s) Ouvert(s) :";
            // 
            // lbNF
            // 
            this.lbNF.AutoSize = true;
            this.lbNF.Location = new System.Drawing.Point(488, 288);
            this.lbNF.Name = "lbNF";
            this.lbNF.Size = new System.Drawing.Size(99, 13);
            this.lbNF.TabIndex = 16;
            this.lbNF.Text = "Noeud(s) Fermé(s) :";
            // 
            // tbNO
            // 
            this.tbNO.Location = new System.Drawing.Point(201, 285);
            this.tbNO.Name = "tbNO";
            this.tbNO.Size = new System.Drawing.Size(198, 132);
            this.tbNO.TabIndex = 17;
            this.tbNO.Text = "";
            this.tbNO.TextChanged += new System.EventHandler(this.tbNO_TextChanged_1);
            // 
            // tbNF
            // 
            this.tbNF.Location = new System.Drawing.Point(606, 288);
            this.tbNF.Name = "tbNF";
            this.tbNF.Size = new System.Drawing.Size(202, 135);
            this.tbNF.TabIndex = 18;
            this.tbNF.Text = "";
            // 
            // tbRepOuv
            // 
            this.tbRepOuv.Location = new System.Drawing.Point(223, 447);
            this.tbRepOuv.Name = "tbRepOuv";
            this.tbRepOuv.Size = new System.Drawing.Size(148, 42);
            this.tbRepOuv.TabIndex = 19;
            this.tbRepOuv.Text = "";
            // 
            // tbRepFer
            // 
            this.tbRepFer.Location = new System.Drawing.Point(627, 447);
            this.tbRepFer.Name = "tbRepFer";
            this.tbRepFer.Size = new System.Drawing.Size(152, 42);
            this.tbRepFer.TabIndex = 20;
            this.tbRepFer.Text = "";
            // 
            // tbPCC
            // 
            this.tbPCC.Location = new System.Drawing.Point(541, 67);
            this.tbPCC.Name = "tbPCC";
            this.tbPCC.Size = new System.Drawing.Size(100, 121);
            this.tbPCC.TabIndex = 21;
            this.tbPCC.Text = "";
            // 
            // tbResPCC
            // 
            this.tbResPCC.Location = new System.Drawing.Point(864, 217);
            this.tbResPCC.Name = "tbResPCC";
            this.tbResPCC.Size = new System.Drawing.Size(100, 20);
            this.tbResPCC.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 546);
            this.Controls.Add(this.tbResPCC);
            this.Controls.Add(this.tbPCC);
            this.Controls.Add(this.tbRepFer);
            this.Controls.Add(this.tbRepOuv);
            this.Controls.Add(this.tbNF);
            this.Controls.Add(this.tbNO);
            this.Controls.Add(this.lbNF);
            this.Controls.Add(this.lbNO);
            this.Controls.Add(this.btnVerifO);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

