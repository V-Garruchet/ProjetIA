namespace WindowsFormsApplication1
{
    partial class Resultats
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
            this.lbScore = new System.Windows.Forms.Label();
            this.lbRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(259, 136);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(126, 46);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "Score";
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRes.Location = new System.Drawing.Point(277, 215);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(90, 31);
            this.lbRes.TabIndex = 1;
            this.lbRes.Text = "NOTE";
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.lbScore);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Label lbRes;
    }
}