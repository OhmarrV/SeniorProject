namespace Velocify_v1._1
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
            addBtn = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            gamesListBox = new ListBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.Location = new Point(319, 238);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(78, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(236, 238);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 23);
            button2.TabIndex = 1;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 238);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for Game Name or IGDB ID";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // gamesListBox
            // 
            gamesListBox.ItemHeight = 15;
            gamesListBox.Location = new Point(8, 30);
            gamesListBox.Margin = new Padding(2);
            gamesListBox.Name = "gamesListBox";
            gamesListBox.Size = new Size(384, 199);
            gamesListBox.TabIndex = 3;
            // 
            // SearchForGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 270);
            Controls.Add(gamesListBox);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(addBtn);
            Margin = new Padding(2);
            MaximumSize = new Size(419, 309);
            MinimumSize = new Size(419, 309);
            Name = "SearchForGames";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Search For Games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Button button2;
        private TextBox textBox1;
        private ListBox gamesListBox;
    }
}