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
using BeatSaberModTemplates.ViewModels;
using Microsoft.VisualStudio.PlatformUI;

namespace BeatSaberModTemplates.Views
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        SettingsViewModel SettingsViewModel;
        public SettingsWindow()
        {
            SettingsViewModel = new SettingsViewModel();
            DataContext = SettingsViewModel;
            InitializeComponent();
            //DialogResult = true;
        }

        void applyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }

}
