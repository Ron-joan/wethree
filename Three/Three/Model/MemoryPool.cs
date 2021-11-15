using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three.Model
{
    internal class MemoryPool
    {
        private List<MemoryDebris> memoryDebris = new();
        public MemoryPool()
        {
            for(int i = 0; i < 1024*2; i++)
            {
                MemoryDebris.Add(new MemoryDebris() { Color = "#eddd9e" });
            }
        }

        public List<MemoryDebris> MemoryDebris { get => memoryDebris; set => memoryDebris = value; }
    }

    class MemoryDebris
    {
        [Reactive]
        public string Color { get; set; }
    }
}
