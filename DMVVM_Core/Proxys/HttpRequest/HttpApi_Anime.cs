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
            await Task.Delay(1 * 1000);
            return new List<Mod_Anime>
            {
                new Mod_Anime { Name = "安達と島村", Year = 2020,IsReading = true, CoverPicture ="",  },
                new Mod_Anime { Name = "魔女の旅", Year = 2020 ,  IsReading = false, CoverPicture = "https://ss1.bdstatic.com/70cFuXSh_Q1YnxGkpoWK1HF6hhy/it/u=1925229371,1643153610&fm=11&gp=0.jpg" },
                new Mod_Anime { Name = "ユリ熊嵐", Year = 2016 ,IsReading=true, CoverPicture="https://ss3.bdstatic.com/70cFv8Sh_Q1YnxGkpoWK1HF6hhy/it/u=3690619766,515636209&fm=26&gp=0.jpg"},
                new Mod_Anime { Name = "やがて君になる", Year = 2019 ,IsReading= true,  CoverPicture ="https://ss3.bdstatic.com/70cFv8Sh_Q1YnxGkpoWK1HF6hhy/it/u=3037101242,2430291467&fm=26&gp=0.jpg" },
            };
        }

    }
}
