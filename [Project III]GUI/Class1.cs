using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Net.Security;
using System.Collections.ObjectModel;
using System.Web;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace _Project_III_GUI
{
    internal class FoodItem
    {
        public int item_id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }

        public FoodItem()
        {
            item_id = 0;
            name = null;
            price = 0;
            quantity = 0;
        }
        public FoodItem(int ID, string Food, float price, int amount)
        {
            //This is the constructor for a normal food item where all parameters are passed
            //Under normal circumstances this constructor should not be used.
            this.item_id = ID;
            this.name = Food;
            this.price = price;
            this.quantity = amount;
        }
        public FoodItem(int itemIdentifier, int amount)
        {
            List<FoodItem> MenuItems = new List<FoodItem>();

            //THis is the constructor for fooditems by retrieving the data from a separate file.
            //Under ideal circumstances this is the constructor that should be called always.
            using (StreamReader r = new StreamReader("Menu.json"))
            {
                //Read the information of the menu.
                string json = r.ReadToEnd();
                MenuItems = JsonSerializer.Deserialize<List<FoodItem>>(json);
            }
            //Check for errors
            if(MenuItems == null || MenuItems.Count == 0)
            {
                //Something bad has happened
                item_id = -1;
                name = null;
                price = -1;
                quantity = -1;
                return;
            }

            //look through the list of fooditems for the item that has the same item identifier assed as a parameter
            foreach (var FoodItem in MenuItems)
            {
                if (FoodItem.GetID() == itemIdentifier)
                {
                    //Copy the information of the menu item to an actual object
                    this.quantity = amount;
                    this.price = FoodItem.price;
                    this.name = FoodItem.name;
                    this.item_id = itemIdentifier;
                    return;
                }
            }
            //If the code didn't find thefooditem object with an identical itemidentifier than return an error object
            item_id = -1;
            name = null;
            price = -1;
            quantity = -1;
            return;

        }
        public int GetID()
        {
            return item_id;
        }
        public bool SetQuantity(int newVal)
        {
            //Update quantity
            this.quantity += newVal;

            //Check that the quantity is not <=0
            if (this.quantity < 1)
            {
                //Indicate a need to delete
                return false;
            }
            else
                return true;
        }
        public void GetInfo(out string storeage)
        {
            storeage = this.name;
            return;
        }
        public void GetInfo(out float storeage)
        {
            storeage = this.price;
            return;
        }
        public void GetInfo(out int storeage)
        {
            storeage = this.quantity;
            return;
        }
    }

    public class Order
    {
        private string TableName;
        private int Dishes = 0;
        private List<FoodItem> Food { get; set; }

        public Order(string Table)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.PropertyNameCaseInsensitive = false;

            TableName = Table;
            string FileName = "./Files/" + TableName + ".json";
            //Open the File to be read if it doesn't exist create it.
            if (!File.Exists(FileName))
            {
                using FileStream temp = File.Create(FileName); ;
            }

            using (StreamReader r = new StreamReader(FileName))
            {
                //Read the File from start to end of file
                string json = r.ReadToEnd();

                if (!string.IsNullOrEmpty(json))
                {//Turn as all the information into objeects of FoodItemClass
                    Food = JsonSerializer.Deserialize<List<FoodItem>>(json, options);
                }
            }

            //Check that the json data serialized properly
            if (this.Food == null || Food.Count == 0)
            {
                //If the jsonfile is empty or didnt' exist, treat this order objects as a fresh object.
                this.Dishes = 0;
                Food = new List<FoodItem>(6);
            }
            else
            {
                //Update the number of unique dishes in the order
                this.Dishes = Food.Count;
            }


            return;

        }
        ~Order()
        {
            this.SaveToFile();

        }
        public int GetNumberofDishes()
        {
            return Dishes;
        }

        public void AddItem(int ItemId, int Quantity)
        {
            FoodItem Creation = new FoodItem(ItemId, Quantity);
            Food.Add(Creation);
            Dishes++;
        }
        public void AddItem(string name, float price, int Quantity)
        {
            FoodItem Creation = new FoodItem(this.Dishes, name, price, Quantity);
            foreach(var FoodItem in Food)
            {
                if (Creation.name == FoodItem.name)
                {
                    AdjustAmountOfItem(FoodItem.item_id, Creation.quantity);
                    return;
                }
                
            }
            
               Food.Add(Creation);
               Dishes++;
            

        }
        public void SaveToFile()
        {
            //Set the options for converting the data
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = false;
            options.WriteIndented = true;

            //Turn Fooditem list into JSON format string data
            string jsonString = JsonSerializer.Serialize<List<FoodItem>>(Food, options);

            //Write that json format data to a file.
            File.WriteAllText("./Files/" + TableName + ".json", jsonString);

            return;
        }
        public void AdjustAmountOfItem(int Item, int amount)
        {
            //Find the Item from the list of fooditems specified by int item
            FoodItem matching = Food.Find(thing => thing.GetID() == Item);

            //Take matching item and adjust the quantity by the int amount parameter
            if (!matching.SetQuantity(amount))
            {
                //if return value is false then we need to delete the food item. Since it has a qunatity of 0 or less.
                Food.Remove(matching);
                return;
            }
            else
                return;
        }
        public void GetDishInfo(int dishNumber, out string retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }
        public void GetDishInfo(int dishNumber, out int retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }
        public void GetDishInfo(int dishNumber, out float retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }

        public string GetDishName(int dishNumber)
        {
            return this.Food[dishNumber].name;
        }
        public int GetDishQuantity(int dishNumber)
        {
            return this.Food[dishNumber].quantity;
        }
        public float GetDishPrice(int dishNumber)
        {
            return this.Food[dishNumber].price;
        }
    }
}
