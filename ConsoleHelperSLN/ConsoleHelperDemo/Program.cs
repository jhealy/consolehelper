using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using devfish.ConsoleHelper;

namespace ConsoleHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CH.Info("this is info");
            CH.Msg("this is Msg");
            CH.Err("this is err");

            CH.Msg("changing colors");
            ConsoleColor saveColor = CH.MsgColor;
            CH.MsgColor = ConsoleColor.Cyan;
            CH.Msg("cyan here");
            CH.MsgColor = saveColor;
            CH.Msg("color restored");
            
            CH.Pause("this is pause, custom message, hit any key to exit");
        }
    }
}
