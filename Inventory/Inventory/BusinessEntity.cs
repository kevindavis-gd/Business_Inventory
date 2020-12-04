using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

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

       

        public void ImportFromFile()
        {
            //MessageBox.Show("Select Business File");
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text |* .txt";
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    //lines = File.ReadAllLines(fileChooser.FileName).ToList();

                    StreamReader file = new StreamReader(fileChooser.FileName);
                    NameOfBusiness = file.ReadLine();
                    NameOfOwner = file.ReadLine();

                    while (!file.EndOfStream)
                    {
                        AddNewItem(file.ReadLine().Substring(0, 4), file.ReadLine(), int.Parse(file.ReadLine()), Double.Parse(file.ReadLine()));
                    }
                    file.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("ERROR LOADING FILES ", "ERROR");
                }
            }//if 
        }

        public void ImportFromSearilizedFile()
        {
            BinaryFormatter reader = new BinaryFormatter();
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text |* .txt";
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    //StreamReader file = new StreamReader(fileChooser.FileName);
                    FileStream file = new FileStream(fileChooser.FileName, FileMode.Open, FileAccess.Read);

                    BusinessEntity tempBis = (BusinessEntity)reader.Deserialize(file);
                    NameOfBusiness = tempBis.nameOfBusiness;
                    nameOfOwner = tempBis.nameOfOwner;

                    while (file.Position != file.Length)
                    {
                        Item tempItem = (Item)reader.Deserialize(file);
                        inventoryItems.Add(tempItem);
                    }

                    file.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }//if 
        }

        public void OutputToFile()
        {
            SaveFileDialog outfile = new SaveFileDialog();
            if (outfile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(outfile.FileName, FileMode.Create))
                using (StreamWriter output = new StreamWriter(s))
                {
                    output.WriteLine(NameOfBusiness);
                    output.WriteLine(NameOfOwner);
                    foreach(var item in inventoryItems)
                    {
                        output.WriteLine(item.ID);
                        output.WriteLine(item.Name);
                        output.WriteLine(item.Count);
                        output.WriteLine(item.Cost);
                    }
                }
            }
        }
        public void SerializedOutputToFile()
        {

            SaveFileDialog outfile = new SaveFileDialog();
            

            if (outfile.ShowDialog() == DialogResult.OK)
            {
                //serializes Record in binary formatprivate 
                BinaryFormatter formatter = new BinaryFormatter();
                // allow user to create 
                outfile.CheckFileExists = false;

                FileStream stream = new FileStream(outfile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                // using (StreamWriter output = new StreamWriter(s))
                {
                    BusinessEntity tempBis = new BusinessEntity();
                    tempBis.nameOfBusiness = nameOfBusiness;
                    tempBis.nameOfOwner = nameOfOwner;
                    formatter.Serialize(stream, tempBis);

                    foreach (Item item in inventoryItems)
                    {
                        formatter.Serialize(stream, item);
                    }
                }
            }
        }

        public Item GetItemInfo(int index)
        {
            Item temp = new Item();

            try
            {
                temp = inventoryItems[index].Copy();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Copy Items Error");
            }

            return temp;
        }

        public void AddNewItem(string id, string nam, int cou, double cos)
        {
            foreach (Item item in inventoryItems)
            {
                if (item.ID.ToLower() == id.ToLower())
                {
                    MessageBox.Show("Item ID " + id + " Already Exists");
                    return;
                }
            }
            Item temp = new Item(id,nam,cou,cos);
            inventoryItems.Add(temp);
        }


        public void DeleteItem(string DeleteMe)
        {
            
            for (int x = 0; x < inventoryItems.Count; x++)
            {
                //MessageBox.Show(inventoryItems[x].ID);
                if (inventoryItems[x].ID == DeleteMe)
                {
                    inventoryItems.RemoveAt(x);
                    return;
                }
            }
            MessageBox.Show("Item Does Not Exists");
        }

        public void Update(string id, string name, int count, double cost)
        {
            for (int x = 0; x < inventoryItems.Count; x++)
            {
                if (inventoryItems[x].ID == id)
                {
                    inventoryItems[x].Name = name;
                    inventoryItems[x].Count = count;
                    inventoryItems[x].Cost = cost;
                    return;
                }
            }
        }
    }

   
}
