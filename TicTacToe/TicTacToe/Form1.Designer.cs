namespace TicTacToe
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grpScore = new System.Windows.Forms.GroupBox();
            this.btnReplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Location = new System.Drawing.Point(12, 31);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(239, 246);
            this.pnlGrid.TabIndex = 0;
            this.pnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrid_Paint);
            // 
            // grpScore
            // 
            this.grpScore.Location = new System.Drawing.Point(288, 31);
            this.grpScore.Name = "grpScore";
            this.grpScore.Size = new System.Drawing.Size(200, 185);
            this.grpScore.TabIndex = 1;
            this.grpScore.TabStop = false;
            this.grpScore.Text = "Score";
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(288, 223);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(200, 54);
            this.btnReplay.TabIndex = 2;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 299);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.grpScore);
            this.Controls.Add(this.pnlGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox grpScore;
        private System.Windows.Forms.Button btnReplay;
    }
}

