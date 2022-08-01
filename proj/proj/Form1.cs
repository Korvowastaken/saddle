using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
           
            InitializeComponent();
            introname.Text = "welcome, " + name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(number.Text))
            {
                errorProvider1.SetError(number, "Number is required");
            }
            else if (string.IsNullOrEmpty(InvNum.Text))
            {
                errorProvider1.SetError(InvNum, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(objname.Text))
            {
                errorProvider1.SetError(objname, "Object name is required");
            }
            else if (string.IsNullOrEmpty(count.Text))
            {
                errorProvider1.SetError(count, "Count is required");
            }
            else if (string.IsNullOrEmpty(price.Text))
            {
                errorProvider1.SetError(price, "Price is required");
            }
            else
            {
                infos R = new infos
                {
                    Number = int.Parse(number.Text),
                    Date = date.Text,
                    Inv_Num = int.Parse(InvNum.Text),
                    Obj_name = objname.Text,
                    Count = int.Parse(count.Text),
                    Price = double.Parse(price.Text),
                    isAvailable = (checkBox1.Checked)
                };
                R.save();
                gridview.DataSource = null;
                gridview.DataSource = infos.GetAllProducts();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
