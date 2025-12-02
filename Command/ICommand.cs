using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // 1. Command
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
