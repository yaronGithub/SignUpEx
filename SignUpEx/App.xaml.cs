﻿namespace SignUpEx
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new SignUpContentPage();
        }
    }
}