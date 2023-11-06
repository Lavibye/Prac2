namespace Prac2
{
    partial class File
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
            this.textBoxXCoordinates = new System.Windows.Forms.TextBox();
            this.textBoxYCoordinates = new System.Windows.Forms.TextBox();
            this.buttonEnterCoordinates = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // textBoxXCoordinates
            // 
            this.textBoxXCoordinates.Location = new System.Drawing.Point(155, 60);
            this.textBoxXCoordinates.Name = "textBoxXCoordinates";
            this.textBoxXCoordinates.Size = new System.Drawing.Size(141, 20);
            this.textBoxXCoordinates.TabIndex = 2;
            // 
            // textBoxYCoordinates
            // 
            this.textBoxYCoordinates.Location = new System.Drawing.Point(155, 106);
            this.textBoxYCoordinates.Name = "textBoxYCoordinates";
            this.textBoxYCoordinates.Size = new System.Drawing.Size(141, 20);
            this.textBoxYCoordinates.TabIndex = 3;
            // 
            // buttonEnterCoordinates
            // 
            this.buttonEnterCoordinates.Location = new System.Drawing.Point(109, 167);
            this.buttonEnterCoordinates.Name = "buttonEnterCoordinates";
            this.buttonEnterCoordinates.Size = new System.Drawing.Size(75, 23);
            this.buttonEnterCoordinates.TabIndex = 4;
            this.buttonEnterCoordinates.Text = "Вручну";
            this.buttonEnterCoordinates.UseVisualStyleBackColor = true;
            this.buttonEnterCoordinates.Click += new System.EventHandler(this.buttonEnterCoordinates_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(221, 167);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFromFile.TabIndex = 5;
            this.buttonLoadFromFile.Text = "З файлу";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click_1);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(375, 60);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(16, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "...";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(375, 113);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(16, 13);
            this.labelCoordinates.TabIndex = 7;
            this.labelCoordinates.Text = "...";
            // 
            // File
            // 
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonEnterCoordinates);
            this.Controls.Add(this.textBoxYCoordinates);
            this.Controls.Add(this.textBoxXCoordinates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXCoordinates;
        private System.Windows.Forms.TextBox textBoxYCoordinates;
        private System.Windows.Forms.Button buttonEnterCoordinates;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelCoordinates;
    }
}