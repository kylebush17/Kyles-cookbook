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
    public class cookBook
    {
        private List<Recipe> recipeList;
        private int id;
        public cookBook()
        {
            recipeList = new List<Recipe>();
            id = 0;
        }

        public bool save(Stream stream)
        {
            //no recipes, nothing to save, return.
            if (recipeList.Count <= 0)
                return false;

            XmlDocument doc = new XmlDocument();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.NewLineChars = "\r\n";
            settings.NewLineOnAttributes = true;
            settings.Indent = true;
            
            XmlWriter writer = XmlWriter.Create(stream, settings);


            if (writer != null)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("CookBook");

                foreach (Recipe r in recipeList)
                {
                    r.save(writer);
                }
                
                writer.WriteEndElement();
                writer.Close();
                return true;
            }
            return false;
        }

        public bool load(Stream stream)
        {

            XDocument doc = null;
            try
            {
                doc = XDocument.Load(stream);
            }
            catch(Exception)
            {
                return false;
            }

            XElement root = doc.Root; //get the root of the xml doc

            foreach(XElement child in root.Elements("Recipe"))//for all recipes
            {
                
                //get the name
                var name = child.Element("Name").Value;

                //get the ingredients tag
                XElement ingredients = child.Element("Ingredients");

                //now get each individual ingredient
                List<Ingredient> temp = new List<Ingredient>();
                foreach (XElement ingredient in ingredients.Elements("Ingredient"))
                {
                    var ingredientName = ingredient.Element("IngredientName").Value;
                    var ingredientAmount = ingredient.Element("IngredientAmount").Value;
                    var ingredientUnit = ingredient.Element("IngredientUnit").Value;

                    Ingredient i = new Ingredient(ingredientName, ingredientAmount, ingredientUnit);
                    temp.Add(i);
                }

                bool b = false, l = false, d = false , s = false, so = false, sc = false, c = false, sal = false, 
                    w = false, veg = false, v = false, gf = false, p = false, a = false, gd = false;
                //have all ingredients. now get rest of information.
                var instructions = child.Element("Instructions").Value;
                
                var recipeID = child.Element("RecipeID").Value;
                var imagePath = child.Element("ImagePath").Value;

                var lunch = child.Element("Lunch").Value;
                var bfast = child.Element("Breakfast").Value;
                var din = child.Element("Dinner").Value;
                var sweet = child.Element("Sweet").Value;
                var slowcooker = child.Element("Slowcooker").Value;
                var comfort = child.Element("Comfort").Value;
                var soups = child.Element("Soup").Value;
                var salad = child.Element("Salad").Value;
                var whole30 = child.Element("Whole30").Value;
                var vegan = child.Element("Vegan").Value;
                var vegetarian = child.Element("Vegetarian").Value;
                var glutenfree = child.Element("Glutenfree").Value;
                var paleo = child.Element("Paleo").Value;
                var appetizer = child.Element("Appetizer").Value;
                var gameday = child.Element("Gameday").Value;
                

                //assign boolean values for all of the tags
                if (lunch == "True")
                    l = true;               
                if (bfast == "True")
                    b = true;
                if (din == "True")
                    d = true;
                if (sweet == "True")
                    s = true;
                if (slowcooker == "True")
                    sc = true;
                if (comfort == "True")
                    c = true;
                if (soups == "True")
                    so = true;
                if (salad == "True")
                    sal = true;
                if (whole30 == "True")
                    w = true;
                if (vegan == "True")
                    v = true;
                if (vegetarian == "True")
                    veg = true;
                if (glutenfree == "True")
                    gf = true;
                if (paleo == "True")
                    p = true;
                if (appetizer == "True")
                    a = true;
                if (gameday == "True")
                    gd = true;

                Recipe r = new Recipe(name, temp, instructions,s,gd,c,sal,v,sc,so,w,gf,p,veg,a 
                    ,Convert.ToInt32(recipeID), imagePath,b, l,d);
                recipeList.Add(r);
                

            }
            return true;
        }

        public bool insertRecipe(Recipe r)
        {
            recipeList.Add(r);
            return true;
        }

        public List<Recipe> Recipes
        {
            get { return recipeList; }
            set { recipeList = value; }
        }

        public Recipe findRecipe(string rName)
        {

            foreach(Recipe r in recipeList)
            {
                if(r.Name == rName)
                {
                    
                    return r;
                }

            }
            return null;
        }
    }
}
