using System;
using System.Drawing;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TipCalc.Core.ViewModels;

namespace TipCalc.iOS.Views
{
    public partial class TipView : MvxViewController
    {
        public TipView() { }

        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            this.CreateBinding (this.TipLabel).To( (TipViewModel vm) => vm.Tip ).Apply(); 
            this.CreateBinding (this.SubTotalTextField).To( (TipViewModel vm) => vm.SubTotal ).Apply();
            this.CreateBinding (this.GenerositySlider.To((TipViewModel vm) => vm.Generosity ).Apply());
        }
    }
}