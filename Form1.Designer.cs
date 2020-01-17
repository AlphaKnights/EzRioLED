namespace EzRioLED
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
            this.PowerLEDBox = new System.Windows.Forms.GroupBox();
            this.PowerLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.PowerLEDColorPicker = new System.Windows.Forms.ListBox();
            this.PowerLEDPattern = new System.Windows.Forms.Label();
            this.PowerLEDColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StatusLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.StatusLEDBox = new System.Windows.Forms.GroupBox();
            this.StatusLEDColorPicker = new System.Windows.Forms.ListBox();
            this.RadioLEDBox = new System.Windows.Forms.GroupBox();
            this.RadioLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.RadioLEDColorPicker = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommLEDBox = new System.Windows.Forms.GroupBox();
            this.CommLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.CommLEDColorPicker = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RSLLEDBox = new System.Windows.Forms.GroupBox();
            this.RSLLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.RSLLEDColorPicker = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeLEDBox = new System.Windows.Forms.GroupBox();
            this.ModeLEDPatternPicker = new System.Windows.Forms.ListBox();
            this.ModeLEDColorPicker = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ResponseOutputBox = new System.Windows.Forms.ListBox();
            this.PowerLEDBox.SuspendLayout();
            this.StatusLEDBox.SuspendLayout();
            this.RadioLEDBox.SuspendLayout();
            this.CommLEDBox.SuspendLayout();
            this.RSLLEDBox.SuspendLayout();
            this.ModeLEDBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerLEDBox
            // 
            this.PowerLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.PowerLEDBox.Controls.Add(this.PowerLEDPatternPicker);
            this.PowerLEDBox.Controls.Add(this.PowerLEDColorPicker);
            this.PowerLEDBox.Controls.Add(this.PowerLEDPattern);
            this.PowerLEDBox.Controls.Add(this.PowerLEDColor);
            this.PowerLEDBox.Location = new System.Drawing.Point(12, 11);
            this.PowerLEDBox.Name = "PowerLEDBox";
            this.PowerLEDBox.Size = new System.Drawing.Size(377, 285);
            this.PowerLEDBox.TabIndex = 0;
            this.PowerLEDBox.TabStop = false;
            this.PowerLEDBox.Text = "Power LED";
            // 
            // PowerLEDPatternPicker
            // 
            this.PowerLEDPatternPicker.FormattingEnabled = true;
            this.PowerLEDPatternPicker.ItemHeight = 37;
            this.PowerLEDPatternPicker.Location = new System.Drawing.Point(190, 83);
            this.PowerLEDPatternPicker.Name = "PowerLEDPatternPicker";
            this.PowerLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.PowerLEDPatternPicker.TabIndex = 3;
            // 
            // PowerLEDColorPicker
            // 
            this.PowerLEDColorPicker.FormattingEnabled = true;
            this.PowerLEDColorPicker.ItemHeight = 37;
            this.PowerLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.PowerLEDColorPicker.Name = "PowerLEDColorPicker";
            this.PowerLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.PowerLEDColorPicker.TabIndex = 2;
            // 
            // PowerLEDPattern
            // 
            this.PowerLEDPattern.Location = new System.Drawing.Point(211, 40);
            this.PowerLEDPattern.Name = "PowerLEDPattern";
            this.PowerLEDPattern.Size = new System.Drawing.Size(134, 40);
            this.PowerLEDPattern.TabIndex = 1;
            this.PowerLEDPattern.Text = "Pattern";
            this.PowerLEDPattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerLEDColor
            // 
            this.PowerLEDColor.Location = new System.Drawing.Point(31, 37);
            this.PowerLEDColor.Name = "PowerLEDColor";
            this.PowerLEDColor.Size = new System.Drawing.Size(100, 42);
            this.PowerLEDColor.TabIndex = 0;
            this.PowerLEDColor.Text = "Color";
            this.PowerLEDColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLEDPatternPicker
            // 
            this.StatusLEDPatternPicker.FormattingEnabled = true;
            this.StatusLEDPatternPicker.ItemHeight = 37;
            this.StatusLEDPatternPicker.Location = new System.Drawing.Point(162, 82);
            this.StatusLEDPatternPicker.Name = "StatusLEDPatternPicker";
            this.StatusLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.StatusLEDPatternPicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flashes/s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLEDBox
            // 
            this.StatusLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLEDBox.Controls.Add(this.StatusLEDPatternPicker);
            this.StatusLEDBox.Controls.Add(this.StatusLEDColorPicker);
            this.StatusLEDBox.Controls.Add(this.label1);
            this.StatusLEDBox.Controls.Add(this.label2);
            this.StatusLEDBox.Location = new System.Drawing.Point(395, 12);
            this.StatusLEDBox.Name = "StatusLEDBox";
            this.StatusLEDBox.Size = new System.Drawing.Size(377, 285);
            this.StatusLEDBox.TabIndex = 4;
            this.StatusLEDBox.TabStop = false;
            this.StatusLEDBox.Text = "Status LED";
            // 
            // StatusLEDColorPicker
            // 
            this.StatusLEDColorPicker.FormattingEnabled = true;
            this.StatusLEDColorPicker.ItemHeight = 37;
            this.StatusLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.StatusLEDColorPicker.Name = "StatusLEDColorPicker";
            this.StatusLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.StatusLEDColorPicker.TabIndex = 2;
            // 
            // RadioLEDBox
            // 
            this.RadioLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.RadioLEDBox.Controls.Add(this.RadioLEDPatternPicker);
            this.RadioLEDBox.Controls.Add(this.RadioLEDColorPicker);
            this.RadioLEDBox.Controls.Add(this.label3);
            this.RadioLEDBox.Controls.Add(this.label4);
            this.RadioLEDBox.Location = new System.Drawing.Point(778, 11);
            this.RadioLEDBox.Name = "RadioLEDBox";
            this.RadioLEDBox.Size = new System.Drawing.Size(365, 285);
            this.RadioLEDBox.TabIndex = 5;
            this.RadioLEDBox.TabStop = false;
            this.RadioLEDBox.Text = "Radio LED";
            // 
            // RadioLEDPatternPicker
            // 
            this.RadioLEDPatternPicker.FormattingEnabled = true;
            this.RadioLEDPatternPicker.ItemHeight = 37;
            this.RadioLEDPatternPicker.Location = new System.Drawing.Point(179, 83);
            this.RadioLEDPatternPicker.Name = "RadioLEDPatternPicker";
            this.RadioLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.RadioLEDPatternPicker.TabIndex = 3;
            // 
            // RadioLEDColorPicker
            // 
            this.RadioLEDColorPicker.FormattingEnabled = true;
            this.RadioLEDColorPicker.ItemHeight = 37;
            this.RadioLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.RadioLEDColorPicker.Name = "RadioLEDColorPicker";
            this.RadioLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.RadioLEDColorPicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(179, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pattern";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommLEDBox
            // 
            this.CommLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.CommLEDBox.Controls.Add(this.CommLEDPatternPicker);
            this.CommLEDBox.Controls.Add(this.CommLEDColorPicker);
            this.CommLEDBox.Controls.Add(this.label5);
            this.CommLEDBox.Controls.Add(this.label6);
            this.CommLEDBox.Location = new System.Drawing.Point(12, 302);
            this.CommLEDBox.Name = "CommLEDBox";
            this.CommLEDBox.Size = new System.Drawing.Size(377, 285);
            this.CommLEDBox.TabIndex = 6;
            this.CommLEDBox.TabStop = false;
            this.CommLEDBox.Text = "Comm LED";
            // 
            // CommLEDPatternPicker
            // 
            this.CommLEDPatternPicker.FormattingEnabled = true;
            this.CommLEDPatternPicker.ItemHeight = 37;
            this.CommLEDPatternPicker.Location = new System.Drawing.Point(190, 82);
            this.CommLEDPatternPicker.Name = "CommLEDPatternPicker";
            this.CommLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.CommLEDPatternPicker.TabIndex = 3;
            // 
            // CommLEDColorPicker
            // 
            this.CommLEDColorPicker.FormattingEnabled = true;
            this.CommLEDColorPicker.ItemHeight = 37;
            this.CommLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.CommLEDColorPicker.Name = "CommLEDColorPicker";
            this.CommLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.CommLEDColorPicker.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(211, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pattern";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Color";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RSLLEDBox
            // 
            this.RSLLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.RSLLEDBox.Controls.Add(this.RSLLEDPatternPicker);
            this.RSLLEDBox.Controls.Add(this.RSLLEDColorPicker);
            this.RSLLEDBox.Controls.Add(this.label7);
            this.RSLLEDBox.Controls.Add(this.label8);
            this.RSLLEDBox.Location = new System.Drawing.Point(778, 302);
            this.RSLLEDBox.Name = "RSLLEDBox";
            this.RSLLEDBox.Size = new System.Drawing.Size(365, 285);
            this.RSLLEDBox.TabIndex = 8;
            this.RSLLEDBox.TabStop = false;
            this.RSLLEDBox.Text = "RSL LED";
            // 
            // RSLLEDPatternPicker
            // 
            this.RSLLEDPatternPicker.FormattingEnabled = true;
            this.RSLLEDPatternPicker.ItemHeight = 37;
            this.RSLLEDPatternPicker.Location = new System.Drawing.Point(159, 82);
            this.RSLLEDPatternPicker.Name = "RSLLEDPatternPicker";
            this.RSLLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.RSLLEDPatternPicker.TabIndex = 3;
            // 
            // RSLLEDColorPicker
            // 
            this.RSLLEDColorPicker.FormattingEnabled = true;
            this.RSLLEDColorPicker.ItemHeight = 37;
            this.RSLLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.RSLLEDColorPicker.Name = "RSLLEDColorPicker";
            this.RSLLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.RSLLEDColorPicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(159, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pattern";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModeLEDBox
            // 
            this.ModeLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.ModeLEDBox.Controls.Add(this.ModeLEDPatternPicker);
            this.ModeLEDBox.Controls.Add(this.ModeLEDColorPicker);
            this.ModeLEDBox.Controls.Add(this.label9);
            this.ModeLEDBox.Controls.Add(this.label10);
            this.ModeLEDBox.Location = new System.Drawing.Point(395, 302);
            this.ModeLEDBox.Name = "ModeLEDBox";
            this.ModeLEDBox.Size = new System.Drawing.Size(377, 285);
            this.ModeLEDBox.TabIndex = 7;
            this.ModeLEDBox.TabStop = false;
            this.ModeLEDBox.Text = "Mode LED";
            // 
            // ModeLEDPatternPicker
            // 
            this.ModeLEDPatternPicker.FormattingEnabled = true;
            this.ModeLEDPatternPicker.ItemHeight = 37;
            this.ModeLEDPatternPicker.Location = new System.Drawing.Point(184, 82);
            this.ModeLEDPatternPicker.Name = "ModeLEDPatternPicker";
            this.ModeLEDPatternPicker.Size = new System.Drawing.Size(120, 78);
            this.ModeLEDPatternPicker.TabIndex = 3;
            // 
            // ModeLEDColorPicker
            // 
            this.ModeLEDColorPicker.FormattingEnabled = true;
            this.ModeLEDColorPicker.ItemHeight = 37;
            this.ModeLEDColorPicker.Location = new System.Drawing.Point(11, 82);
            this.ModeLEDColorPicker.Name = "ModeLEDColorPicker";
            this.ModeLEDColorPicker.Size = new System.Drawing.Size(120, 78);
            this.ModeLEDColorPicker.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(184, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pattern";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(31, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Color";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResponseOutputBox
            // 
            this.ResponseOutputBox.FormattingEnabled = true;
            this.ResponseOutputBox.ItemHeight = 37;
            this.ResponseOutputBox.Location = new System.Drawing.Point(12, 593);
            this.ResponseOutputBox.Name = "ResponseOutputBox";
            this.ResponseOutputBox.Size = new System.Drawing.Size(1129, 226);
            this.ResponseOutputBox.TabIndex = 9;
            // 
            // EzRioLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 833);
            this.Controls.Add(this.ResponseOutputBox);
            this.Controls.Add(this.RSLLEDBox);
            this.Controls.Add(this.CommLEDBox);
            this.Controls.Add(this.ModeLEDBox);
            this.Controls.Add(this.RadioLEDBox);
            this.Controls.Add(this.StatusLEDBox);
            this.Controls.Add(this.PowerLEDBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EzRioLED";
            this.Text = "EzRioLED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PowerLEDBox.ResumeLayout(false);
            this.StatusLEDBox.ResumeLayout(false);
            this.RadioLEDBox.ResumeLayout(false);
            this.CommLEDBox.ResumeLayout(false);
            this.RSLLEDBox.ResumeLayout(false);
            this.ModeLEDBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox PowerLEDBox;
        private System.Windows.Forms.Label PowerLEDColor;
        private System.Windows.Forms.Label PowerLEDPattern;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PowerLEDPatternPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ResponseOutputBox;
        private System.Windows.Forms.GroupBox StatusLEDBox;
        private System.Windows.Forms.GroupBox RadioLEDBox;
        private System.Windows.Forms.GroupBox CommLEDBox;
        private System.Windows.Forms.GroupBox ModeLEDBox;
        private System.Windows.Forms.GroupBox RSLLEDBox;
        private System.Windows.Forms.ListBox RadioLEDColorPicker;
        private System.Windows.Forms.ListBox StatusLEDPatternPicker;
        private System.Windows.Forms.ListBox StatusLEDColorPicker;
        private System.Windows.Forms.ListBox RSLLEDPatternPicker;
        private System.Windows.Forms.ListBox RSLLEDColorPicker;
        private System.Windows.Forms.ListBox ModeLEDPatternPicker;
        private System.Windows.Forms.ListBox ModeLEDColorPicker;
        private System.Windows.Forms.ListBox CommLEDColorPicker;
        private System.Windows.Forms.ListBox RadioLEDPatternPicker;
        private System.Windows.Forms.ListBox PowerLEDColorPicker;
        private System.Windows.Forms.ListBox CommLEDPatternPicker;
    }
}