using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment1
{
    public partial class theGui : Form
    {
        mealMoreFunction mmf;
        meal m = new meal();
        public theGui():base()
        {
            mmf = new mealMoreFunction();
            m.accept(mmf);


            InitializeComponent();
        }




        private void theGui_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int choice = Convert.ToInt32(textBox2.Text);
            m.addAnotherMeal(choice);
            textBox3.Text = Convert.ToString(m.calories());
            textBox4.Text = Convert.ToString(m.result);
            textBox5.Text= Convert.ToString(mmf.idealTips());
            textBox6.Text = Convert.ToString(mmf.totalCost());


            if(choice >=1 && choice < 7)
            {
                label8.Visible = false;
                label9.Visible = false;
            }
            if (choice > 7)
            {
                label8.Visible = true;
             }
            if(choice < 1)
            {
                label9.Visible = true;
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            mmf.restartMeal();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


            m.caloriesOfMeal = 875.0;
            m.priceOfMeal = 12.99;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = m.nameOfMeal;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // m.calories();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            //costofmeal
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.nameOfMeal = textBox1.Text;

            m.caloriesOfMeal = Convert.ToDouble(textBox3.Text);
            m.priceOfMeal =Convert.ToDouble( textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    public class Test92
    {
        public static void Main(string[] args)
        {
            Application.Run(new theGui());

        }
    }
}
