using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three.Page.Memory
{
    internal class MemoryViewModel : ReactiveObject
    {
        private static readonly object locker = new();
        private static MemoryViewModel instance;

        MemoryViewModel()
        {
            MemoryPool = new Model.MemoryPool();
        }
        public static MemoryViewModel GetInstance()
        {
            if (instance == null)
                lock (locker)
                    instance = new MemoryViewModel();
            return instance;
        }
        [Reactive]
        public Model.MemoryPool MemoryPool { get; set; }
    }
}
