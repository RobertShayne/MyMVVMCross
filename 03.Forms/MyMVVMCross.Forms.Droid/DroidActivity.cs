using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;

namespace MyMVVMCross.Forms.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTask)]
    public class DroidActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Core.App, FormsApp>, Core.App, FormsApp>
    {
        public DroidActivity() : base()
        {

        }
    }
}