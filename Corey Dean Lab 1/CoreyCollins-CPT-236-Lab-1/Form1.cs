/* Code review by Andrew Foster
 * My specific comments can be found in multi-line code snippets.
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreyCollins_CPT_236_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext titan = new DataClasses1DataContext();
            var results = from Product in titan.Products
                          orderby Product.Description
                          select Product;

            foreach (Product description in results)
            {
                dataBaseListBox.Items.Add(description);
            }

        }

        private void button1_Click(object sender, EventArgs e)
            /* I'm not a fan of these generic component names. Just looking at the code, how can a programmer know what this button is connected to? */
        {
            try
            {
                if (problem4TextBox.Text == "")
                {
                    MessageBox.Show("Please enter a number!");
                }

                //creating a data context object
                DataClasses1DataContext titan = new DataClasses1DataContext();
                //searching for product number
                var results = from Product in titan.Products
                              where Product.Product_Number == problem4TextBox.Text
                              select Product.Description;
                //clearing list box
                dataBaseListBox.Items.Clear();

                //displaying results into listbox
                foreach (string description in results)
                {
                    dataBaseListBox.Items.Add(description);
                }
            } catch { MessageBox.Show("Error"); }
            /* This error message is not very informative. What was wrong? How can the user correct it? */
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                if (problem4TextBox.Text == "")
                {
                    MessageBox.Show("Please enter a number!");
                    /* much better than the above error message. This tells the user what is wrong, and what is needed. */
                }
                //creating a data context object
                DataClasses1DataContext titan = new DataClasses1DataContext();
                //searching for specified text
                var results = from Product in titan.Products
                              where Product.Description == problem5TextBox.Text
                              select Product.Description;
                //clearing list box
                dataBaseListBox.Items.Clear();

                //displaying results into listbox
                foreach (string description in results)
                {
                    dataBaseListBox.Items.Add(description);
                }
            } catch { MessageBox.Show("Error"); }
        }

        private void btnGTRThan_Click(object sender, EventArgs e)
        {
            try
            {
                if (problem4TextBox.Text == "")
                {
                    MessageBox.Show("Please enter a number!");
                }
                int numHeld = int.Parse(problem5TextBox.Text);
                /* I believe int.TryParse would be better here. TryParse will simply give you a '0', rather than crash if an integer is not provided. */
                //creating a data context object
                DataClasses1DataContext titan = new DataClasses1DataContext();
                //units on hand greater x
                var results = from Product in titan.Products
                              where Product.Units_On_Hand > numHeld
                              select Product.Description;

                //clearing list box
                dataBaseListBox.Items.Clear();

                //displaying results into listbox
                foreach (string description in results)
                {
                    dataBaseListBox.Items.Add(description);
                }
            }
            catch { MessageBox.Show("Error"); }
        }

        private void btnLessThan_Click(object sender, EventArgs e)
            /* This component is named uniquely. Well done. */
        {
            try
            {
                if (problem4TextBox.Text == "")
                {
                    MessageBox.Show("Please enter a number!");
                }
                //declaring variables
                int numHeld = int.Parse(problem5TextBox.Text);
                //creating a data context object
                DataClasses1DataContext titan = new DataClasses1DataContext();
                //units on hand less than x
                var results = from Product in titan.Products
                              where Product.Units_On_Hand < numHeld
                              select Product.Description;

                //clearing list box
                dataBaseListBox.Items.Clear();

                //displaying results into listbox
                foreach (string description in results)
                {
                    dataBaseListBox.Items.Add(description);
                }
            } catch { MessageBox.Show("Error"); }
        }

        private void sortUnitsASC_Click(object sender, EventArgs e)
        {
            //creating a data context object
            DataClasses1DataContext titan = new DataClasses1DataContext();
            //sorting units in ascending
            var results = from Product in titan.Products
                          orderby Product.Units_On_Hand
                          select Product.Description;
            //clearing list box
            dataBaseListBox.Items.Clear();

            //displaying results into listbox
            foreach (string description in results)
            {
                dataBaseListBox.Items.Add(description);
            }
        }

        private void sortPriceByASC_Click(object sender, EventArgs e)
        {
            //creating a data context object
            DataClasses1DataContext titan = new DataClasses1DataContext();
            //sorting price bt ascending
            var results = from Product in titan.Products
                          orderby Product.Price
                          select Product.Description;
            //clearing list box
            dataBaseListBox.Items.Clear();

            //displaying results into listbox
            foreach (string description in results)
            {
                dataBaseListBox.Items.Add(description);
            }
        }

        private void btnMinPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (problem4TextBox.Text == "")
                {
                    MessageBox.Show("Please enter a number!");
                }
                //declaring variables
                decimal minValue = decimal.Parse(minTextBox.Text);
                decimal maxValue = decimal.Parse(maxTextBox.Text);
                DataClasses1DataContext titan = new DataClasses1DataContext();
                var results = from Product in titan.Products
                              where Product.Price > minValue
                              where Product.Price < maxValue
                /* These 2 lines above can be condensed into one by utilizing && (where Product.Price > minValue && Product.Price < maxValue */
                              select Product.Description;
                foreach (string description in results)
                {
                    dataBaseListBox.Items.Add(description);
                }

            }  catch { MessageBox.Show("ERROR!"); }

        }
    }
}
