using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userlogin
{
    public partial class Form1 : Form
    {
        
        public class User
        {
            string firstName;
            string lastName;
            string userName;
            string password;
            string major;
            string speciality;



            public string getFirstname()
            {

                return firstName;

            }

            public void setFirstname(string firstname)
            {

                this.firstName = firstname;

            }

            public string getLastname()
            {

                return lastName;

            }

            public void setLastname(string lastname)
            {

                this.lastName = lastname;

            }

            public string getUsername()
            {

                return userName;

            }

            public void setUsername(string username)
            {

                this.userName = username;

            }

            public string getPassword()
            {

                return password;

            }

            public void setPassword(string password)
            {

                this.password = password;

            }

            public string getMajor()
            {

                return major;

            }

            public void setMajor(string major)
            {
                this.major = major;

            }

            public string getSpeciality()
            {

                return speciality;

            }

            public void setSpeciality(string speciality)
            {

                this.speciality = speciality;

            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex ==1)
            {
                comboBox1.Items.Add("trigonometry");
                comboBox1.Items.Add("Calculus");
                comboBox1.Items.Add("Algebra");
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Items.Add("U.S. history");
                comboBox1.Items.Add("European History");
                comboBox1.Items.Add("World History");


            }
            else if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Items.Add("Chemistry");
                comboBox1.Items.Add("Physics");
                comboBox1.Items.Add("Computer Science");

            }
            else if (comboBox2.SelectedIndex == 4)
            {

                comboBox1.Items.Add("Football");
                comboBox1.Items.Add("Baseball");
                comboBox1.Items.Add("Basketball");
            }
            else if (comboBox2.SelectedIndex == 5);
            {
                comboBox1.Items.Add("finance");
                comboBox1.Items.Add("stocks");
                comboBox1.Items.Add("world currency");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox4.Text)
            {
                textBox5.ForeColor = Color.Green;
            }
            else
            {
                textBox5.ForeColor = Color.Red;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
           
            
        }

    
    }
}
