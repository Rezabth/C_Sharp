﻿using StoretellerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTellerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTellStory_Click(object sender, EventArgs e)
        {

            try
            { 
            Storyteller storyteller = new Storyteller();
            tbStory.Text = storyteller.TellStory(
                tbNameOfChild.Text,
                Convert.ToInt32(numAge.Value),
                cbScary.Checked);
        }
         catch(InvalidOperationException ex)
         {

            MessageBox.Show("kan inte berätta story för dig.");
           }
        finally
        {
        }

         
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonTellStory_Click(object sender, EventArgs e)
        {

        }
    }