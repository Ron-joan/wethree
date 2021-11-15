using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Three.Model;
using System.Threading.Tasks;

namespace Three.Page.Legend
{
    public class LegendViewModel : ReactiveObject
    {
        private static readonly object locker = new();
        private static LegendViewModel instance;

        public List<Three.Model.Legend> Legends { get; set; }

        LegendViewModel()
        {
            Legends = new List<Three.Model.Legend>()
            {
               new Model.Legend()
               {
                   Name = "2048",
                   Color = "#f52443"
               },
               new Model.Legend()
               {
                   Name = "1024",
                   Color = "#f52443"
               },
               new Model.Legend()
               {
                   Name = " 512",
                   Color = "#f52443"
               },
               new Model.Legend()
               {
                   Name = " 256",
                   Color = "#f52443"
               },
               new Model.Legend()
               {
                   Name = " 128",
                   Color = "#f52443"
               }
            };
        }
        public static LegendViewModel GetInstance()
        {
            if (instance == null)
                lock (locker)
                    instance = new LegendViewModel();
            return instance;
        }


    }
}
