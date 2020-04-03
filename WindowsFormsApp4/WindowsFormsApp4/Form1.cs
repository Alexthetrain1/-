using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{


    public partial class Form1 : Form
    {

        string[] strplatform = new string[8];
            string godineizbor = null;
        bool year, platform;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            for (int i = 1; i < 7; i++)
                strplatform[i] = null;
        
                if (year4.Checked)
                {
                    godineizbor = ">5 godina";
                    year = true;
                }
                else if (year3.Checked)
                {
                    godineizbor = "3 - 5 godina";
                    year = true;
                }
                else if (year2.Checked)
                {
                    godineizbor = "1 - 3 godina";
                    year = true;
                }
                else if (year1.Checked)
                {
                    godineizbor = "<1 godina";
                    year = true;
                }
                else
                    year = false;

            if (platform1.Checked)
            {
                platform = true;
                strplatform[1] = "Java developer || ";
            }
                if (platform2.Checked)
                {
                    platform = true;
                    strplatform[2] = "IOS developre || ";
                }
                if (platform3.Checked)
                {
                    platform = true;
                strplatform[3] = "SQL developer || ";
            }
               
                if (platform4.Checked) { 
                platform = true;
                strplatform[4] = "Android developer || ";
                }
                if (platform5.Checked)
                {
                    platform = true;
                    strplatform[5] = ".Net developer|| ";
                }
                if (platform6.Checked)
                {
                    platform = true;
                    strplatform[6] = "Python dveloper|| ";
                }
           

                if (year == true || platform == true)
                    _ = MessageBox.Show("Godine iskustva: " + godineizbor + "\n" + "Izabrane platforme : "+strplatform[1]+strplatform[2]+strplatform[3]+strplatform[4]+strplatform[5]+strplatform[6]);
            
        }
    }   
}