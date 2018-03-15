using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myCookBook
{
    public partial class Form4 : Form
    {
        string path = "";
        //create a new recipe, add it to the cookbook
        string name = "";
        List<Ingredient> ingredients = new List<Ingredient>();
        string instructions = "";
        
        int recipeID = 00000;
        
        Recipe r;

        public Form4(ref cookBook cb)
        {
            
            InitializeComponent();
        }

        //button to select an image for the recipe to be inserted
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormClosing_4);
            
            

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                imagePath.Text = path;
                Image image = Image.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;

                
            }
        }

        //step 2 'next' button
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            label7.Show();
            label8.Show();
            button1.Show();
            button5.Show();
            textBox1.ReadOnly = true;
            button4.Enabled = false;
            
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Show();
            label10.Show();
            richTextBox1.Show();
            button6.Show();
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            button5.Enabled = false;
            button1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label14.Visible = true;
            label15.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox8.Visible = true;
            checkBox7.Visible = true;
            checkBox9.Visible = true;
            checkBox11.Visible = true;
            checkBox10.Visible = true;
            checkBox13.Visible = true;
            checkBox12.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = true;
            button8.Visible = true;
            richTextBox1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label13.Show();
            imagePath.Show();
          
            button2.Show();
            
        }

        //FINISH button is pressed

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            

            //set values based on form
            name = textBox1.Text;
            instructions = richTextBox1.Text.ToString();
            
            path = imagePath.Text;

            bool breakfast = false, lunch = false, dinner = false, sweet = false, comfort = false, slowcooker = false, soups = false, salad = false, 
                whole30 = false, vegan = false, glutenfree = false, paleo = false, vegetarian = false, appetizer = false, gameday = false;

            if(checkBox2.Checked)
            {
                dinner = true;
            }
            if(checkBox1.Checked)
            {
                lunch = true;
            }
            if(checkBox3.Checked)
            {
                breakfast = true;
            }

            if (checkBox4.Checked)
            {
                sweet = true;
            }
            if (checkBox5.Checked)
            {
               gameday = true;
            }
            if (checkBox6.Checked)
            {
                comfort = true;
            }
            if (checkBox7.Checked)
            {
                soups = true;
            }
            if (checkBox8.Checked)
            {
                salad = true;
            }
            if (checkBox9.Checked)
            {
                slowcooker = true;
            }
            if (checkBox10.Checked)
            {
                paleo = true;
            }
            if(checkBox11.Checked)
            {
                vegetarian = true;
            }
            if (checkBox12.Checked)
            {
                vegan = true;
            }
            if (checkBox13.Checked)
            {
                appetizer = true;
            }
            if (checkBox14.Checked)
            {
                glutenfree = true;
            }
            if (checkBox15.Checked)
            {
                whole30 = true;
            }


            r = new Recipe(name, ingredients, instructions, sweet, gameday, comfort, salad, vegan,
                slowcooker, soups, whole30, glutenfree, paleo, vegetarian, appetizer, recipeID, "Images/" + name + ".jpg",breakfast,lunch,dinner );

            //if any of the required boxes are empty, display a messagebox and a red label on the pieces that need updating
            if (textBox1.Text == "" || richTextBox1.Text.ToString() == "" || ingredients.Count == 0 ||path == "" ||(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked&& !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked
                &&!checkBox7.Checked && !checkBox8.Checked &&!checkBox9.Checked &&!checkBox10.Checked &&!checkBox11.Checked &&!checkBox12.Checked &&!checkBox13.Checked &&!checkBox14.Checked && !checkBox15.Checked))
            {
                MessageBox.Show("You need to fill in all boxes and add at least one ingredient before proceeding");

                if(textBox1.Text == "")//get name
                {
                    label2.ForeColor = Color.Red;
                    textBox1.ReadOnly = false;
                    button4.Enabled = true;
                }
                if(richTextBox1.Text.ToString() == "")//get instructions
                {
                    label9.ForeColor = Color.Red;
                    richTextBox1.Enabled = true;
                    richTextBox1.ReadOnly = false;
                    button6.Enabled = true;
                }
                if(ingredients.Count == 0)//need more ingredients
                {
                    label3.ForeColor = Color.Red;
                    button1.Enabled = true;
                    button5.Enabled = true;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                }

               
                if(path == "") //need to specify an image path
                {
                    label13.ForeColor = Color.Red;
                    button2.Enabled = true;
                }

                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked
                && !checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked && !checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked 
                && !checkBox13.Checked && !checkBox14.Checked && !checkBox15.Checked)
                {
                    button8.Enabled = true;
                    label14.ForeColor = Color.Red;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox13.Enabled = true;
                    checkBox12.Enabled = true;
                    checkBox14.Enabled = true;
                    checkBox15.Enabled = true;

                }
                   
                this.DialogResult = DialogResult.None;
            }

            else
            {
                System.IO.File.Copy(path, "Images/" + name + ".jpg");
                this.DialogResult = DialogResult.OK;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ingredient i = new Ingredient(textBox2.Text, textBox3.Text, textBox4.Text);
            ingredients.Add(i);
            textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            this.DialogResult = DialogResult.None;

        }

        public Recipe Recipe
        {
            get { return r; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
            button6.Enabled = false;
            label13.Visible = true;
            imagePath.Visible = true;
            button2.Visible = true;
            button8.Enabled = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;        
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox8.Enabled = false;
            checkBox7.Enabled = false;
            checkBox9.Enabled = false;
            checkBox11.Enabled = false;
            checkBox10.Enabled = false;
            checkBox13.Enabled = false;
            checkBox12.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;

        }

        private void FormClosing_4(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}
