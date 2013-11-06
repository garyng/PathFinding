namespace PathFinding
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cbWalls = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstWalls = new System.Windows.Forms.ListBox();
            this.pnlCon = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnVisual = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(9, 7);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(9, 20);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            // 
            // cbWalls
            // 
            this.cbWalls.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbWalls.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbWalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWalls.Location = new System.Drawing.Point(514, 7);
            this.cbWalls.Name = "cbWalls";
            this.cbWalls.Size = new System.Drawing.Size(83, 49);
            this.cbWalls.TabIndex = 8;
            this.cbWalls.Text = "Select Walls";
            this.cbWalls.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lstWalls);
            this.panel1.Controls.Add(this.pnlCon);
            this.panel1.Location = new System.Drawing.Point(30, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 402);
            this.panel1.TabIndex = 9;
            // 
            // lstWalls
            // 
            this.lstWalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWalls.FormattingEnabled = true;
            this.lstWalls.Location = new System.Drawing.Point(3, 293);
            this.lstWalls.Name = "lstWalls";
            this.lstWalls.Size = new System.Drawing.Size(564, 95);
            this.lstWalls.TabIndex = 9;
            // 
            // pnlCon
            // 
            this.pnlCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCon.AutoScroll = true;
            this.pnlCon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCon.Location = new System.Drawing.Point(3, 3);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(564, 284);
            this.pnlCon.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(425, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 48);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find Path";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnVisual
            // 
            this.btnVisual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVisual.Location = new System.Drawing.Point(333, 7);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(86, 49);
            this.btnVisual.TabIndex = 11;
            this.btnVisual.Text = "Visualize Nodes";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(9, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 477);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnVisual);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbWalls);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Path Finding";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.CheckBox cbWalls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstWalls;
        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnVisual;
        private System.Windows.Forms.Label lblTime;
    }
}

