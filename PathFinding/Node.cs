using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PathFinding
{
    public class Node
    {

        private int _h;
        private const int _count = 8; //properties count - for indexing
        private Point _pos;
        private Node _parent;
        private int _g;
        private Node _dLeft;
        private int _f;
        private Node _uLeft;
        private Node _dRight;
        private Node _uRight;
        private Node _down;
        private Node _up;
        private Node _right;
        private Node _left;
        private bool _isWall;
        
        public Node()
        {
            this.Left = null;
            this.Right = null;
            this.Down = null;
            this.Up = null;
            this.URight = null;
            this.ULeft = null;
            this.DLeft = null;
            this.DRight = null;
        }

        public Node(Node left, Node right, Node down, Node up, Node uRight, Node dRight, Node uLeft, Node dLeft)
        {
            this.Left = left;
            this.Right = right;
            this.Down = down;
            this.Up = up;
            this.URight = uRight;
            this.ULeft = uLeft;
            this.DLeft = dLeft;
            this.DRight = dRight;
        }

        private Node SwitchNodeProp(int index, Node value = null)
        {
            switch (index)
            {
                case 0:
                    //Up
                    return ReturnNodeProp(ref _up,value);
                case 1:
                    //URight
                    return ReturnNodeProp(ref _uRight, value);
                case 2:
                    //Right
                    return ReturnNodeProp(ref _right, value);
                case 3:
                    //DRight
                    return ReturnNodeProp(ref _dRight, value);
                case 4:
                    //Down
                    return ReturnNodeProp(ref _down, value);
                case 5:
                    //DLeft
                    return ReturnNodeProp(ref _dLeft, value);
                case 6:
                    //Left
                    return ReturnNodeProp(ref _left, value);
                case 7:
                    //ULeft
                    return ReturnNodeProp(ref _uLeft, value);
            }
            return null;
        }

        private Node ReturnNodeProp(ref Node Prop, Node value = null)
        {
            if (value == null)
            {
                return Prop;
            }
            else
            {
                Prop = value;
                return null;
            }
        }

        public Node this[int index]
        {
            get
            {
                return SwitchNodeProp(index);
            }
            set
            {
                SwitchNodeProp(index, value);
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }
        public bool isWall
        {
            get
            {
                return _isWall;
            }
            set
            {
                _isWall = value;
            }
        }
        public Node Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }
        public Node Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
        public Node Up
        {
            get
            {
                return _up;
            }
            set
            {
                _up = value;
            }
        }
        public Node Down
        {
            get
            {
                return _down;
            }
            set
            {
                _down = value;
            }
        }
        public Node URight
        {
            get
            {
                return _uRight;
            }
            set
            {
                _uRight = value;
            }
        }
        public Node DRight
        {
            get
            {
                return _dRight;
            }
            set
            {
                _dRight = value;
            }
        }
        public Node ULeft
        {
            get
            {
                return _uLeft;
            }
            set
            {
                _uLeft = value;
            }
        }
        public Node DLeft
        {
            get
            {
                return _dLeft;
            }
            set
            {
                _dLeft = value;
            }
        }
        public int F
        {
            get
            {
                return _f;
            }
            set
            {
                _f = value;
            }
        }
        public int G
        {
            get
            {
                return _g;
            }
            set
            {
                _g = value;
            }
        }
        public int H
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
        public Node Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
        public Point Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }
    }
}
