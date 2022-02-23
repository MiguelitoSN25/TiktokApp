using System;
using System.Collections.Generic;
using System.Text;
using TiktokApp.ViewModels;
namespace TiktokApp.Models
{
    public class Vmodel:BaseViewModel
    {
        public string video { get; set; }
        public bool _indicador;
        public bool Indicador
        {
            get { return _indicador; }
            set { SetValue(ref _indicador, value); }
        }

        public bool _indicadorIconoPlay;
        public bool IndicadorIconoPlay
        {
            get { return _indicadorIconoPlay; }
            set { SetValue(ref _indicadorIconoPlay, value); }
        }
    }
}
