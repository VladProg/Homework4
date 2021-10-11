
namespace Task2
{
    partial class Form1
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label2;
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.labelParameters = new System.Windows.Forms.Label();
            this.flowLayoutPanelParameters = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInfo = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanelParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(this.comboBoxShape);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(531, 34);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Left;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 34);
            label2.TabIndex = 1;
            label2.Text = "shape:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Triangle",
            "Disk",
            "Rectangle",
            "Square",
            "Rhombus"});
            this.comboBoxShape.Location = new System.Drawing.Point(60, 3);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(151, 28);
            this.comboBoxShape.TabIndex = 0;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // labelParameters
            // 
            this.labelParameters.AutoSize = true;
            this.labelParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelParameters.Location = new System.Drawing.Point(3, 0);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(97, 20);
            this.labelParameters.TabIndex = 1;
            this.labelParameters.Text = "parameter(s):";
            this.labelParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelParameters
            // 
            this.flowLayoutPanelParameters.AutoSize = true;
            this.flowLayoutPanelParameters.Controls.Add(this.labelParameters);
            this.flowLayoutPanelParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelParameters.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanelParameters.Name = "flowLayoutPanelParameters";
            this.flowLayoutPanelParameters.Size = new System.Drawing.Size(531, 20);
            this.flowLayoutPanelParameters.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfo.Location = new System.Drawing.Point(0, 54);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 20);
            this.labelInfo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 95);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.flowLayoutPanelParameters);
            this.Controls.Add(flowLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(10000, 142);
            this.MinimumSize = new System.Drawing.Size(549, 142);
            this.Name = "Form1";
            this.Text = "Task2";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanelParameters.ResumeLayout(false);
            this.flowLayoutPanelParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelParameters;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelParameters;
    }
}

