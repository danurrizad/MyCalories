using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCalories
{
    public class Food
    {
        //Fields ------------------
        private int _id;
        private string _name;
        private string _description;
        private float _calories;
        private float _portion;
        private float _carbohydrate;
        private float _sugar;
        private float _fat;

        // Properties ------------------
        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public float Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }
        
        public float Portion 
        {
            get { return _portion; }  
            set { _portion = value; } 
        }

        public float Carbohydrate
        {
            get { return _carbohydrate; }
            set { _carbohydrate = value; }
        }

        public float Sugar
        {
            get { return _sugar; }
            set { _sugar = value; }
        }

        public float Fat
        {
            get { return _fat; }
            set { _fat = value; }
        }

        // Methods ------------------
        public Dictionary<string, Food> GetNutritionFacts()
        {
            Dictionary<string, Food> nutritionFacts = new Dictionary<string, Food>();

            // code here

            return nutritionFacts;
        }

        public void AddFood()
        {

        }

        public void EditFood()
        {

        }

        public void DeleteFood()
        {

        }

        public void SearchFood()
        {

        }
    }
}
