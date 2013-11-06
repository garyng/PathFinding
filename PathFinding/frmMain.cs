using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Linq;

namespace PathFinding
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<List<NodeButton>> _buttons = new List<List<NodeButton>>();

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitButtons(ref _buttons, _width, _height, 20);
            InitNodes(ref _nodes);
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            VisualizeNodes(_nodes);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            FindPath(ref _nodes, _start, _end);
            sw.Stop();
            lblTime.Text = "Time : " + sw.Elapsed + " " + (_paths.Count == 0 ? "No solution" : "Solution Found! ( " + _paths.Count.ToString() + " )");
        }

        private int _width = 20;
        private int _height = 20;
        List<Node> _paths = new List<Node>();
        List<List<Node>> _nodes = new List<List<Node>>();
        Node _start;
        Node _end;

        private void VisualizeNodes(List<List<Node>> nodes)
        {
            int x = 0;
            nodes.ForEach(delegate(List<Node> nX)
            {
                int y = 0;
                nX.ForEach(delegate(Node nY)
                {
                    _buttons[x][y].Text = nY.F.ToString();
                    y++;
                });
                x++;
            });
        }

        private void VisualizePath(List<Node> nodes)
        {
            _paths = nodes;
            nodes.ForEach(delegate(Node item)
            {
                _buttons[item.Pos.X][item.Pos.Y].ForeColor = Color.Red;
            });
        }

        private void InitButtons(ref List<List<NodeButton>> buttons, int width, int height, int size)
        {
            this.SuspendLayout();
            for (int x = 0; x < width; x++)
            {
                List<NodeButton> bX = new List<NodeButton>();
                for (int y = 0; y < height; y++)
                {
                    NodeButton bY = new NodeButton();
                    bY.Size = new Size(size, size);
                    bY.Top = y * size;
                    bY.Left = x * size;
                    //bY.Text = x + "," + y;
                    bY.Pos = new Point(x, y);
                    bY.MouseDown += delegate(object sender, MouseEventArgs e)
                    {
                        NodeButton nb = sender as NodeButton;
                        nb.Enabled = false;
                        if (e.Button == MouseButtons.Left)
                        {
                            if (cbWalls.Checked)
                            {
                                _nodes[nb.Pos.X][nb.Pos.Y].isWall = true;
                                nb.BackColor = Color.Red;
                                lstWalls.Items.Add(nb.Pos.ToString());
                            }
                            else
                            {
                                if (_start == null)
                                {
                                    _start = _nodes[nb.Pos.X][nb.Pos.Y];
                                    nb.BackColor = Color.White;
                                    lblStart.Text = "Start : " + nb.Pos.ToString();
                                }
                            }
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            if (_end == null)
                            {
                                _end = _nodes[nb.Pos.X][nb.Pos.Y];
                                lblEnd.Text = "End : " + nb.Pos.ToString();
                                nb.Checked = true;
                                nb.BackColor = Color.Blue;
                            }
                        }

                    };
                    pnlCon.Controls.Add(bY);
                    bX.Add(bY);
                }
                buttons.Add(bX);
            }
            this.ResumeLayout();
        }

        private void InitNodes(ref List<List<Node>> nodes)
        {
            for (int x = 0; x < _width; x++)
            {
                List<Node> nX = new List<Node>();
                for (int y = 0; y < _height; y++)
                {
                    Node nY = new Node();
                    nY.Pos = new Point(x, y);
                    //nY.F = x * 100 + y;
                    //Up
                    if (y > 0)
                    {
                        nY.Up = nX[y - 1];
                        nX[y - 1].Down = nY;
                    }
                    //Left
                    if (x > 0)
                    {
                        nY.Left = nodes[x - 1][y];
                        nodes[x - 1][y].Right = nY;
                    }
                    //UpLeft
                    if (x > 0 && y > 0)
                    {
                        nY.ULeft = nodes[x - 1][y - 1];
                        nodes[x - 1][y - 1].DRight = nY;
                    }
                    //DownLeft
                    if (x > 0 && y < (_height - 1))
                    {
                        nY.DLeft = nodes[x - 1][y + 1];
                        nodes[x - 1][y + 1].URight = nY;
                    }
                    nX.Add(nY);
                }
                nodes.Add(nX);
            }
        }

        private void FindPath(ref List<List<Node>> nodes, Node start, Node end)
        {
            List<Node> open = new List<Node>();
            List<Node> close = new List<Node>();

            open.Add(start);

            while (open.Count > 0)
            {

                close.Add(open[0]); 
                Node pendingNode = open[0];
                open.RemoveAt(0);

                for (int i = 0; i < pendingNode.Count; i++)
                {
                    Node current = pendingNode[i];
                    if (current == null || current.Equals(start) || current.isWall)
                    {
                        continue;
                    }
                    int h;
                    int g;
                    int f;

                    if (i % 2 == 0)
                    {
                        //Up Right Down Left
                        g = pendingNode.G + 10;
                    }
                    else
                    {
                        // URight DRight DLeft ULeft
                        
                        //check for walls
                        //|X
                        //|_
                        if (pendingNode[(i + 1) % 8].isWall || pendingNode[i - 1].isWall)
                        {
                            continue;
                        }

                        g = pendingNode.G + 14;
                    }

                    h = (Math.Abs(end.Pos.X - current.Pos.X) + Math.Abs(end.Pos.Y - current.Pos.Y)) * 10;
                    f = h + g;
                    if (f < current.F || current.F == 0)
                    {
                        current.G = g;
                        current.H = h;
                        current.F = f;
                        current.Parent = pendingNode;
                        open.Add(current);
                    }
                    if (current.Equals(end))
                    {
                        List<Node> paths = new List<Node>();
                        Node path = end;
                        while (path.Parent != null)
                        {
                            paths.Add(path);
                            path = path.Parent;
                        }
                        open.Clear();
                        VisualizePath(paths);
                        break;
                    }                    
                }
                open = open.OrderBy(item => item.F).ToList();
            }

        }

    }
}
