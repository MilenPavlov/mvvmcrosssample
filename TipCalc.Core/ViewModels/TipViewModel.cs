using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculation _calculation;

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
            base.Start();
        }

        private double _subTotal;

        public double Subtotal 
        { 
            get { return _subTotal; }
            set { _subTotal = value; RaisePropertyChanged(()=> Subtotal); Recalculate(); }
        }

        private int _generosity;
        public int Generosity 
        {
            get { return _generosity; } 
            
            set { _generosity = value; RaisePropertyChanged(()=> Generosity); Recalculate();} 
        }

        private double _tip;

        public double Tip
        {
            get { return _tip; }
            set { _tip = value; RaisePropertyChanged(() => Tip); }
        }

        private void Recalculate()
        {
            Tip = _calculation.TipAmount(Subtotal, Generosity);
        }
    }
}
