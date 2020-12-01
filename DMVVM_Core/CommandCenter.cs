using DMWM_Core.ViewModels;
using MvvmCross.ViewModels;
using System;

namespace DMVVM_Core
{
    public class CommandCenter : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewM_Main>();
        }
    }
}
