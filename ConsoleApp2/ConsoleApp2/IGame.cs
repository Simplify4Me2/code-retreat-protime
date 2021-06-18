using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IGame
    {
        Player Player { get; set; }

        bool MakeMove();
    }
}
