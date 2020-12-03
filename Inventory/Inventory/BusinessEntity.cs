﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory
{
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

        
        /*
        public List<Item> InventoryItems
        {
            get { return inventoryItems; }
            set { inventoryItems = value; }
        }
        */

        public void AddItem(Item item)
        {
            inventoryItems.Add(item);
        }

        public void ImportFromFile()
        {
            //MessageBox.Show("Select Business File");
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text |* .txt";
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //lines = File.ReadAllLines(fileChooser.FileName).ToList();

                StreamReader file = new StreamReader(fileChooser.FileName);
                NameOfBusiness = file.ReadLine();

                while (!file.EndOfStream)
                {
                    AddItem(new Item(file.ReadLine(), int.Parse(file.ReadLine()), Double.Parse(file.ReadLine())));
                }

                file.Close();
            }//if
            else
            {
                MessageBox.Show("ERROR LOADING QUESTIONS", "ERROR");
            }//else
        }

        public void OutputToFile()
        {
            SaveFileDialog outfile = new SaveFileDialog();
            if (outfile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(outfile.FileName, FileMode.CreateNew))
                using (StreamWriter output = new StreamWriter(s))
                {
                    output.WriteLine(NameOfBusiness);
                    output.WriteLine(NameOfOwner);
                    foreach(var item in inventoryItems)
                    {
                        output.WriteLine(item.Name);
                        output.WriteLine(item.Count);
                        output.WriteLine(item.Cost);
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
            foreach(Item item in inventoryItems)
            {
                if (item.Name.ToLower() == nam.ToLower())
                {
                    MessageBox.Show("Item Already Exists");
                    return;
                }
            }

            Item temp = new Item(nam,cou,cos);
            inventoryItems.Add(temp);
        }

        public void DeleteItem(string DeleteMe)
        {

            for (int x=0; x < inventoryItems.Count; x++)
            {
                if (inventoryItems[x].Name == DeleteMe)
                {
                    inventoryItems.RemoveAt(x);
                    return;
                }
            }

            MessageBox.Show("Item Does Not Exists");
        }
    }
}
