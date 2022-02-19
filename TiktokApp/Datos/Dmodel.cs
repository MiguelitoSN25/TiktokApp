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
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar.mp4?alt=media&token=84ee1798-7013-4bfd-ae2f-0354555280e1"

                },

                new Vmodel()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(4).mp4?alt=media&token=ea1d00fa-66b7-4a98-8236-a047359d113d"

                },

                new Vmodel()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(3).mp4?alt=media&token=d91e39a8-456c-4b37-8eee-255bc7aa2ee4"

                },

                new Vmodel()
                {
                    video = " https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar%20(2).mp4?alt=media&token=ec4d8b12-6afd-4c0f-b776-4c69aaa4b8f8"

                }

            };
        }

    }
}
