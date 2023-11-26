using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    internal class MovebleControls : UserControl
    {
        bool draging = false;
        Point curPos;
        public MovebleControls()
        {
            MouseUp += Form_MouseUp;
            MouseMove += Form_MouseMove;
            MouseDown += Form_MouseDown;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            draging = true;
            int curPosX = this.Location.X - Cursor.Position.X;
            int curPosY = this.Location.Y - Cursor.Position.Y;
            curPos = new Point(curPosX, curPosY);
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                this.Location = new Point(
                        Cursor.Position.X + curPos.X,
                        Cursor.Position.Y + curPos.Y
                        );
            }
        }
    }
}
