using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Droid_MVVM.Src.Dialogs
{
    /// <summary>
    ///自定义等待框
    /// </summary>
    public class Dialog_WaitProgress : AndroidX.AppCompat.App.AlertDialog
    {
        private ImageView iv_Loading;
        private AnimationDrawable ad_Loading;


        public Dialog_WaitProgress(Context context) : base(context)
        {
            Init(context);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context"></param>
        private void Init(Context context)
        {
            iv_Loading = new ImageView(context);
            iv_Loading.SetBackgroundResource(Resource.Drawable.Anime_LoadingProgress);
            ad_Loading = iv_Loading.Background as AnimationDrawable;
            this.SetView(iv_Loading);
            this.SetCanceledOnTouchOutside(true);
        }

        public override void Show()
        {
            ad_Loading?.Start();
            base.Show();
        }

        public override void Dismiss()
        {
            ad_Loading?.Stop();
            base.Dismiss();
        }

        public override void OnDetachedFromWindow()
        {
            ad_Loading?.Stop();
            base.OnDetachedFromWindow();
        }

    }
}