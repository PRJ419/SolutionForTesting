﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using BarInfo.Models;
//using BarInfo.Services;



namespace BarInfo.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        private int _title;

        public int MyProperty
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyname = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyname);
            return true;
        }

        #region INotifiPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed == null)
            {
                return;
            }

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}