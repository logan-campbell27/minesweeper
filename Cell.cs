using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneMinesweeperConsole

{
    class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool isClicked { get; set; }
        public bool isBomb { get; set; }
        public int bombsAjacent { get; set; }

        public Cell()
        {
            Row = -1;
            Column = -1;
            isClicked = false;
            isBomb = false;
            bombsAjacent = 0;
        }
        public Cell(int r, int c, bool clicked, bool bomb, int ajacent)
        {
            Row = r;
            Column = c;
            isClicked = clicked;
            isBomb = bomb;
            bombsAjacent = ajacent;
        }

    }
}
