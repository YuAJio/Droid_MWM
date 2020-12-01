using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
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

    }
}