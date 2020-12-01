using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DMVVM_Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace Droid_MVVM.Src
{
    [Application]
    public class ZApplication : MvxAndroidApplication<MvxAndroidSetup<CommandCenter>, CommandCenter>
    {
        public ZApplication()
        {
        }

        public ZApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

    }
}