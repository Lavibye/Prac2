﻿namespace Prac2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗМасивамиToolStripMenuItem,
            this.unitTestToolStripMenuItem,
            this.файлиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            this.роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірніМасивиToolStripMenuItem,
            this.двовимірніМасивиToolStripMenuItem});
            this.роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            this.роботаЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            this.одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            this.одновимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            this.одновимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.одновимірніМасивиToolStripMenuItem_Click);
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            this.двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            this.двовимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            this.двовимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.двовимірніМасивиToolStripMenuItem_Click);
            // 
            // unitTestToolStripMenuItem
            // 
            this.unitTestToolStripMenuItem.Name = "unitTestToolStripMenuItem";
            this.unitTestToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.unitTestToolStripMenuItem.Text = "UnitTest";
            this.unitTestToolStripMenuItem.Click += new System.EventHandler(this.unitTestToolStripMenuItem_Click);
            // 
            // файлиToolStripMenuItem
            // 
            this.файлиToolStripMenuItem.Name = "файлиToolStripMenuItem";
            this.файлиToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.файлиToolStripMenuItem.Text = "Файли";
            this.файлиToolStripMenuItem.Click += new System.EventHandler(this.файлиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлиToolStripMenuItem;
    }
}

