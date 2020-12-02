using DMWM_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMWM_Core.Proxys.HttpRequest
{
    /// <summary>
    /// 动画信息网络访问接口
    /// </summary>
    public class HttpApi_Anime
    {
        #region 单例
        private static readonly Lazy<HttpApi_Anime> instance = new Lazy<HttpApi_Anime>(() => new HttpApi_Anime());
        private HttpApi_Anime() { }
        public static HttpApi_Anime Instance
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
