using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace Droid_MVVM.Src.Activitys
{
    [Activity(
    MainLauncher = true,
    Icon = "@mipmap/ic_launcher",
    Theme = "@style/Theme.Splash",
    NoHistory = true,
    ScreenOrientation = ScreenOrientation.Landscape)]
    public class Acty_Splash : MvxSplashScreenActivity
    {
    }
}