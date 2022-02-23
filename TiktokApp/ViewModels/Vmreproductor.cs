using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TiktokApp.Datos;
using TiktokApp.Models;
using Xamarin.Forms;
using System.Linq;

namespace TiktokApp.ViewModels
{
    public class Vmreproductor : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Vmodel> __listavideo;
        bool _indicadoriconoPlay;
        bool _indicador;
        #endregion
        #region CONSTRUCTOR
        public Vmreproductor(INavigation navigation)
        {
            Navigation = navigation;
            MostrarVideos();
        }
        #endregion
        #region OBJETOS
        public bool Indicador
        {
            get { return _indicador; }
            set { SetValue(ref _indicador, value); }
        }
        public bool IndicadoriconoPlay
        {
            get { return _indicadoriconoPlay; }
            set { SetValue(ref _indicadoriconoPlay, value); }
        }
        public ObservableCollection<Vmodel> Listavideo
        {
            get { return __listavideo; }
            set { SetValue(ref __listavideo, value); }
        }
        #endregion
        #region PROCESOS
        public void MostrarVideos()
        {
            Listavideo = new ObservableCollection<Vmodel>(Dmodel.MostrarVideos());
        }
        public void Seleccionar(Vmodel parametros)
        {
            var index = Listavideo
            .ToList()
            .FindIndex(p => p.video == parametros.video);
            Indicador = Listavideo[index].Indicador;

            if (Indicador==true)
            {
                Listavideo[index].Indicador = false;
                Listavideo[index].IndicadorIconoPlay = true;
            }
            else
            {
                Listavideo[index].Indicador = true;
                Listavideo[index].IndicadorIconoPlay = false;
            }
        }
        public async Task ProcesoAsyncrono()
        {


        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Seleccionarcommand => new Command<Vmodel>((p)=>Seleccionar(p));
        #endregion
    }
}
