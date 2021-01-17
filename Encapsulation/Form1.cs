using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList arrProduct = new ArrayList();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill out all the information!");
            }
            else
            {
                ProductProperties pro = new ProductProperties();
                pro.ProductName = textBox1.Text;
                pro.Price = Convert.ToDecimal(textBox2.Text);
                pro.Quantity = Convert.ToInt32(textBox3.Text);
                pro.ExpiryDate = dateTimePicker1.Value;

                arrProduct.Add(pro);

                listBox1.Items.Clear();

                foreach (object items in arrProduct)
                {
                    if (items != null)
                    {
                        listBox1.Items.Add(items);
                    }
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
            }


        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            ProductProperties p = (ProductProperties)listBox1.SelectedItem;
            label6.Text = "Name :" + p.ProductName + "," + "Price :" + p.Price + "," + "Quantity:" + p.Quantity + "," + "Exp.Date :" + p.ExpiryDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductProperties p = (ProductProperties)listBox1.SelectedItem;
            int index = arrProduct.IndexOf(p);

            arrProduct[index] = null;
            textBox1.Text = p.ProductName;
            textBox2.Text = p.Price.ToString();
            textBox3.Text = p.Quantity.ToString();
            dateTimePicker1.Value = p.ExpiryDate;

            listBox1.Items.Clear();
            foreach (object items in arrProduct)
            {
                if (items != null)
                {
                    listBox1.Items.Add(items);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductProperties p = (ProductProperties)listBox1.SelectedItem;
            int index = arrProduct.IndexOf(p);

            arrProduct[index] = null;

            listBox1.Items.Clear();
            foreach (object items in arrProduct)
            {
                if (items != null)
                {
                    listBox1.Items.Add(items);
                }
            }

        }
    }
}
