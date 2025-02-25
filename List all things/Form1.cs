﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_all_things
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> thingList = new List<string>();
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            String newThing = textBox1.Text;
            thingList.Add(newThing);
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            thingList.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + thingList.Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First: " + thingList[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int randomIndex = rand.Next(thingList.Count);
            string randomThing = thingList[randomIndex];
            MessageBox.Show(randomThing);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last: " + thingList[thingList.Count - 1]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = thingList.Count;

            for (int i = 0; i < count; i++) 
            {
                textBox2.Text = thingList[i].ToString() + " ";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = thingList.Count;

            for (int i = 0; i < count; i++)
            {
                textBox2.Text = textBox2.Text + thingList[i].ToString().ToUpper() + " ";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int ContainsIndex = thingList.IndexOf(textBox3.Text);
            if (thingList.Contains(textBox3.Text))
            {
                MessageBox.Show("List contains " + "'"+ textBox3.Text + "'  " + " Index: " + ContainsIndex);
            }
            else
            {

                MessageBox.Show("List does not contain " + "'" + textBox3.Text + "'  " + "No Index pressent");
            }
            textBox3.Text = string.Empty;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            thingList.Sort();
            int count = thingList.Count;

            for (int i = 0; i < count; i++)
            {
                textBox2.Text = textBox2.Text + thingList[i].ToString() + " ";

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            thingList.Remove(textBox4.Text);
            textBox4.Text = "";

        }
    }
}
