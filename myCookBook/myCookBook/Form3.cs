using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myCookBook
{
    public partial class Form3 : Form
    {

        public static cookBook cb = new cookBook();
        public Recipe current;

        public void update()
        {

           //add any necessary recipes into the listbox

            //EDIT: might need to fix this. for a large amount of recipes, this is horribly inefficient.

            //does not make much sense to add all recipes and remove based on filter. will investigate.
           foreach (Recipe r in cb.Recipes)
           {
                if (!listBox1.Items.Contains(r.Name.ToString()))
                 {
                        listBox1.Items.Add(r.Name.ToString());
                 }
           }

           //check to see if there is a filter to be applied
           if(Filter.SelectedIndex != -1)
            {

                //for breakfast
                if (Filter.SelectedItem.ToString() == "Breakfast")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Breakfast == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //for lunch
                else if (Filter.SelectedItem.ToString() == "Lunch")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Lunch == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //for dinner
                else if (Filter.SelectedItem.ToString() == "Dinner")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Dinner == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //for sweets
                else if (Filter.SelectedItem.ToString() == "Sweet Treats")
                {
                    foreach(Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach(var str in listBox1.Items)
                        {
                            if(r.Name == str.ToString() && r.Sweet == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //Game day foods
                else if (Filter.SelectedItem.ToString() == "Gameday Foods")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Gameday == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //Comfort foods
                else if (Filter.SelectedItem.ToString() == "Comfort Food")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Comfort == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }


                //Salads
                else if (Filter.SelectedItem.ToString() == "Salads")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Salad == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }


                //vegan
                else if (Filter.SelectedItem.ToString() == "Paleo")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Paleo == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                //vegetarian
                else if (Filter.SelectedItem.ToString() == "Vegetarian")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Vegetarian == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }


                //vegan
                else if (Filter.SelectedItem.ToString() == "Vegan")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Vegan == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }


                else if (Filter.SelectedItem.ToString() == "Slowcooker")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Slowcooker == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                else if (Filter.SelectedItem.ToString() == "Whole30 Approved")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Whole30 == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                else if (Filter.SelectedItem.ToString() == "Gluten-free")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Glutenfree == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }


                else if (Filter.SelectedItem.ToString() == "Soups")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Soups == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }

                else if (Filter.SelectedItem.ToString() == "Appetizers")
                {
                    foreach (Recipe r in cb.Recipes)
                    {
                        int i = 0;
                        foreach (var str in listBox1.Items)
                        {
                            if (r.Name == str.ToString() && r.Appetizer == false)
                            {
                                listBox1.Items.RemoveAt(i);
                                break;
                            }
                            i++;
                        }
                    }
                }
            }

           //done dealing with filters

           
            


            //if something is selected, update it. if not, no need
            if (listBox1.SelectedItems.Count > 0)
            {
                approvedByBox.Clear();

                recipeNameLabel.Text = current.Name;
                ingredientsList.Items.Clear();

                instructionsBox.Text = current.Instructions;

                foreach(Ingredient i in current.Ingredients)
                {
                    ingredientsList.Items.Add(i.Amount + " " + i.Unit + " " + i.Name);
                }


                //need to add the tags
                if (current.Breakfast)
                    approvedByBox.Text += "Breakfast, ";
                if (current.Lunch)
                    approvedByBox.Text += "Lunch, ";
                if (current.Dinner)
                    approvedByBox.Text += "Dinner, ";
                if (current.Sweet)
                    approvedByBox.Text += "Sweet Treat,";
                if (current.Slowcooker)
                    approvedByBox.Text += "Slow Cooker, ";
                if (current.Salad)
                    approvedByBox.Text += "Salad, ";
                if (current.Whole30)
                    approvedByBox.Text += "Whole30, ";
                if (current.Glutenfree)
                    approvedByBox.Text += "Gluten-free, ";
                if (current.Soups)
                    approvedByBox.Text += "Soup, ";
                if (current.Vegan)
                    approvedByBox.Text += "Vegan, ";
                if (current.Vegetarian)
                    approvedByBox.Text += "Vegetarian, ";
                if (current.Gameday)
                    approvedByBox.Text += "Gameday food, ";
                if (current.Appetizer)
                    approvedByBox.Text += "Appetizer, ";
                if (current.Paleo)
                    approvedByBox.Text += "Paleo, ";
                if (current.Comfort)
                    approvedByBox.Text += "Comfort food, ";




                string path = "Images/" + current.Name + ".jpg";
                Image image = Image.FromFile(path);
                recipePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                recipePicture.Image = image;

                ingredientsLabel.Visible = true;
                ingredientsList.Visible = true;
                recipeNameLabel.Visible = true;
                approvedByBox.Visible = true;
                approvedLabel.Visible = true;
                instructionsLabel.Visible = true;
                instructionsBox.Visible = true;
                recipePicture.Visible = true; 

            }
        }

        public Form3()
        {
            this.FormClosing += new FormClosingEventHandler(FormClosing_3);
            this.FormClosed += new FormClosedEventHandler(FormClosed_3);
            this.Load += new System.EventHandler(this.Form3_Load);
            
            InitializeComponent();

          
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Stream stream = new FileStream("cookbook.xml", FileMode.Open, FileAccess.Read);
            cb.load(stream);
            stream.Close();
          
            update();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Recipe r;

            //guard code to see if there is a valid index selected
            if (listBox1.SelectedIndex != -1)
            {
                r = new Recipe(cb.findRecipe(listBox1.SelectedItem.ToString())); //search through recipes in cookbook to find specific name;

                if (r != null)
                {
                    current = r;
                    update();
                }
                else
                {
                    update();
                }
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newRecipe = new Form4(ref cb);
            DialogResult dr = DialogResult.None;
            while (dr!= DialogResult.OK && dr != DialogResult.Cancel) { dr = newRecipe.ShowDialog(); };
            if (newRecipe.Recipe != null)
            {
                cb.insertRecipe(newRecipe.Recipe);
                update();
                
            }
            newRecipe.Close();

        }

        private void FormClosing_3(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            Stream stream = new FileStream("cookbook.xml", FileMode.OpenOrCreate, FileAccess.Write);
            cb.save(stream);
            Environment.Exit(0);

        }

        private void FormClosed_3(object sender, FormClosedEventArgs e)
        {
            //Things when closed
            Application.Exit();
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //clear the items so that we can sort them properly

            //now we need to re order the list of recipes...
            if (Filter.SelectedItem.ToString() == "Name") 
                cb.Recipes = cb.Recipes.OrderBy(Recipe => Recipe.Name).ToList();

           
            

            update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                update();
               
            }
            List<string> listBox = new List<string>();
            foreach (string i in listBox1.Items)
            {
                string cpy = i.ToLower();

                if (cpy.Contains(textBox1.Text.ToLower()))
                {
                    listBox.Add(i);
                }
            }

            listBox1.Items.Clear();

            foreach(string i in listBox)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SEARCH
            foreach(string i in listBox1.Items)
            {
                string cpy = i.ToLower();
                
                if(cpy.Contains(textBox1.Text))
                {
                    listBox1.SelectedItem = i;
                    break;
                }
            }
        }

        //HELP TAB
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hello! Welcome to Kyle's Cookbook, a digital cookbook for you to store all of your favorite recipes!\n\nHere are a few things you should know:\n\n1. Kyle's Cookbook comes preloaded with some of the creator's favorite recipes for you to try.\n\n2. You are free to create your own recipes as you wish using the 'NEW+' button in the lower right corner, they will be saved. (Wow!)\n\n3. The 'Filter By' menu in the top left can be used to filter the recipes shown by several categories such as Appetizers, Comfort Foods, and much more!\n\n4. The search bar and button in the bottom left will perform dynamic searches based on what you are typing, as you are typing it (pretty cool huh?). Pressing 'search' will select your search if there is an exact match\n\n5. Perhaps the most important feature: the recipe box. Located on the left edge of the app, this allows you to select recipes in the box that will be displayed on the right half of the application.\n\n\n\nDISCLAIMER: Kyle's Cookbook does NOT own any of the images associated with recipes featured in this program.\n\n Happy cooking!\n\n-KB");

        }

        //CHANGE NOTES
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("***MAKE SURE TO VIEW GITHUB FOR UPDATES***\n\nVERSION 1.0: Released March 12th, 2018\nIncludes basic features to create recipes and view recipes.");
        }
    }
}
