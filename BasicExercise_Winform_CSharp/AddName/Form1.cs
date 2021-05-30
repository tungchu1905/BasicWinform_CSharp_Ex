using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string first = firstTextBox.Text;
            string last = lastTextBox.Text;
            string title = titleComboBox.Text;
            string nameToAdd = title + " " + first + " " + last;
            namesListBox.Items.Add(nameToAdd);
        }
    }
}
