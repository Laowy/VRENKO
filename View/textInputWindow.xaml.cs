﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DiplomskoDelo
{
    /// <summary>
    /// Interaction logic for textInputWindow.xaml
    /// </summary>
    public partial class textInputWindow : Window
    {
        public textInputWindow(string input)
        {
            InitializeComponent();
            ResponseTextBox.Text = input;
        }

        public string EditedText
        {
            get { return ResponseTextBox.Text; }
            set { ResponseTextBox.Text = value; }
        }

        private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ResponseTextBox.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("Please enter some text");
            }
            else
            {
                DialogResult = true;
            }
        }
    }
}