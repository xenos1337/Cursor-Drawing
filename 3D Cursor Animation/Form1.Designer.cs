namespace _3D_Cursor_Animation
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.curX = new System.Windows.Forms.Label();
            this.curY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 512);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // curX
            // 
            this.curX.AutoSize = true;
            this.curX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curX.Location = new System.Drawing.Point(12, 530);
            this.curX.Name = "curX";
            this.curX.Size = new System.Drawing.Size(67, 19);
            this.curX.TabIndex = 1;
            this.curX.Text = "Cursor X:";
            // 
            // curY
            // 
            this.curY.AutoSize = true;
            this.curY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curY.Location = new System.Drawing.Point(12, 550);
            this.curY.Name = "curY";
            this.curY.Size = new System.Drawing.Size(66, 19);
            this.curY.TabIndex = 2;
            this.curY.Text = "Cursor Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.curY);
            this.Controls.Add(this.curX);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label curX;
        private System.Windows.Forms.Label curY;
        private System.Windows.Forms.Button button1;
    }
}

