using MvvmCross.ViewModels;
using System;

namespace MyMVVMCross.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
