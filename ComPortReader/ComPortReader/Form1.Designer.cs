namespace QRCodeCreator
{
    partial class frmQRCoder
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtArduino = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ReadPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arduino Text";
            // 
            // txtArduino
            // 
            this.txtArduino.Location = new System.Drawing.Point(93, 27);
            this.txtArduino.Multiline = true;
            this.txtArduino.Name = "txtArduino";
            this.txtArduino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArduino.Size = new System.Drawing.Size(324, 163);
            this.txtArduino.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReadPort
            // 
            this.ReadPort.Location = new System.Drawing.Point(12, 60);
            this.ReadPort.Name = "ReadPort";
            this.ReadPort.Size = new System.Drawing.Size(75, 23);
            this.ReadPort.TabIndex = 3;
            this.ReadPort.Text = "Port Read";
            this.ReadPort.UseVisualStyleBackColor = true;
            this.ReadPort.Click += new System.EventHandler(this.ReadPort_Click);
            // 
            // frmQRCoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 203);
            this.Controls.Add(this.ReadPort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtArduino);
            this.Controls.Add(this.label1);
            this.Name = "frmQRCoder";
            this.Text = "COM5 Port Reader Code";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQRCoder_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArduino;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button ReadPort;
    }
}

