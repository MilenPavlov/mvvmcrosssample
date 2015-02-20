using Android.App;
using Cirrious.MvvmCross.Droid.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Droid.Views
{
    [Activity(MainLauncher = true)]
    public class TipCalcView : MvxActivity
    {
        public new TipViewModel ViewModel
        {
            get { return (TipViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.View_Tip);
        }
    }
}