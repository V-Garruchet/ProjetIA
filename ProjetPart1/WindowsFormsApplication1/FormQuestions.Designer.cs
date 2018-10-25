namespace WindowsFormsApplication1
{
    partial class FormQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQ = new System.Windows.Forms.Label();
            this.btVerif = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRep1 = new System.Windows.Forms.CheckBox();
            this.cbRep2 = new System.Windows.Forms.CheckBox();
            this.cbRep3 = new System.Windows.Forms.CheckBox();
            this.cbRep4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.AutoSize = true;
            this.lbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.Location = new System.Drawing.Point(21, 22);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(110, 29);
            this.lbQ.TabIndex = 0;
            this.lbQ.Text = "Question";
            // 
            // btVerif
            // 
            this.btVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerif.Location = new System.Drawing.Point(137, 366);
            this.btVerif.Name = "btVerif";
            this.btVerif.Size = new System.Drawing.Size(131, 38);
            this.btVerif.TabIndex = 5;
            this.btVerif.Text = "Vérifier";
            this.btVerif.UseVisualStyleBackColor = true;
            // 
            // btSuivant
            // 
            this.btSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuivant.Location = new System.Drawing.Point(381, 366);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(131, 38);
            this.btSuivant.TabIndex = 6;
            this.btSuivant.Text = "Suivant";
            this.btSuivant.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRep4);
            this.groupBox1.Controls.Add(this.cbRep3);
            this.groupBox1.Controls.Add(this.cbRep2);
            this.groupBox1.Controls.Add(this.cbRep1);
            this.groupBox1.Location = new System.Drawing.Point(47, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cbRep1
            // 
            this.cbRep1.AutoSize = true;
            this.cbRep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRep1.Location = new System.Drawing.Point(32, 37);
            this.cbRep1.Name = "cbRep1";
            this.cbRep1.Size = new System.Drawing.Size(102, 24);
            this.cbRep1.TabIndex = 5;
            this.cbRep1.Text = "Réponse1";
            this.cbRep1.UseVisualStyleBackColor = true;
            // 
            // cbRep2
            // 
            this.cbRep2.AutoSize = true;
            this.cbRep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRep2.Location = new System.Drawing.Point(32, 96);
            this.cbRep2.Name = "cbRep2";
            this.cbRep2.Size = new System.Drawing.Size(102, 24);
            this.cbRep2.TabIndex = 6;
            this.cbRep2.Text = "Réponse2";
            this.cbRep2.UseVisualStyleBackColor = true;
            // 
            // cbRep3
            // 
            this.cbRep3.AutoSize = true;
            this.cbRep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRep3.Location = new System.Drawing.Point(32, 161);
            this.cbRep3.Name = "cbRep3";
            this.cbRep3.Size = new System.Drawing.Size(102, 24);
            this.cbRep3.TabIndex = 7;
            this.cbRep3.Text = "Réponse3";
            this.cbRep3.UseVisualStyleBackColor = true;
            // 
            // cbRep4
            // 
            this.cbRep4.AutoSize = true;
            this.cbRep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRep4.Location = new System.Drawing.Point(32, 224);
            this.cbRep4.Name = "cbRep4";
            this.cbRep4.Size = new System.Drawing.Size(102, 24);
            this.cbRep4.TabIndex = 8;
            this.cbRep4.Text = "Réponse4";
            this.cbRep4.UseVisualStyleBackColor = true;
            // 
            // FormQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btVerif);
            this.Controls.Add(this.lbQ);
            this.Name = "FormQuestions";
            this.Text = "FormQuestions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.Button btVerif;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRep4;
        private System.Windows.Forms.CheckBox cbRep3;
        private System.Windows.Forms.CheckBox cbRep2;
        private System.Windows.Forms.CheckBox cbRep1;
    }
}