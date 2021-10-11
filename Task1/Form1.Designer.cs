
namespace Task1
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRegularTriangle;
            System.Windows.Forms.Splitter splitter1;
            this.textBoxTriangleA = new System.Windows.Forms.TextBox();
            this.textBoxTriangleB = new System.Windows.Forms.TextBox();
            this.textBoxTriangleC = new System.Windows.Forms.TextBox();
            this.textBoxRegularTriangleA = new System.Windows.Forms.TextBox();
            this.textBoxRegularTriangleB = new System.Windows.Forms.TextBox();
            this.textBoxRegularTriangleC = new System.Windows.Forms.TextBox();
            this.textBoxRegularTriangleArea = new System.Windows.Forms.TextBox();
            this.labelRegularTriangleInfo = new System.Windows.Forms.Label();
            this.labelTriangleInfo = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            flowLayoutPanelRegularTriangle = new System.Windows.Forms.FlowLayoutPanel();
            splitter1 = new System.Windows.Forms.Splitter();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanelRegularTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(this.textBoxTriangleA);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(this.textBoxTriangleB);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(this.textBoxTriangleC);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1093, 39);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 33);
            label1.TabIndex = 0;
            label1.Text = "Triangle:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Left;
            label2.Location = new System.Drawing.Point(74, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 33);
            label2.TabIndex = 3;
            label2.Text = "A=";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTriangleA
            // 
            this.textBoxTriangleA.Location = new System.Drawing.Point(109, 3);
            this.textBoxTriangleA.Name = "textBoxTriangleA";
            this.textBoxTriangleA.Size = new System.Drawing.Size(200, 27);
            this.textBoxTriangleA.TabIndex = 4;
            this.textBoxTriangleA.TextChanged += new System.EventHandler(this.CalculateTriangle);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.Location = new System.Drawing.Point(315, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 33);
            label3.TabIndex = 5;
            label3.Text = "B=";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTriangleB
            // 
            this.textBoxTriangleB.Location = new System.Drawing.Point(349, 3);
            this.textBoxTriangleB.Name = "textBoxTriangleB";
            this.textBoxTriangleB.Size = new System.Drawing.Size(200, 27);
            this.textBoxTriangleB.TabIndex = 6;
            this.textBoxTriangleB.TextChanged += new System.EventHandler(this.CalculateTriangle);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Left;
            label4.Location = new System.Drawing.Point(555, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 33);
            label4.TabIndex = 7;
            label4.Text = "C=";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTriangleC
            // 
            this.textBoxTriangleC.Location = new System.Drawing.Point(589, 3);
            this.textBoxTriangleC.Name = "textBoxTriangleC";
            this.textBoxTriangleC.Size = new System.Drawing.Size(200, 27);
            this.textBoxTriangleC.TabIndex = 8;
            this.textBoxTriangleC.TextChanged += new System.EventHandler(this.CalculateTriangle);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Left;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 33);
            label5.TabIndex = 9;
            label5.Text = "RegularTriangle:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Left;
            label6.Location = new System.Drawing.Point(125, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 33);
            label6.TabIndex = 10;
            label6.Text = "A=";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Left;
            label7.Location = new System.Drawing.Point(366, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(28, 33);
            label7.TabIndex = 12;
            label7.Text = "B=";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Left;
            label8.Location = new System.Drawing.Point(606, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(28, 33);
            label8.TabIndex = 14;
            label8.Text = "C=";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Left;
            label9.Location = new System.Drawing.Point(846, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(27, 33);
            label9.TabIndex = 16;
            label9.Text = "S=";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelRegularTriangle
            // 
            flowLayoutPanelRegularTriangle.AutoSize = true;
            flowLayoutPanelRegularTriangle.Controls.Add(label5);
            flowLayoutPanelRegularTriangle.Controls.Add(label6);
            flowLayoutPanelRegularTriangle.Controls.Add(this.textBoxRegularTriangleA);
            flowLayoutPanelRegularTriangle.Controls.Add(label7);
            flowLayoutPanelRegularTriangle.Controls.Add(this.textBoxRegularTriangleB);
            flowLayoutPanelRegularTriangle.Controls.Add(label8);
            flowLayoutPanelRegularTriangle.Controls.Add(this.textBoxRegularTriangleC);
            flowLayoutPanelRegularTriangle.Controls.Add(label9);
            flowLayoutPanelRegularTriangle.Controls.Add(this.textBoxRegularTriangleArea);
            flowLayoutPanelRegularTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanelRegularTriangle.Location = new System.Drawing.Point(0, 76);
            flowLayoutPanelRegularTriangle.Name = "flowLayoutPanelRegularTriangle";
            flowLayoutPanelRegularTriangle.Size = new System.Drawing.Size(1093, 33);
            flowLayoutPanelRegularTriangle.TabIndex = 10;
            // 
            // textBoxRegularTriangleA
            // 
            this.textBoxRegularTriangleA.Location = new System.Drawing.Point(160, 3);
            this.textBoxRegularTriangleA.Name = "textBoxRegularTriangleA";
            this.textBoxRegularTriangleA.Size = new System.Drawing.Size(200, 27);
            this.textBoxRegularTriangleA.TabIndex = 11;
            this.textBoxRegularTriangleA.TextChanged += new System.EventHandler(this.textBoxRegularTriangleA_TextChanged);
            // 
            // textBoxRegularTriangleB
            // 
            this.textBoxRegularTriangleB.Location = new System.Drawing.Point(400, 3);
            this.textBoxRegularTriangleB.Name = "textBoxRegularTriangleB";
            this.textBoxRegularTriangleB.Size = new System.Drawing.Size(200, 27);
            this.textBoxRegularTriangleB.TabIndex = 13;
            this.textBoxRegularTriangleB.TextChanged += new System.EventHandler(this.textBoxRegularTriangleB_TextChanged);
            // 
            // textBoxRegularTriangleC
            // 
            this.textBoxRegularTriangleC.Location = new System.Drawing.Point(640, 3);
            this.textBoxRegularTriangleC.Name = "textBoxRegularTriangleC";
            this.textBoxRegularTriangleC.Size = new System.Drawing.Size(200, 27);
            this.textBoxRegularTriangleC.TabIndex = 15;
            this.textBoxRegularTriangleC.TextChanged += new System.EventHandler(this.textBoxRegularTriangleC_TextChanged);
            // 
            // textBoxRegularTriangleArea
            // 
            this.textBoxRegularTriangleArea.Location = new System.Drawing.Point(879, 3);
            this.textBoxRegularTriangleArea.Name = "textBoxRegularTriangleArea";
            this.textBoxRegularTriangleArea.Size = new System.Drawing.Size(200, 27);
            this.textBoxRegularTriangleArea.TabIndex = 17;
            this.textBoxRegularTriangleArea.TextChanged += new System.EventHandler(this.textBoxRegularTriangleArea_TextChanged);
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 72);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1093, 4);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // labelRegularTriangleInfo
            // 
            this.labelRegularTriangleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRegularTriangleInfo.Location = new System.Drawing.Point(0, 109);
            this.labelRegularTriangleInfo.Name = "labelRegularTriangleInfo";
            this.labelRegularTriangleInfo.Size = new System.Drawing.Size(1093, 33);
            this.labelRegularTriangleInfo.TabIndex = 11;
            this.labelRegularTriangleInfo.Text = "labelRegularTriangleInfo";
            this.labelRegularTriangleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTriangleInfo
            // 
            this.labelTriangleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTriangleInfo.Location = new System.Drawing.Point(0, 39);
            this.labelTriangleInfo.Name = "labelTriangleInfo";
            this.labelTriangleInfo.Size = new System.Drawing.Size(1093, 33);
            this.labelTriangleInfo.TabIndex = 9;
            this.labelTriangleInfo.Text = "labelTriangleInfo";
            this.labelTriangleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 143);
            this.Controls.Add(this.labelRegularTriangleInfo);
            this.Controls.Add(flowLayoutPanelRegularTriangle);
            this.Controls.Add(splitter1);
            this.Controls.Add(this.labelTriangleInfo);
            this.Controls.Add(flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "Task1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanelRegularTriangle.ResumeLayout(false);
            flowLayoutPanelRegularTriangle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTriangleInfo;
        private System.Windows.Forms.TextBox textBoxTriangleA;
        private System.Windows.Forms.TextBox textBoxTriangleB;
        private System.Windows.Forms.TextBox textBoxTriangleC;
        private System.Windows.Forms.TextBox textBoxRegularTriangleA;
        private System.Windows.Forms.TextBox textBoxRegularTriangleB;
        private System.Windows.Forms.TextBox textBoxRegularTriangleC;
        private System.Windows.Forms.TextBox textBoxRegularTriangleArea;
        private System.Windows.Forms.Label labelRegularTriangleInfo;
    }
}

