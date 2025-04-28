using System;
using System.Windows.Forms;

namespace Manga_Books 
{
    public partial class MangaBooks : Form
    {
        public MangaBooks() 
        {
            InitializeComponent();
        }

        // Manga Class with properties and methods
        public class Manga 
        {
            // Private for perpartion time in minutes
            private int prepTimeMinutes;

            // Properties for Manga Class
            public string Name {  get; set; }
            public string Category { get; set; }
            public bool HasManyPages { get; set; }
            public string Author { get; set; }


            // This is the Property for PrepTime validation meaning conform it
            public int PrepTime
            {
                get { return prepTimeMinutes; }
                set
                {
                    if (value > 0)
                    {
                        // Be sure to accpect positive values only
                        prepTimeMinutes = value;
                    }
                    else 
                    {
                        // Default to 1 if input goes below 1 or less
                        prepTimeMinutes = 1;
                    }
                }
            }

            
            // Constructor that initializes Manga object with values
            public Manga(string name, string category, int prepTime, bool hasManyPages, string author) 
            {
                Name = name;
                Category = category;
                PrepTime = prepTime;
                HasManyPages = hasManyPages;
                Author = author;
            }

            // Method return a short summary of the manga
            public string GetSummary() 
            {
                return $"{Name} - {Category}";
            }

            // Method returns detailed information about manga
            public string GetDetails() 
            {
                // Returning values Name, Category, Pages, PrepTime, and Author of book
                return $"Title: {Name}\nCategory: {Category}\nPages: {(HasManyPages ? "Many" : "Few")}\n Prep Time: {PrepTime} mins\n Author: {Author}";
            }

        }

        // Load event that creates objects and displays to user
        private void MangaBooks_Load(object sender, EventArgs e) 
        {
            // Manga objects created
            Manga manga1 = new Manga("One Piece", "Adventure", 30, true, "Eiichiro Oda");
            Manga manga2 = new Manga("Black Bulter", "Mystery", 10, false, "Yana Toboso");

            // Display details of mangas to the label form
            lblMangaDetails.Text = manga1.GetDetails() + "\n\n" + manga2.GetDetails();
        }
    }
}