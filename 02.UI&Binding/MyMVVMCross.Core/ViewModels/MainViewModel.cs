﻿using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;
using MvvmCross.Commands;

namespace MyMVVMCross.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _Hello = "You dont see me";
        public string Hello
        {
            get => _Hello;
            set
            {
                SetProperty(ref _Hello, value);
            }
        }

        private bool _IsTextShow = false;
        public bool IsTextShow
        {
            get => _IsTextShow;
            set
            {
                SetProperty(ref _IsTextShow, value);
            }
        }

        private MvxCommand<object> _HelloCommad;
        public ICommand HelloCommad
        {
            get => _HelloCommad ?? new MvxCommand<object>(
                (param) => {
                    Hello = "Hello World";
                    IsTextShow = true;
                });
        }
    }
}
