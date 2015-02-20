using System;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.TipViewModel>();
        }
    }
}