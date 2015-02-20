using System;
using System.Collections.Generic;
using System.Text;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace TipCalc.iOS
{
    public class Setup : Cirrious.MvvmCross.Touch.Platform.MvxTouchSetup  
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter): base(appDelegate, presenter)
        {            
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
