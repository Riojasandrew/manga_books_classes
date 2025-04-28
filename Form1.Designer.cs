namespace Manga_Books
{
    partial class MangaBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMangaDetails = new Label();
            SuspendLayout();
            // 
            // lblMangaDetails
            // 
            lblMangaDetails.AutoSize = true;
            lblMangaDetails.Location = new Point(288, 132);
            lblMangaDetails.Name = "lblMangaDetails";
            lblMangaDetails.Size = new Size(0, 15);
            lblMangaDetails.TabIndex = 0;
            // 
            // MangaBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMangaDetails);
            Name = "MangaBooks";
            Text = "Books";
            Load += MangaBooks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMangaDetails;
    }
}
