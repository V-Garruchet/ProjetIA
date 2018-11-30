namespace Pluscourtchemin
{
    partial class ResultatsPart2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultatsPart2));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbScorePart2 = new System.Windows.Forms.Label();
            this.lbResult2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbQuote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(466, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbScorePart2
            // 
            this.lbScorePart2.AutoSize = true;
            this.lbScorePart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScorePart2.Location = new System.Drawing.Point(488, 130);
            this.lbScorePart2.Name = "lbScorePart2";
            this.lbScorePart2.Size = new System.Drawing.Size(68, 25);
            this.lbScorePart2.TabIndex = 1;
            this.lbScorePart2.Text = "Score";
            // 
            // lbResult2
            // 
            this.lbResult2.AutoSize = true;
            this.lbResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult2.Location = new System.Drawing.Point(451, 50);
            this.lbResult2.Name = "lbResult2";
            this.lbResult2.Size = new System.Drawing.Size(140, 39);
            this.lbResult2.TabIndex = 2;
            this.lbResult2.Text = "SCORE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-529, -213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1278, 806);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbQuote
            // 
            this.lbQuote.AutoSize = true;
            this.lbQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuote.Location = new System.Drawing.Point(326, 240);
            this.lbQuote.Name = "lbQuote";
            this.lbQuote.Size = new System.Drawing.Size(322, 29);
            this.lbQuote.TabIndex = 5;
            this.lbQuote.Text = "\"La peine emplie mon coeur\"";
            this.lbQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultatsPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.lbQuote);
            this.Controls.Add(this.lbResult2);
            this.Controls.Add(this.lbScorePart2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultatsPart2";
            this.Text = "ResultatsPart2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbScorePart2;
        private System.Windows.Forms.Label lbResult2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbQuote;
    }
}