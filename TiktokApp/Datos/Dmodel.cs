using System;
using System.Collections.Generic;
using System.Text;
using TiktokApp.Models;
using System.Collections.ObjectModel;

namespace TiktokApp.Datos
{
    public class Dmodel
    {
        public static ObservableCollection<Vmodel> MostrarVideos()
        {
            return new ObservableCollection<Vmodel>()
            {
                new Vmodel()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(1).mp4?alt=media&token=4189a56d-22da-4f96-b5cd-59d53ecd0045"
                    ,Indicador=true
                    ,IndicadorIconoPlay=false

                },

                new Vmodel()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(4).mp4?alt=media&token=ea1d00fa-66b7-4a98-8236-a047359d113d"
                   ,Indicador=true
                    ,IndicadorIconoPlay=false
                },

                new Vmodel()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(3).mp4?alt=media&token=d91e39a8-456c-4b37-8eee-255bc7aa2ee4"
                    ,Indicador=true
                    ,IndicadorIconoPlay=false
                },

                new Vmodel()
                {
                    video = " https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(2).mp4?alt=media&token=ec4d8b12-6afd-4c0f-b776-4c69aaa4b8f8"
                    ,Indicador=true
                    ,IndicadorIconoPlay=false
                },

                new Vmodel()
                {
                    video = " https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar.mp4?alt=media&token=84ee1798-7013-4bfd-ae2f-0354555280e1"
                    ,Indicador=true
                    ,IndicadorIconoPlay=false
                },

                new Vmodel()
                {
                    video = " https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(7).mp4?alt=media&token=50d65018-8fc0-4d5c-bb58-db2e204bfd85"
                    ,Indicador=true
                    ,IndicadorIconoPlay=false                }
            };
        }

    }
}
