using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Droid_MVVM.Domain.Models;

namespace Droid_MVVM.Proxys.HttpRequest
{
    /// <summary>
    /// 动画信息网络访问接口
    /// </summary>
    public class HttpApi_AnimationInfo
    {
        #region 单例
        private static readonly Lazy<HttpApi_AnimationInfo> instance = new Lazy<HttpApi_AnimationInfo>(() => new HttpApi_AnimationInfo());
        private HttpApi_AnimationInfo() { }
        public static HttpApi_AnimationInfo Instance
        {
            get
            {
                return instance.Value;
            }
        }
        #endregion

        /// <summary>
        /// 获取动画列表
        /// </summary>
        /// <param name="userId">选填项,无意义</param>
        /// <returns></returns>
        public async Task<List<Mod_Anime>> AnimeApi_GetAnimeList(int userId)
        {
            await Task.Delay(2 * 1000);
            return new List<Mod_Anime>
            {
                new Mod_Anime { Name = "安達と島村", Year = 2020 }
            };
        }

    }
}