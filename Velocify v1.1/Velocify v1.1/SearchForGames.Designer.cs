﻿namespace Velocify_v1._1
{
    partial class SearchForGames
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            gamesListBox = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(680, 397);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(562, 397);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Search"; 
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 397);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // 
            // gamesListBox (Game List Box)
            // 
            gamesListBox.Location = new Point(12, 50); // Position above the text box
            gamesListBox.Name = "gamesListBox";
            gamesListBox.Size = new Size(780, 340); // Adjust size as needed
            gamesListBox.TabIndex = 3;
            // 
            // SearchForGames
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gamesListBox); 
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SearchForGames";
            Text = "Search For Games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox gamesListBox;
    }
}