﻿using System;
using System.Configuration;
using System.Windows.Forms;

namespace Final_Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Encryption.AutoEncrypt();
            textBox2.Text = Encryption.LastEncryption;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Encryption.LastEncryption;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks if you press enter
            if (e.KeyCode == Keys.Enter)
            {
                // Checks for a valid encrypted set of text
                if (Encryption.DecryptTest(textBox1.Text)) {
                    // Makes arrays for proper creation of data implementation in to the text file
                    int[] array = new int[Properties.Settings.Default.Properties.Count];
                    string data = Encryption.Decrypt(textBox1.Text);
                    string[] dataArray = data.Split('\n');
                    for (int i = 0; i < dataArray.Length; i++) array[0] = int.Parse(dataArray[0]);
                    int count = 0;
                    foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
                    {
                        if (count == (4)) Properties.Settings.Default[currentProperty.Name] = double.Parse(dataArray[count]);
                        else Properties.Settings.Default[currentProperty.Name] = int.Parse(dataArray[count]);
                        count++;
                    }
                    Encryption.AutoEncrypt();
                    textBox2.Text = Encryption.LastEncryption;
                    var x = MessageBox.Show("Save Loaded");
                    if (x == DialogResult.OK)
                    {
                        Form1.Form2_FormClosed();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid encrypted file");
                }

            }
        }
    }
}
