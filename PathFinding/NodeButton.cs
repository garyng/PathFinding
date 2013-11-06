using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PathFinding
{
    public class NodeButton:CheckBox
    {
        public NodeButton()
        {
            this.Appearance = Appearance.Button;
            this.FlatStyle = FlatStyle.Flat;
        }
        public Point Pos { get; set; }
    }
}
