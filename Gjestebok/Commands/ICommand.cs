﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gjestebok.Commands
{
    internal interface ICommand
    {
        public int Id { get; }
        public string Text { get; }
        public void Execute();

        

    }
}
