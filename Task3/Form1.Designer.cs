
namespace Task3
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.textBoxRightA = new System.Windows.Forms.TextBox();
            this.textBoxRightB = new System.Windows.Forms.TextBox();
            this.textBoxIsoscelesA = new System.Windows.Forms.TextBox();
            this.textBoxIsoscelesGamma = new System.Windows.Forms.TextBox();
            this.labelRightInfo = new System.Windows.Forms.Label();
            this.labelIsoscelesInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::Task3.Properties.Resources.RightTriangle;
            pictureBox1.Location = new System.Drawing.Point(137, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(447, 539);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::Task3.Properties.Resources.IsoscelesTriangle;
            pictureBox2.Location = new System.Drawing.Point(609, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(940, 539);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 20);
            label1.TabIndex = 6;
            label1.Text = "A=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(249, 518);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 20);
            label2.TabIndex = 7;
            label2.Text = "B=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(710, 222);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 20);
            label3.TabIndex = 8;
            label3.Text = "A=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(975, 157);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 20);
            label4.TabIndex = 9;
            label4.Text = "γ=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(1132, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(15, 20);
            label5.TabIndex = 10;
            label5.Text = "°";
            // 
            // textBoxRightA
            // 
            this.textBoxRightA.Location = new System.Drawing.Point(35, 247);
            this.textBoxRightA.Name = "textBoxRightA";
            this.textBoxRightA.Size = new System.Drawing.Size(125, 27);
            this.textBoxRightA.TabIndex = 2;
            this.textBoxRightA.TextChanged += new System.EventHandler(this.textBoxRight_TextChanged);
            // 
            // textBoxRightB
            // 
            this.textBoxRightB.Location = new System.Drawing.Point(279, 515);
            this.textBoxRightB.Name = "textBoxRightB";
            this.textBoxRightB.Size = new System.Drawing.Size(125, 27);
            this.textBoxRightB.TabIndex = 3;
            this.textBoxRightB.TextChanged += new System.EventHandler(this.textBoxRight_TextChanged);
            // 
            // textBoxIsoscelesA
            // 
            this.textBoxIsoscelesA.Location = new System.Drawing.Point(742, 219);
            this.textBoxIsoscelesA.Name = "textBoxIsoscelesA";
            this.textBoxIsoscelesA.Size = new System.Drawing.Size(125, 27);
            this.textBoxIsoscelesA.TabIndex = 4;
            this.textBoxIsoscelesA.TextChanged += new System.EventHandler(this.textBoxIsosceles_TextChanged);
            // 
            // textBoxIsoscelesGamma
            // 
            this.textBoxIsoscelesGamma.Location = new System.Drawing.Point(1005, 154);
            this.textBoxIsoscelesGamma.Name = "textBoxIsoscelesGamma";
            this.textBoxIsoscelesGamma.Size = new System.Drawing.Size(125, 27);
            this.textBoxIsoscelesGamma.TabIndex = 5;
            this.textBoxIsoscelesGamma.TextChanged += new System.EventHandler(this.textBoxIsosceles_TextChanged);
            // 
            // labelRightInfo
            // 
            this.labelRightInfo.Location = new System.Drawing.Point(4, 568);
            this.labelRightInfo.Name = "labelRightInfo";
            this.labelRightInfo.Size = new System.Drawing.Size(545, 25);
            this.labelRightInfo.TabIndex = 11;
            // 
            // labelIsoscelesInfo
            // 
            this.labelIsoscelesInfo.Location = new System.Drawing.Point(648, 568);
            this.labelIsoscelesInfo.Name = "labelIsoscelesInfo";
            this.labelIsoscelesInfo.Size = new System.Drawing.Size(847, 25);
            this.labelIsoscelesInfo.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(593, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 664);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1518, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIsoscelesInfo);
            this.Controls.Add(this.labelRightInfo);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxIsoscelesGamma);
            this.Controls.Add(this.textBoxIsoscelesA);
            this.Controls.Add(this.textBoxRightB);
            this.Controls.Add(this.textBoxRightA);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRightA;
        private System.Windows.Forms.TextBox textBoxRightB;
        private System.Windows.Forms.TextBox textBoxIsoscelesA;
        private System.Windows.Forms.TextBox textBoxIsoscelesGamma;
        private System.Windows.Forms.Label labelRightInfo;
        private System.Windows.Forms.Label labelIsoscelesInfo;
        private System.Windows.Forms.Panel panel1;
    }
}

