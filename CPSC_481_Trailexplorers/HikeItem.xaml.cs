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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for HikeItem.xaml
    /// </summary>
    public partial class HikeItem : UserControl
    {
        public HikeItem()
        {
            InitializeComponent();

        }

        private void Background_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Segue.Switch(new HikeProfilePage());
        }
    }
}
