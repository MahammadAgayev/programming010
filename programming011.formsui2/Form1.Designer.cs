namespace programming011.formsui2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPending = new System.Windows.Forms.ComboBox();
            this.cbxInProcess = new System.Windows.Forms.ComboBox();
            this.cbxDone = new System.Windows.Forms.ComboBox();
            this.btnPendingToProcess = new System.Windows.Forms.Button();
            this.btnProcessToPending = new System.Windows.Forms.Button();
            this.btnDoneToProces = new System.Windows.Forms.Button();
            this.btnProcessToDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do list App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Done";
            // 
            // cbxPending
            // 
            this.cbxPending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxPending.FormattingEnabled = true;
            this.cbxPending.Items.AddRange(new object[] {
            "E2E Doc",
            "Project Infrastructure Doc",
            "Overprovision alert",
            "Loki on Apps"});
            this.cbxPending.Location = new System.Drawing.Point(48, 158);
            this.cbxPending.Name = "cbxPending";
            this.cbxPending.Size = new System.Drawing.Size(121, 344);
            this.cbxPending.TabIndex = 4;
            this.cbxPending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxPending_PreviewKeyDown);
            // 
            // cbxInProcess
            // 
            this.cbxInProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxInProcess.FormattingEnabled = true;
            this.cbxInProcess.Location = new System.Drawing.Point(236, 158);
            this.cbxInProcess.Name = "cbxInProcess";
            this.cbxInProcess.Size = new System.Drawing.Size(121, 344);
            this.cbxInProcess.TabIndex = 5;
            this.cbxInProcess.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxInProcess_PreviewKeyDown);
            // 
            // cbxDone
            // 
            this.cbxDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxDone.FormattingEnabled = true;
            this.cbxDone.Location = new System.Drawing.Point(427, 158);
            this.cbxDone.Name = "cbxDone";
            this.cbxDone.Size = new System.Drawing.Size(121, 344);
            this.cbxDone.TabIndex = 6;
            this.cbxDone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxDone_PreviewKeyDown);
            // 
            // btnPendingToProcess
            // 
            this.btnPendingToProcess.Location = new System.Drawing.Point(178, 261);
            this.btnPendingToProcess.Name = "btnPendingToProcess";
            this.btnPendingToProcess.Size = new System.Drawing.Size(42, 40);
            this.btnPendingToProcess.TabIndex = 7;
            this.btnPendingToProcess.Text = ">>";
            this.btnPendingToProcess.UseVisualStyleBackColor = true;
            this.btnPendingToProcess.Click += new System.EventHandler(this.btnPendingToProcess_Click);
            // 
            // btnProcessToPending
            // 
            this.btnProcessToPending.Location = new System.Drawing.Point(178, 307);
            this.btnProcessToPending.Name = "btnProcessToPending";
            this.btnProcessToPending.Size = new System.Drawing.Size(42, 40);
            this.btnProcessToPending.TabIndex = 8;
            this.btnProcessToPending.Text = "<<";
            this.btnProcessToPending.UseVisualStyleBackColor = true;
            this.btnProcessToPending.Click += new System.EventHandler(this.btnProcessToPending_Click);
            // 
            // btnDoneToProces
            // 
            this.btnDoneToProces.Location = new System.Drawing.Point(376, 307);
            this.btnDoneToProces.Name = "btnDoneToProces";
            this.btnDoneToProces.Size = new System.Drawing.Size(42, 40);
            this.btnDoneToProces.TabIndex = 10;
            this.btnDoneToProces.Text = "<<";
            this.btnDoneToProces.UseVisualStyleBackColor = true;
            this.btnDoneToProces.Click += new System.EventHandler(this.btnDoneToProces_Click);
            // 
            // btnProcessToDone
            // 
            this.btnProcessToDone.Location = new System.Drawing.Point(376, 261);
            this.btnProcessToDone.Name = "btnProcessToDone";
            this.btnProcessToDone.Size = new System.Drawing.Size(42, 40);
            this.btnProcessToDone.TabIndex = 9;
            this.btnProcessToDone.Text = ">>";
            this.btnProcessToDone.UseVisualStyleBackColor = true;
            this.btnProcessToDone.Click += new System.EventHandler(this.btnProcessToDone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 523);
            this.Controls.Add(this.btnDoneToProces);
            this.Controls.Add(this.btnProcessToDone);
            this.Controls.Add(this.btnProcessToPending);
            this.Controls.Add(this.btnPendingToProcess);
            this.Controls.Add(this.cbxDone);
            this.Controls.Add(this.cbxInProcess);
            this.Controls.Add(this.cbxPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To do App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPending;
        private System.Windows.Forms.ComboBox cbxInProcess;
        private System.Windows.Forms.ComboBox cbxDone;
        private System.Windows.Forms.Button btnPendingToProcess;
        private System.Windows.Forms.Button btnProcessToPending;
        private System.Windows.Forms.Button btnDoneToProces;
        private System.Windows.Forms.Button btnProcessToDone;
    }
}

