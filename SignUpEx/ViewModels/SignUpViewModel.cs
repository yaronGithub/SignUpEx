﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpEx.ViewModels
{
    internal class SignUpViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        private Color color;
        private string msg;
        private string usernm;
        private string pass;
        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }
        public string Msg
        {
            get { return msg; }
            set
            {
                msg = value;
                OnPropertyChanged();
            }
        }
        public string Usernm
        {
            get { return usernm; }
            set
            {
                usernm = value;
                OnPropertyChanged();
            }
        }
        public string Pass
        {
            get { return pass; }
            set
            {
                pass = value;
                OnPropertyChanged();
            }
        }
        
        public Command GetUserCommand { get; set; }

    }
}
