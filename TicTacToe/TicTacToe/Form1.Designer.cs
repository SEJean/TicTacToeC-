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
            this.label1 = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblXScore = new System.Windows.Forms.Label();
            this.lblOScore = new System.Windows.Forms.Label();
            this.grpScore.SuspendLayout();
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
            this.grpScore.Controls.Add(this.lblOScore);
            this.grpScore.Controls.Add(this.lblXScore);
            this.grpScore.Controls.Add(this.lblO);
            this.grpScore.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblO.Location = new System.Drawing.Point(6, 68);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(43, 39);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "O";
            // 
            // lblXScore
            // 
            this.lblXScore.AutoSize = true;
            this.lblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblXScore.Location = new System.Drawing.Point(109, 29);
            this.lblXScore.Name = "lblXScore";
            this.lblXScore.Size = new System.Drawing.Size(36, 39);
            this.lblXScore.TabIndex = 2;
            this.lblXScore.Text = "0";
            // 
            // lblOScore
            // 
            this.lblOScore.AutoSize = true;
            this.lblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblOScore.Location = new System.Drawing.Point(109, 68);
            this.lblOScore.Name = "lblOScore";
            this.lblOScore.Size = new System.Drawing.Size(36, 39);
            this.lblOScore.TabIndex = 3;
            this.lblOScore.Text = "0";
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
            this.grpScore.ResumeLayout(false);
            this.grpScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox grpScore;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblOScore;
        private System.Windows.Forms.Label lblXScore;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label label1;
    }
}

