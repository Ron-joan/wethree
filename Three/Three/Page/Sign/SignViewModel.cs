using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three.Page.Sign
{
    public class SignViewModel : ReactiveObject
    {
        private static readonly object locker = new();
        private static SignViewModel instance;

        SignViewModel()
        {

        }

        public static SignViewModel GetInstance()
        {
            if (instance == null)
                lock (locker)
                    instance = new SignViewModel();
            return instance;
        }
    }
}
