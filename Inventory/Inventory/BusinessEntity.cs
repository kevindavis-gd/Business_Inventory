////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Name: Kevin Davis 
// Class : CMPS4143
// Assignment: Program 7
// Date: 12/04/2020
//
// Description :
// This Program keeps an inventory of the items within multiple stores,
// how many of each item are currently in stock, and the cost of each. 
// It also allows the user to Insert, Update, Deletem and Display items.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Inventory
{
    [Serializable]
    class BusinessEntity
    {
        private string nameOfBusiness;
        private string nameOfOwner;
        private int numberOfItems;
        public List<Item> inventoryItems = new List<Item>();

        public int NumberOfItems
        {
            get { numberOfItems = inventoryItems.Count; return numberOfItems; }
        }
        public string NameOfBusiness
        {
            get { return nameOfBusiness; }
            set { nameOfBusiness = value; }
        }
        public string NameOfOwner
        {
            get { return nameOfOwner; }
            set { nameOfOwner = value; }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Import From File
        // Name: ImportFromFile
        // Arguments : None
        //
        // Description :
        // Reads in data from a text file and stores it within its appropriate location
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void ImportFromFile()
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text |* .txt";
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader file = new StreamReader(fileChooser.FileName);
                    NameOfBusiness = file.ReadLine();
                    NameOfOwner = file.ReadLine();
                    string tempID;
                    while (!file.EndOfStream)
                    {
                        tempID = file.ReadLine();
                        if (tempID.Length > 4)
                        {
                            MessageBox.Show("ID#: " + tempID + " is too long, only the first 4 characters will be used as ID#");
                        }
                        //only accept 4 characters when reading in the ID
                        AddNewItem(tempID.Substring(0, 4), file.ReadLine(), int.Parse(file.ReadLine()), Double.Parse(file.ReadLine()));
                    }
                    file.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Text File Error ", "Error");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Import From Searilized File
        // Name: ImportFromSearilizedFile 
        // Arguments : None
        //
        // Description :
        // This method reads in data from a serialized file, deserializes it, then stores it in
        // the appropriate location
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void ImportFromSearilizedFile()
        {
            BinaryFormatter reader = new BinaryFormatter();
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text |* .txt";
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(fileChooser.FileName, FileMode.Open, FileAccess.Read);
                    //create business object to store the decerialized input
                    BusinessEntity tempBis = (BusinessEntity)reader.Deserialize(file);
                    //store the information from the imported business file into this one
                    NameOfBusiness = tempBis.nameOfBusiness;
                    nameOfOwner = tempBis.nameOfOwner;
                    while (file.Position != file.Length)
                    {
                        //create item object to store the deserialized object
                        Item tempItem = (Item)reader.Deserialize(file);
                        // add the new object to inventoryItems
                        inventoryItems.Add(tempItem);
                    }
                    file.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Serialized File Error", "Error");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Output To Text File
        // Name: OutputToFile
        // Arguments : None
        //
        // Description :
        // this method opens a file dialogue where you can select where to save your file.
        // It takes all the information from this business object and writes it to a text
        // file
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void OutputToFile()
        {
            SaveFileDialog outfile = new SaveFileDialog();
            if (outfile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(outfile.FileName, FileMode.Create))
                using (StreamWriter output = new StreamWriter(s))
                {
                    // first two lines to output to file
                    output.WriteLine(NameOfBusiness);
                    output.WriteLine(NameOfOwner);
                    foreach(var item in inventoryItems)
                    {
                        //these lines are written in groups of 4
                        output.WriteLine(item.ID);
                        output.WriteLine(item.Name);
                        output.WriteLine(item.Count);
                        output.WriteLine(item.Cost);
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Serialized Output To File
        // Name: SerializedOutputToFile
        // Arguments : None
        //
        // Description :
        // this method opens a file dialogue where you can select where to save your file.
        // It takes all the information from this business object and saves it to a serialized
        // file
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void SerializedOutputToFile()
        {
            SaveFileDialog outfile = new SaveFileDialog();
            if (outfile.ShowDialog() == DialogResult.OK)
            {
                //serializes Record in binary format private 
                BinaryFormatter formatter = new BinaryFormatter();
                // allow user to create 
                outfile.CheckFileExists = false;
                FileStream stream = new FileStream(outfile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                {
                    //create a new business object 
                    BusinessEntity tempBis = new BusinessEntity();
                    //store the name of owner and name of business in that object
                    tempBis.nameOfBusiness = nameOfBusiness;
                    tempBis.nameOfOwner = nameOfOwner;
                    //serialize theat business object
                    formatter.Serialize(stream, tempBis);
                    //loop through every item and serialize it
                    foreach (Item item in inventoryItems)
                    {
                        formatter.Serialize(stream, item);
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Get Item Info
        // Name: GetItemInfo
        // Arguments : int index
        //
        // Description :
        // this method takes in an int then uses that int as in index to the inventoryItwms List.
        // it makes a copy of the object located at that index and returns the new object.
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public Item GetItemInfo(int index)
        {
            Item temp = new Item();
            try
            {
                temp = inventoryItems[index].Copy();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Copy Items Error", "Error");
            }
            return temp;
        }
        ////////////////////////////////////////////////////////////////////////////////////////// AddNewItem
        // Name: AddNewItem
        // Arguments : string id, string nam, int cou, double cos
        //
        // Description :
        // this method loops through every intem in inventoryItems to ensure that the item to 
        // be created does not already exist, if it does not then the new item will be added.
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void AddNewItem(string id, string nam, int cou, double cos)
        {
            foreach (Item item in inventoryItems)
            {
                //if the item already already exists, then dont insert it
                if (item.ID == id)
                {
                    MessageBox.Show("Item ID " + id + " Already Exists", "Error");
                    return;
                }
            }
            Item temp = new Item(id,nam,cou,cos);
            inventoryItems.Add(temp);
        }
        ////////////////////////////////////////////////////////////////////////////////////////// DeleteItem
        // Name: DeleteItem
        // Arguments : string DeleteMe
        //
        // Description :
        // this method loops through all the items in inventoryItems untill it finds an item with
        // a matching ID, then deletes it.
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void DeleteItem(string DeleteMe)
        {
            for (int x = 0; x < inventoryItems.Count; x++)
            {
                //if the ID of the item matched the input text
                if (inventoryItems[x].ID == DeleteMe)
                {
                    inventoryItems.RemoveAt(x);
                    //if found stop the loop
                    return;
                }
            }
            MessageBox.Show("Item Does Not Exists", " Error");
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Update
        // Name: Update
        // Arguments : string id, string name, int count, double cost
        //
        // Description :
        // this method loops through all the items in inventoryItems and looks for an item with 
        // a matching ID. if found, it will update it with the new information, else it will
        // show a messagebox
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void Update(string id, string name, int count, double cost)
        {
            for (int x = 0; x < inventoryItems.Count; x++)
            {
                MessageBox.Show(id);
                if (inventoryItems[x].ID == id)
                {
                    inventoryItems[x].Name = name;
                    inventoryItems[x].Count = count;
                    inventoryItems[x].Cost = cost;
                    return;
                }
            }
            MessageBox.Show("Item Not Found", "Error");
        }
    }
}
