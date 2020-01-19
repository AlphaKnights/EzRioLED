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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.roborioImage = new System.Windows.Forms.PictureBox();
            this.ModeLED = new System.Windows.Forms.PictureBox();
            this.RSLLed = new System.Windows.Forms.PictureBox();
            this.CommLED = new System.Windows.Forms.PictureBox();
            this.RadioLED = new System.Windows.Forms.PictureBox();
            this.StatusLED = new System.Windows.Forms.PictureBox();
            this.PowerLED = new System.Windows.Forms.PictureBox();
            this.Creditsbox = new System.Windows.Forms.TextBox();
            this.closeCreditsButton = new System.Windows.Forms.Button();
            this.rightSideBox = new System.Windows.Forms.ListBox();
            this.leftSideBox = new System.Windows.Forms.ListBox();
            this.PowerLEDBox.SuspendLayout();
            this.StatusLEDBox.SuspendLayout();
            this.RadioLEDBox.SuspendLayout();
            this.CommLEDBox.SuspendLayout();
            this.RSLLEDBox.SuspendLayout();
            this.ModeLEDBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roborioImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSLLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLED)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerLEDBox
            // 
            this.PowerLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.PowerLEDBox.Controls.Add(this.PowerLEDPatternPicker);
            this.PowerLEDBox.Controls.Add(this.PowerLEDColorPicker);
            this.PowerLEDBox.Controls.Add(this.PowerLEDPattern);
            this.PowerLEDBox.Controls.Add(this.PowerLEDColor);
            this.PowerLEDBox.Location = new System.Drawing.Point(5, 4);
            this.PowerLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.PowerLEDBox.Name = "PowerLEDBox";
            this.PowerLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.PowerLEDBox.Size = new System.Drawing.Size(151, 100);
            this.PowerLEDBox.TabIndex = 0;
            this.PowerLEDBox.TabStop = false;
            this.PowerLEDBox.Text = "Power LED";
            // 
            // PowerLEDPatternPicker
            // 
            this.PowerLEDPatternPicker.FormattingEnabled = true;
            this.PowerLEDPatternPicker.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Flashing"});
            this.PowerLEDPatternPicker.Location = new System.Drawing.Point(76, 29);
            this.PowerLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.PowerLEDPatternPicker.Name = "PowerLEDPatternPicker";
            this.PowerLEDPatternPicker.Size = new System.Drawing.Size(50, 43);
            this.PowerLEDPatternPicker.TabIndex = 3;
            // 
            // PowerLEDColorPicker
            // 
            this.PowerLEDColorPicker.FormattingEnabled = true;
            this.PowerLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Green",
            "Red",
            "Yellow"});
            this.PowerLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.PowerLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.PowerLEDColorPicker.Name = "PowerLEDColorPicker";
            this.PowerLEDColorPicker.Size = new System.Drawing.Size(50, 56);
            this.PowerLEDColorPicker.TabIndex = 2;
            // 
            // PowerLEDPattern
            // 
            this.PowerLEDPattern.Location = new System.Drawing.Point(84, 14);
            this.PowerLEDPattern.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PowerLEDPattern.Name = "PowerLEDPattern";
            this.PowerLEDPattern.Size = new System.Drawing.Size(54, 14);
            this.PowerLEDPattern.TabIndex = 1;
            this.PowerLEDPattern.Text = "Pattern";
            this.PowerLEDPattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerLEDColor
            // 
            this.PowerLEDColor.Location = new System.Drawing.Point(12, 13);
            this.PowerLEDColor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PowerLEDColor.Name = "PowerLEDColor";
            this.PowerLEDColor.Size = new System.Drawing.Size(40, 15);
            this.PowerLEDColor.TabIndex = 0;
            this.PowerLEDColor.Text = "Color";
            this.PowerLEDColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLEDPatternPicker
            // 
            this.StatusLEDPatternPicker.FormattingEnabled = true;
            this.StatusLEDPatternPicker.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "Fast/Solid"});
            this.StatusLEDPatternPicker.Location = new System.Drawing.Point(65, 29);
            this.StatusLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.StatusLEDPatternPicker.Name = "StatusLEDPatternPicker";
            this.StatusLEDPatternPicker.Size = new System.Drawing.Size(59, 56);
            this.StatusLEDPatternPicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flashes/s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
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
            this.StatusLEDBox.Location = new System.Drawing.Point(158, 4);
            this.StatusLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.StatusLEDBox.Name = "StatusLEDBox";
            this.StatusLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.StatusLEDBox.Size = new System.Drawing.Size(151, 100);
            this.StatusLEDBox.TabIndex = 4;
            this.StatusLEDBox.TabStop = false;
            this.StatusLEDBox.Text = "Status LED";
            // 
            // StatusLEDColorPicker
            // 
            this.StatusLEDColorPicker.FormattingEnabled = true;
            this.StatusLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Yellow"});
            this.StatusLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.StatusLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.StatusLEDColorPicker.Name = "StatusLEDColorPicker";
            this.StatusLEDColorPicker.Size = new System.Drawing.Size(50, 30);
            this.StatusLEDColorPicker.TabIndex = 2;
            // 
            // RadioLEDBox
            // 
            this.RadioLEDBox.BackColor = System.Drawing.SystemColors.Control;
            this.RadioLEDBox.Controls.Add(this.RadioLEDPatternPicker);
            this.RadioLEDBox.Controls.Add(this.RadioLEDColorPicker);
            this.RadioLEDBox.Controls.Add(this.label3);
            this.RadioLEDBox.Controls.Add(this.label4);
            this.RadioLEDBox.Location = new System.Drawing.Point(311, 4);
            this.RadioLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.RadioLEDBox.Name = "RadioLEDBox";
            this.RadioLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.RadioLEDBox.Size = new System.Drawing.Size(146, 100);
            this.RadioLEDBox.TabIndex = 5;
            this.RadioLEDBox.TabStop = false;
            this.RadioLEDBox.Text = "Radio LED";
            // 
            // RadioLEDPatternPicker
            // 
            this.RadioLEDPatternPicker.FormattingEnabled = true;
            this.RadioLEDPatternPicker.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Blinking"});
            this.RadioLEDPatternPicker.Location = new System.Drawing.Point(72, 29);
            this.RadioLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.RadioLEDPatternPicker.Name = "RadioLEDPatternPicker";
            this.RadioLEDPatternPicker.Size = new System.Drawing.Size(50, 43);
            this.RadioLEDPatternPicker.TabIndex = 3;
            // 
            // RadioLEDColorPicker
            // 
            this.RadioLEDColorPicker.FormattingEnabled = true;
            this.RadioLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Green",
            "Red",
            "Yellow"});
            this.RadioLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.RadioLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.RadioLEDColorPicker.Name = "RadioLEDColorPicker";
            this.RadioLEDColorPicker.Size = new System.Drawing.Size(50, 56);
            this.RadioLEDColorPicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(72, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pattern";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
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
            this.CommLEDBox.Location = new System.Drawing.Point(5, 106);
            this.CommLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.CommLEDBox.Name = "CommLEDBox";
            this.CommLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.CommLEDBox.Size = new System.Drawing.Size(151, 100);
            this.CommLEDBox.TabIndex = 6;
            this.CommLEDBox.TabStop = false;
            this.CommLEDBox.Text = "Comm LED";
            // 
            // CommLEDPatternPicker
            // 
            this.CommLEDPatternPicker.FormattingEnabled = true;
            this.CommLEDPatternPicker.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Blinking"});
            this.CommLEDPatternPicker.Location = new System.Drawing.Point(76, 29);
            this.CommLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.CommLEDPatternPicker.Name = "CommLEDPatternPicker";
            this.CommLEDPatternPicker.Size = new System.Drawing.Size(50, 43);
            this.CommLEDPatternPicker.TabIndex = 3;
            // 
            // CommLEDColorPicker
            // 
            this.CommLEDColorPicker.FormattingEnabled = true;
            this.CommLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Green",
            "Red",
            "Yellow"});
            this.CommLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.CommLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.CommLEDColorPicker.Name = "CommLEDColorPicker";
            this.CommLEDColorPicker.Size = new System.Drawing.Size(50, 56);
            this.CommLEDColorPicker.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(84, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pattern";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
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
            this.RSLLEDBox.Location = new System.Drawing.Point(311, 106);
            this.RSLLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.RSLLEDBox.Name = "RSLLEDBox";
            this.RSLLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.RSLLEDBox.Size = new System.Drawing.Size(146, 100);
            this.RSLLEDBox.TabIndex = 8;
            this.RSLLEDBox.TabStop = false;
            this.RSLLEDBox.Text = "RSL LED";
            // 
            // RSLLEDPatternPicker
            // 
            this.RSLLEDPatternPicker.FormattingEnabled = true;
            this.RSLLEDPatternPicker.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Blinking"});
            this.RSLLEDPatternPicker.Location = new System.Drawing.Point(64, 29);
            this.RSLLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.RSLLEDPatternPicker.Name = "RSLLEDPatternPicker";
            this.RSLLEDPatternPicker.Size = new System.Drawing.Size(50, 43);
            this.RSLLEDPatternPicker.TabIndex = 3;
            // 
            // RSLLEDColorPicker
            // 
            this.RSLLEDColorPicker.FormattingEnabled = true;
            this.RSLLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Yellow"});
            this.RSLLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.RSLLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.RSLLEDColorPicker.Name = "RSLLEDColorPicker";
            this.RSLLEDColorPicker.Size = new System.Drawing.Size(50, 30);
            this.RSLLEDColorPicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pattern";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
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
            this.ModeLEDBox.Location = new System.Drawing.Point(158, 106);
            this.ModeLEDBox.Margin = new System.Windows.Forms.Padding(1);
            this.ModeLEDBox.Name = "ModeLEDBox";
            this.ModeLEDBox.Padding = new System.Windows.Forms.Padding(1);
            this.ModeLEDBox.Size = new System.Drawing.Size(151, 100);
            this.ModeLEDBox.TabIndex = 7;
            this.ModeLEDBox.TabStop = false;
            this.ModeLEDBox.Text = "Mode LED";
            // 
            // ModeLEDPatternPicker
            // 
            this.ModeLEDPatternPicker.FormattingEnabled = true;
            this.ModeLEDPatternPicker.Items.AddRange(new object[] {
            "Off",
            "Solid"});
            this.ModeLEDPatternPicker.Location = new System.Drawing.Point(74, 29);
            this.ModeLEDPatternPicker.Margin = new System.Windows.Forms.Padding(1);
            this.ModeLEDPatternPicker.Name = "ModeLEDPatternPicker";
            this.ModeLEDPatternPicker.Size = new System.Drawing.Size(50, 30);
            this.ModeLEDPatternPicker.TabIndex = 3;
            // 
            // ModeLEDColorPicker
            // 
            this.ModeLEDColorPicker.FormattingEnabled = true;
            this.ModeLEDColorPicker.Items.AddRange(new object[] {
            "Off",
            "Green",
            "Red",
            "Yellow"});
            this.ModeLEDColorPicker.Location = new System.Drawing.Point(4, 29);
            this.ModeLEDColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.ModeLEDColorPicker.Name = "ModeLEDColorPicker";
            this.ModeLEDColorPicker.Size = new System.Drawing.Size(50, 56);
            this.ModeLEDColorPicker.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(74, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pattern";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Color";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResponseOutputBox
            // 
            this.ResponseOutputBox.FormattingEnabled = true;
            this.ResponseOutputBox.Location = new System.Drawing.Point(5, 208);
            this.ResponseOutputBox.Margin = new System.Windows.Forms.Padding(1);
            this.ResponseOutputBox.Name = "ResponseOutputBox";
            this.ResponseOutputBox.Size = new System.Drawing.Size(454, 82);
            this.ResponseOutputBox.TabIndex = 9;
            // 
            // roborioImage
            // 
            this.roborioImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("roborioImage.ErrorImage")));
            this.roborioImage.Image = ((System.Drawing.Image)(resources.GetObject("roborioImage.Image")));
            this.roborioImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("roborioImage.InitialImage")));
            this.roborioImage.Location = new System.Drawing.Point(463, -5);
            this.roborioImage.Name = "roborioImage";
            this.roborioImage.Size = new System.Drawing.Size(164, 295);
            this.roborioImage.TabIndex = 11;
            this.roborioImage.TabStop = false;
            this.roborioImage.Click += new System.EventHandler(this.roborioImage_Click);
            // 
            // ModeLED
            // 
            this.ModeLED.Location = new System.Drawing.Point(567, 201);
            this.ModeLED.Name = "ModeLED";
            this.ModeLED.Size = new System.Drawing.Size(44, 17);
            this.ModeLED.TabIndex = 12;
            this.ModeLED.TabStop = false;
            // 
            // RSLLed
            // 
            this.RSLLed.Location = new System.Drawing.Point(567, 260);
            this.RSLLed.Name = "RSLLed";
            this.RSLLed.Size = new System.Drawing.Size(44, 21);
            this.RSLLed.TabIndex = 13;
            this.RSLLed.TabStop = false;
            // 
            // CommLED
            // 
            this.CommLED.Location = new System.Drawing.Point(567, 160);
            this.CommLED.Name = "CommLED";
            this.CommLED.Size = new System.Drawing.Size(44, 18);
            this.CommLED.TabIndex = 14;
            this.CommLED.TabStop = false;
            // 
            // RadioLED
            // 
            this.RadioLED.Location = new System.Drawing.Point(567, 120);
            this.RadioLED.Name = "RadioLED";
            this.RadioLED.Size = new System.Drawing.Size(44, 14);
            this.RadioLED.TabIndex = 15;
            this.RadioLED.TabStop = false;
            // 
            // StatusLED
            // 
            this.StatusLED.Location = new System.Drawing.Point(567, 59);
            this.StatusLED.Name = "StatusLED";
            this.StatusLED.Size = new System.Drawing.Size(44, 17);
            this.StatusLED.TabIndex = 16;
            this.StatusLED.TabStop = false;
            // 
            // PowerLED
            // 
            this.PowerLED.Location = new System.Drawing.Point(567, 18);
            this.PowerLED.Name = "PowerLED";
            this.PowerLED.Size = new System.Drawing.Size(44, 16);
            this.PowerLED.TabIndex = 17;
            this.PowerLED.TabStop = false;
            // 
            // Creditsbox
            // 
            this.Creditsbox.Location = new System.Drawing.Point(463, 184);
            this.Creditsbox.Multiline = true;
            this.Creditsbox.Name = "Creditsbox";
            this.Creditsbox.ReadOnly = true;
            this.Creditsbox.Size = new System.Drawing.Size(622, 252);
            this.Creditsbox.TabIndex = 18;
            this.Creditsbox.Text = resources.GetString("Creditsbox.Text");
            this.Creditsbox.Visible = false;
            // 
            // closeCreditsButton
            // 
            this.closeCreditsButton.Location = new System.Drawing.Point(249, 260);
            this.closeCreditsButton.Name = "closeCreditsButton";
            this.closeCreditsButton.Size = new System.Drawing.Size(114, 23);
            this.closeCreditsButton.TabIndex = 19;
            this.closeCreditsButton.Text = "Click to Close";
            this.closeCreditsButton.UseVisualStyleBackColor = true;
            this.closeCreditsButton.Visible = false;
            this.closeCreditsButton.Click += new System.EventHandler(this.closeCreditsButton_Click);
            // 
            // rightSideBox
            // 
            this.rightSideBox.FormattingEnabled = true;
            this.rightSideBox.Location = new System.Drawing.Point(369, 247);
            this.rightSideBox.Name = "rightSideBox";
            this.rightSideBox.Size = new System.Drawing.Size(258, 43);
            this.rightSideBox.TabIndex = 20;
            this.rightSideBox.Visible = false;
            // 
            // leftSideBox
            // 
            this.leftSideBox.FormattingEnabled = true;
            this.leftSideBox.Location = new System.Drawing.Point(5, 247);
            this.leftSideBox.Name = "leftSideBox";
            this.leftSideBox.Size = new System.Drawing.Size(238, 43);
            this.leftSideBox.TabIndex = 21;
            this.leftSideBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 293);
            this.Controls.Add(this.leftSideBox);
            this.Controls.Add(this.rightSideBox);
            this.Controls.Add(this.closeCreditsButton);
            this.Controls.Add(this.Creditsbox);
            this.Controls.Add(this.PowerLED);
            this.Controls.Add(this.StatusLED);
            this.Controls.Add(this.RadioLED);
            this.Controls.Add(this.CommLED);
            this.Controls.Add(this.RSLLed);
            this.Controls.Add(this.ModeLED);
            this.Controls.Add(this.roborioImage);
            this.Controls.Add(this.ResponseOutputBox);
            this.Controls.Add(this.RSLLEDBox);
            this.Controls.Add(this.CommLEDBox);
            this.Controls.Add(this.ModeLEDBox);
            this.Controls.Add(this.RadioLEDBox);
            this.Controls.Add(this.StatusLEDBox);
            this.Controls.Add(this.PowerLEDBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "RioLEDebug";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PowerLEDBox.ResumeLayout(false);
            this.StatusLEDBox.ResumeLayout(false);
            this.RadioLEDBox.ResumeLayout(false);
            this.CommLEDBox.ResumeLayout(false);
            this.RSLLEDBox.ResumeLayout(false);
            this.ModeLEDBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roborioImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSLLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox roborioImage;
        private System.Windows.Forms.PictureBox ModeLED;
        private System.Windows.Forms.PictureBox RSLLed;
        private System.Windows.Forms.PictureBox CommLED;
        private System.Windows.Forms.PictureBox RadioLED;
        private System.Windows.Forms.PictureBox StatusLED;
        private System.Windows.Forms.PictureBox PowerLED;
        private System.Windows.Forms.TextBox Creditsbox;
        private System.Windows.Forms.Button closeCreditsButton;
        private System.Windows.Forms.ListBox rightSideBox;
        private System.Windows.Forms.ListBox leftSideBox;
    }
}