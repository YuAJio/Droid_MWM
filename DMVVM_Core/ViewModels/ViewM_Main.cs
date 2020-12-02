using DMWM_Core.Proxys.HttpRequest;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DMWM_Core.ViewModels
{
    public class ViewM_Main : MvxViewModel
    {
        public ViewM_Main()
        {

        }

        public override async Task Initialize()
        {
            await base.Initialize();
            TitleLeft = "Holo";
            TitleRight = "HiThey";
        }

        public string TitleLeft
        {
            get { return _titleLeft; }
            set
            {
                _titleLeft = value;
                RaisePropertyChanged(() => TitleLeft);
            }
        }
        private string _titleLeft;

        public string TitleRight
        {
            get { return _titleRight; }
            set
            {
                _titleRight = value;
                RaisePropertyChanged(() => TitleRight);
            }
        }
        private string _titleRight;

        public ICommand LeftClick => _leftClickCommand ?? (_leftClickCommand = new MvxCommand(LeftClickEvent));
        private ICommand _leftClickCommand;
        private void LeftClickEvent()
        {
            TitleRight = "任豚傻逼";
        }

        public ICommand RightClick => _rightClickCommand ?? (_rightClickCommand = new MvxCommand(RightClickEvent));
        private ICommand _rightClickCommand;
        private void RightClickEvent()
        {
            TitleLeft = "索狗垃圾";
        }

        public ICommand CenterClick => _centerClickCommand ?? (_centerClickCommand = new MvxCommand(CenterClickEvent));
        private ICommand _centerClickCommand;
        private void CenterClickEvent()
        {
            TitleLeft = "Peace";
            TitleRight = "Peace";

            Task.Run(async () =>
            {
                var result = await HttpApi_Anime.Instance.AnimeApi_GetAnimeList(2020);
                return result;
            }).ContinueWith(x =>
            {
                if (x.Exception != null)
                {
                }
                this.List_Anime = x.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }


        #region 列表处理
        private IList<Models.Mod_Anime> _animeList;
        public IList<Models.Mod_Anime> List_Anime { get { return _animeList; } set { _animeList = value; RaisePropertyChanged(() => List_Anime); } }

        public ICommand ItemClickCommand
        {
            get
            {
                return new MvxCommand<Models.Mod_Anime>(anime =>
                {
                    var jk = anime;
                    Console.WriteLine(anime);
                });
            }
        }
        #endregion

        #region 适配器属性处理
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        #endregion

    }
}