using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using DMWM_Core.ViewModels;
using Droid_MVVM.Src.Dialogs;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Views;
using System;

namespace Droid_MVVM.Src.Activitys
{
    [Activity(Label = "Acty_Main", Theme = "@style/AppTheme")]
    public class Acty_Main : MvxActivity<ViewM_Main>
    {
        private Dialog_WaitProgress dialog_WaitProgress;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Acty_Main);
            dialog_WaitProgress = new Dialog_WaitProgress(this);
            ViewModel.Act_ShowWaitDialog += ShowWaitDialog;
            ViewModel.Act_HideWaitDialog += HideWaitDialog;
            FindViewById<MvxRecyclerView>(Resource.Id.rv_data).SetLayoutManager(new GridLayoutManager(this, 2));
        }


        private void ShowWaitDialog()
        {
            dialog_WaitProgress.Show();
        }

        private void HideWaitDialog()
        {
            dialog_WaitProgress.Dismiss();
        }

        private class Apdater : MvxRecyclerAdapter
        {


        }

    }
}