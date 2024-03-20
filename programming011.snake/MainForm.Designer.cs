namespace programming011.snake
{
    partial class frmMain
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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pnlGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackColor = System.Drawing.Color.Gray;
            this.pnlGameBoard.Controls.Add(this.lblGameOver);
            this.pnlGameBoard.Location = new System.Drawing.Point(43, 35);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(422, 442);
            this.pnlGameBoard.TabIndex = 0;
            this.pnlGameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGameBoard_Paint);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGameOver.Location = new System.Drawing.Point(109, 159);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(229, 39);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "Game Over😱";
            this.lblGameOver.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 507);
            this.Controls.Add(this.pnlGameBoard);
            this.Name = "frmMain";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.pnlGameBoard.ResumeLayout(false);
            this.pnlGameBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Label lblGameOver;
    }
}