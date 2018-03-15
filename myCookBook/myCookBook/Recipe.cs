using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace myCookBook
{
    public class Recipe
    {
        #region fields
        private string name;
        private List<Ingredient> ingredients;
        private string instructions;

        //TAGS
        private bool sweet;
        private bool gameday;
        private bool comfort;
        private bool salad;
        private bool vegan;
        private bool slowcooker;
        private bool soups;
        private bool whole30;
        private bool glutenfree;
        private bool paleo;
        private bool vegetarian;
        private bool appetizer;
        private bool breakfast;
        private bool lunch;
        private bool dinner;

        private int recipeID;
        private string imagePath;
       
        #endregion

        #region constructors
        public Recipe(string n, List<Ingredient> i, string i2, bool SWEET, bool GAMEDAY, bool COMFORT, bool SALAD, bool VEGAN, bool SLOWCOOKER,bool SOUPS, bool WHOLE30, bool GLUTENFREE, bool PALEO, 
            bool VEGETARIAN, bool APPETIZER, int id, string ip, bool b, bool l, bool d2)
        {
            name = n;
            ingredients = i;
            instructions = i2;
            
            recipeID = id;
            imagePath = ip;

            //assign values to all the tags
            breakfast = b;
            lunch = l;
            dinner = d2;
            sweet = SWEET;
            comfort = COMFORT;
            salad = SALAD;
            vegan = VEGAN;
            slowcooker = SLOWCOOKER;
            soups = SOUPS;
            whole30 = WHOLE30;
            glutenfree = GLUTENFREE;
            paleo = PALEO;
            vegetarian = VEGETARIAN;
            appetizer = APPETIZER;
            gameday = GAMEDAY;
            
        }

        public Recipe()
        {
            name = "";
            ingredients = new List<Ingredient>();
            instructions = "";
            
            recipeID = 000000;
            breakfast = false;
            lunch = false;
            dinner = false;

        }
        public Recipe(Recipe r)
        {
            name = r.Name;
            ingredients = r.Ingredients;
            instructions = r.Instructions;
            
            recipeID = 0;
            imagePath = r.ImagePath;

           
            lunch = r.lunch;
            dinner = r.dinner;
            breakfast = r.breakfast;
           
            sweet = r.sweet;
            comfort = r.comfort;
            salad = r.salad;
            vegan = r.vegan;
            slowcooker = r.slowcooker;
            soups = r.soups;
            whole30 = r.soups;
            glutenfree = r.glutenfree;
            paleo = r.paleo;
            vegetarian = r.vegetarian;
            appetizer = r.appetizer;
            gameday = r.gameday;
        }
        #endregion

        #region setters/getters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    

        public int ID
        {
            get { return recipeID; }
            set { recipeID = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value.ToList(); }
        }

        public bool Breakfast
        {
            get { return breakfast; }
            set { breakfast = value; }
            
        }

        public bool Lunch
        {
            get { return lunch; }
            set { lunch = value; }
        }

        public bool Dinner
        {
            get { return dinner; }
            set { dinner = value; }
        }
        public bool Comfort
        {
            get { return comfort; }
            set { comfort = value; }
        }
        public bool Slowcooker
        {
            get { return slowcooker; }
            set { slowcooker = value; }
        }

        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        public bool Soups
        {
            get { return soups; }
            set { soups = value; }
        }
        public bool Salad
        {
            get { return salad; }
            set { salad = value; }
        }
        public bool Whole30
        {
            get { return whole30; }
            set { whole30 = value; }
        }
        public bool Vegan
        {
            get { return vegan; }
            set { vegan = value; }
        }

        public bool Vegetarian
        {
            get { return vegetarian; }
            set { vegetarian = value; }
        }

        public bool Paleo
        {
            get { return paleo; }
            set { paleo = value; }
        }

        public bool Appetizer
        {
            get { return appetizer; }
            set { appetizer = value; }
        }

        public bool Gameday
        {
            get { return gameday; }
            set { gameday = value; }
        }

        public bool Glutenfree
        {
            get { return glutenfree; }
            set { glutenfree = value; }
        }
        #endregion

        #region methods
        public void save(XmlWriter writer)
        {
            writer.WriteStartElement("Recipe");

            writer.WriteElementString("Name",name);

            writer.WriteStartElement("Ingredients");

            foreach(Ingredient i in ingredients)
            {
                writer.WriteStartElement("Ingredient");
                writer.WriteElementString("IngredientName", i.Name);
                writer.WriteElementString("IngredientAmount", i.Amount);
                writer.WriteElementString("IngredientUnit", i.Unit);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //tags
            writer.WriteElementString("Breakfast", breakfast.ToString());
            writer.WriteElementString("Lunch", lunch.ToString());
            writer.WriteElementString("Dinner", dinner.ToString());
            writer.WriteElementString("Gameday", gameday.ToString());
            writer.WriteElementString("Comfort", comfort.ToString());
            writer.WriteElementString("Sweet", sweet.ToString());
            writer.WriteElementString("Slowcooker", slowcooker.ToString());
            writer.WriteElementString("Paleo", paleo.ToString());
            writer.WriteElementString("Vegan", vegan.ToString());
            writer.WriteElementString("Vegetarian", vegetarian.ToString());
            writer.WriteElementString("Salad", salad.ToString());
            writer.WriteElementString("Soup", soups.ToString());
            writer.WriteElementString("Whole30", whole30.ToString());
            writer.WriteElementString("Appetizer", appetizer.ToString());
            writer.WriteElementString("Glutenfree", glutenfree.ToString());

            //rest of stuff needed to create recipe
            writer.WriteElementString("RecipeID", recipeID.ToString());
            writer.WriteElementString("ImagePath", imagePath);
            writer.WriteElementString("Instructions", instructions);
            writer.WriteEndElement();
        }

       
        #endregion

    }
}
