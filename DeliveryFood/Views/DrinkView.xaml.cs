﻿using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DeliveryFood.Views
{
    public partial class DrinkView : UserControl
    {
        public DrinkView()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as ListViewItem).Background = Brushes.DarkGray;
        }

        private void ListViewItem_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as ListViewItem).Background = null;
        }
    }
}