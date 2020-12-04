using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMWM_Core.Models
{
    public class Mod_Anime
    {
        public string Name { get; set; }
        public string CoverPicture { get { return string.IsNullOrEmpty(_CoverPicture) ? "res:res_image_error_default.png" : _CoverPicture; } set { _CoverPicture = value; } }
        public int Year { get; set; }
        public bool IsReading { get; set; }

        private string _CoverPicture;

        public MvxCommand AreaClickEven { get; set; }
    }
}
