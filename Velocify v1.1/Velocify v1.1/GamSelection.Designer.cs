using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class GameSelection : UserControl  // Keep the class name consistent
    {
        private System.Windows.Forms.ListBox gamesListBox;  // Declare the ListBox here, no need in the main class

        private void InitializeComponent()
        {
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // gamesListBox
            // 
            this.gamesListBox.Location = new System.Drawing.Point(10, 10);
            this.gamesListBox.Size = new System.Drawing.Size(180, 200);
            this.Controls.Add(this.gamesListBox);  // Add gamesListBox to the UserControl

            // 
            // GameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(200, 250);  // Adjust control size as necessary
            this.ResumeLayout(false);
        }
    }
}
