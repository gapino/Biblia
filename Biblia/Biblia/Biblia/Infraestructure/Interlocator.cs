using Biblia.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblia.Infraestructure
{
    public class Interlocator
    {
        public MainViewModel Main { get; set; }

        public Interlocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
