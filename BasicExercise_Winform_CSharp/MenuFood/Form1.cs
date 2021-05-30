using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddFoodButton.Enabled = false;
            Add1Button.Enabled = false;
            AddAllButton.Enabled = false;
            Remove1Button.Enabled = false;
            RemoveAllButton.Enabled = false;
        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            string nameFood = nameFoodText.Text;
            if (!listMenu.Items.Contains(nameFood))
            {
                listMenu.Items.Add(nameFood);
                nameFoodText.Clear();
            }
            if (listMenu.Items.Count > 0)
            {
                AddAllButton.Enabled = true;
                Add1Button.Enabled = true;
            }

        }

        private void Add1Button_Click(object sender, EventArgs e)
        {
            if (listMenu.CanSelect)
            {
                if (!listFoodChosen.Items.Contains(listMenu.SelectedItem))
                {
                    listFoodChosen.Items.Add(listMenu.SelectedItem);
                }
               
            }
            if (listFoodChosen.Items.Count > 0)
            {
                Remove1Button.Enabled = true;
                RemoveAllButton.Enabled = true;
            }
        }

        private void Remove1Button_Click(object sender, EventArgs e)
        {
            if (listFoodChosen.CanSelect)
            {
                listFoodChosen.Items.RemoveAt(listFoodChosen.SelectedIndex);

            }
            if (listFoodChosen.Items.Count == 0)
            {
                Remove1Button.Enabled =false;
                RemoveAllButton.Enabled = false;
            }
            
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            listFoodChosen.Items.Clear();
           
                Remove1Button.Enabled = false;
                RemoveAllButton.Enabled = false;
            
        }

        private void AddAllButton_Click(object sender, EventArgs e)
        {
            foreach(object item in listMenu.Items)
            {
                listFoodChosen.Items.Add(item.ToString());
            }
            if (listFoodChosen.Items.Count > 0)
            {
                Remove1Button.Enabled = true;
                RemoveAllButton.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameFoodText_TextChanged(object sender, EventArgs e)
        {
            if(nameFoodText.TextLength > 0)
            {
                AddFoodButton.Enabled = true;
            }
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
