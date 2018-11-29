namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStart = new System.Windows.Forms.Button();
            this.pictureBoxSalotti = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBubble = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxArrowRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrowLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalotti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBubble)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.White;
            this.btStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Font = new System.Drawing.Font("Indie Flower", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(87, 178);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(206, 91);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Commencer le test !";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pictureBoxSalotti
            // 
            this.pictureBoxSalotti.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSalotti.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalotti.Image")));
            this.pictureBoxSalotti.Location = new System.Drawing.Point(4, 192);
            this.pictureBoxSalotti.Name = "pictureBoxSalotti";
            this.pictureBoxSalotti.Size = new System.Drawing.Size(151, 165);
            this.pictureBoxSalotti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalotti.TabIndex = 3;
            this.pictureBoxSalotti.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Réalisé par Victor Garruchet , Margot Triscos et Robin Bretin.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Projet IA";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(118, 117);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maîtrises-tu le savoir ancestral de l\'IA ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBubble
            // 
            this.pictureBoxBubble.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBubble.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBubble.Image")));
            this.pictureBoxBubble.Location = new System.Drawing.Point(105, 80);
            this.pictureBoxBubble.Name = "pictureBoxBubble";
            this.pictureBoxBubble.Size = new System.Drawing.Size(197, 139);
            this.pictureBoxBubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBubble.TabIndex = 9;
            this.pictureBoxBubble.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBoxArrowRight);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Location = new System.Drawing.Point(334, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 446);
            this.panel1.TabIndex = 10;
            // 
            // pictureBoxArrowRight
            // 
            this.pictureBoxArrowRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrowRight.Image")));
            this.pictureBoxArrowRight.Location = new System.Drawing.Point(-5, 183);
            this.pictureBoxArrowRight.Name = "pictureBoxArrowRight";
            this.pictureBoxArrowRight.Size = new System.Drawing.Size(65, 77);
            this.pictureBoxArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowRight.TabIndex = 8;
            this.pictureBoxArrowRight.TabStop = false;
            // 
            // pictureBoxArrowLeft
            // 
            this.pictureBoxArrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrowLeft.Image")));
            this.pictureBoxArrowLeft.Location = new System.Drawing.Point(281, 183);
            this.pictureBoxArrowLeft.Name = "pictureBoxArrowLeft";
            this.pictureBoxArrowLeft.Size = new System.Drawing.Size(100, 77);
            this.pictureBoxArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowLeft.TabIndex = 11;
            this.pictureBoxArrowLeft.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxArrowLeft);
            this.Controls.Add(this.pictureBoxBubble);
            this.Controls.Add(this.pictureBoxSalotti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Bienvenue jeune padawan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalotti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBubble)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.PictureBox pictureBoxSalotti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBubble;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxArrowRight;
        private System.Windows.Forms.PictureBox pictureBoxArrowLeft;
    }
}

