﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMVVMCross.Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsApp : Application
    {
		public FormsApp ()
		{
			InitializeComponent ();
		}
	}
}