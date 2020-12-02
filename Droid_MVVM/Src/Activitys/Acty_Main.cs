using Android.App;
using Android.OS;
using DMWM_Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Droid_MVVM.Src.Activitys
{
    [Activity(Label = "Acty_Main", Theme = "@style/AppTheme")]
    public class Acty_Main : MvxActivity<ViewM_Main>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Acty_Main);

        }
    }
}