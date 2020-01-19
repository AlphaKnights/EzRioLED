using System;
using System.Windows.Forms;
using System.Drawing;

namespace EzRioLED
{
    public partial class Form1 : Form
    {
        Timer loop = new Timer();
        Timer Power = new Timer();
        Timer Status = new Timer();
        Timer Radio = new Timer();
        Timer Comm = new Timer();
        Timer Mode = new Timer();
        Timer RSL = new Timer();

        static bool powerEnabled = false;
        static bool statusEnabled = false;
        static int statusBlinkState = 0;
        static bool radioEnabled = false;
        static bool commEnabled = false;
        static bool rslEnabled = false;

        static int powerState;
        static int statusState;
        static int radioState;
        static int modeState;
        static int commState;
        static int rslState;

        string[] responseBox = new string[] { " ", " ", " ", " ", " ", " " };

        //not sure where this is gonna go yet but ok
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            PowerLEDColorPicker.EnabledChanged += PowerLEDColorPicker_EnabledChanged;

            loop.Interval = 50;
            Power.Interval = 400;
            Status.Interval = 400;
            Radio.Interval = 400;
            Comm.Interval = 400;
            Mode.Interval = 50;
            RSL.Interval = 400;

            loop.Tick += new EventHandler(Loop);
            Power.Tick += new EventHandler(powerUpdate);
            Status.Tick += new EventHandler(statusUpdate);
            Radio.Tick += new EventHandler(radioUpdate);
            Comm.Tick += new EventHandler(commUpdate);
            Mode.Tick += new EventHandler(modeUpdate);
            RSL.Tick += new EventHandler(rslUpdate);

            loop.Enabled = true;
            Power.Enabled = true;
            Status.Enabled = true;
            Radio.Enabled = true;
            Comm.Enabled = true;
            Mode.Enabled = true;
            RSL.Enabled = true;


        }
        public void PowerLEDColorPicker_EnabledChanged(object sender, EventArgs e)
        {
            string curItem = PowerLEDColorPicker.SelectedItem.ToString();
            
            

        }
        private class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }

        private void Loop(object myObject, EventArgs myEventArgs) 
        {            
            switch (powerState)
            {
                default:
                    responseBox[0] = "Invalid Input";
                    break;
                case 0:
                    responseBox[0] = "Power is outside valid input range.";
                    break;
                case 11:
                    responseBox[0] = "Power is valid with no fault condition.";
                    break;
                case 21:
                    responseBox[0] = "One or more user voltage rails are in short-circuit or overcurrent condition.";
                    break;
                case 22:
                    responseBox[0] = "Input voltage is too high (greater than 16V), and all outputs, including RSL, are disabled.";
                    break;
                case 31:
                    responseBox[0] = "Brownout condition detected. 6V user rail and outputs are disabled.";
                    break;
            }
            switch (statusState)
            {
                default:
                    responseBox[1] = "Invalid Input";
                    break;
                case -1:
                    responseBox[1] = "Normal Operation";
                    break;
                case 10:
                    responseBox[1] = "Error detected with software. Reinstall software on this device.";
                    break;
                case 11:
                    responseBox[1] = "Device is in safe mode.";
                    break;
                case 12:
                    responseBox[1] = "Software has crashed twice without reboot or power cycle. Check memory usage in VI.";
                    break;
                case 13:
                    responseBox[1] = "This device has detected an unrecoverable error. Contact National Instruments.";
                    break;
            }
            switch (radioState)
            {
                default:
                    responseBox[2] = "Invalid Input";
                    break;
                case 0:
                    responseBox[2] = "No connection detected";
                    break;
                case 11:
                    responseBox[2] = "Radio is enabled and bridge configured with SSID.";
                    break;
                case 12:
                    responseBox[2] = "Radio is enabled and bridging is in progress.";
                    break;
                case 21:
                    responseBox[2] = "Reserved";
                    break;
                case 22:
                    responseBox[2] = "Reserved";
                    break;
                case 32:
                    responseBox[2] = "Radio is enabled and access point is being constructed.";
                    break;
                case 31:
                    responseBox[2] = "Radio is enabled and in access point mode.";
                    break;
            }
            switch (commState)
            {
                default:
                    responseBox[3] = "Invalid Input";
                    break;
                case 0:
                    responseBox[3] = "No communication detected. No heartbeat detected.";
                    break;
                case 11:
                    responseBox[3] = "Active. Driver station is in convtrol of the robot.";
                    break;
                case 21:
                    responseBox[3] = "No robot code.";
                    break;
                case 22:
                    responseBox[3] = "Driver station has E-Stopped the robot.";
                    break;
                case 31:
                    responseBox[3] = "Reserved.";
                    break;
                case 32:
                    responseBox[3] = "Reserved.";
                    break;
            }
            switch (modeState)
            {
                default:
                    responseBox[4] = "Invalid Input";
                    break;
                case 0:
                    responseBox[4] = "Outputs disabled.";
                    break;
                case 11:
                    responseBox[4] = "Outputs enabled. Autonomous mode.";
                    break;
                case 31:
                    responseBox[4] = "Outputs enabled. TeleOperated mode.";
                    break;
                case 21:
                    responseBox[4] = "Outputs unknown, undetermined, or in test mode.";
                    break;
            }
            switch (rslState)
            {
                default:
                    responseBox[5] = "Invalid Input";
                    break;
                case 0:
                    responseBox[5] = "Outputs disabled. No power";
                    break;
                case 11:
                    responseBox[5] = "Outputs disabled. Robot is powered.";
                    break;
                case 12:
                    responseBox[5] = "Outputs enabled. Robot is powered.";
                    break;
            }
            ResponseOutputBox.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                ResponseOutputBox.Items.Add(responseBox[i]);
            }
        }

        private void powerUpdate(object myObject, EventArgs myEventArgs)
        {
            powerState = PowerLEDColorPicker.SelectedIndex * 10 + PowerLEDPatternPicker.SelectedIndex;
            switch (powerState)
            {
                case 11:
                    PowerLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (powerEnabled == true) { PowerLED.BackColor = Color.White; powerEnabled = false; } else { PowerLED.BackColor = Color.Green; powerEnabled = true; }
                    break;
                case 21:
                    PowerLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (powerEnabled == true) { PowerLED.BackColor = Color.White; powerEnabled = false; } else { PowerLED.BackColor = Color.Red; powerEnabled = true; }
                    break;
                case 31:
                    PowerLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (powerEnabled == true) { PowerLED.BackColor = Color.White; powerEnabled = false; } else { PowerLED.BackColor = Color.Yellow; powerEnabled = true; }
                    break;
            }
            if (powerState != 11 && powerState != 12 && powerState != 21 && powerState != 22 && powerState != 31 && powerState != 32) { PowerLED.BackColor = Color.White; }
        }

        private void statusUpdate(object myObject, EventArgs myEventArgs) 
        {
            statusState = StatusLEDColorPicker.SelectedIndex * 10 + StatusLEDPatternPicker.SelectedIndex;
            switch (statusState)
            {
                case 10:
                    switch (statusBlinkState)
                    {
                        case 0:
                            Status.Interval = 150;
                            if (statusEnabled == false) 
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;

                        case 1:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                Status.Interval = 1500;
                                statusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 11:
                    switch (statusBlinkState)
                    {
                        case 0:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;
                        case 1:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;

                        case 2:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                Status.Interval = 1500;
                                statusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 12:
                    switch (statusBlinkState)
                    {
                        case 0:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;
                        case 1:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;
                        case 2:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                statusBlinkState++;
                            }
                            break;

                        case 3:
                            Status.Interval = 150;
                            if (statusEnabled == false)
                            {
                                StatusLED.BackColor = Color.Yellow;
                                statusEnabled = true;
                            }
                            else
                            {
                                StatusLED.BackColor = Color.White;
                                statusEnabled = false;
                                Status.Interval = 1500;
                                statusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 13:
                    Status.Interval = 150;
                    if (statusEnabled == true) { StatusLED.BackColor = Color.White; statusEnabled = false; } else { StatusLED.BackColor = Color.Yellow; statusEnabled = true; }
                    break;
            }
            if (statusState != 10 && statusState != 11 && statusState != 12&& statusState != 13) { StatusLED.BackColor = Color.White; }
        }
        
        private void radioUpdate(object myObject, EventArgs myEventArgs) 
        {
            radioState = RadioLEDColorPicker.SelectedIndex * 10 + RadioLEDPatternPicker.SelectedIndex;
            switch (radioState)
            {
                case 11:
                    RadioLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (radioEnabled == true) { RadioLED.BackColor = Color.White; radioEnabled = false; } else { RadioLED.BackColor = Color.Green; radioEnabled = true; }
                    break;
                case 21:
                    RadioLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (radioEnabled == true) { RadioLED.BackColor = Color.White; radioEnabled = false; } else { RadioLED.BackColor = Color.Red; radioEnabled = true; }
                    break;
                case 31:
                    RadioLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (radioEnabled == true) { RadioLED.BackColor = Color.White; radioEnabled = false; } else { RadioLED.BackColor = Color.Yellow; radioEnabled = true; }
                    break;
            }
            if (radioState != 11 && radioState != 12 && radioState != 21 && radioState != 22 && radioState != 31 && radioState != 32) { RadioLED.BackColor = Color.White; }
        }

        private void commUpdate(object myObject, EventArgs myEventArgs) 
        {
            commState = CommLEDColorPicker.SelectedIndex * 10 + CommLEDPatternPicker.SelectedIndex;
            switch (commState)
            {
                case 11:
                    CommLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (commEnabled == true) { CommLED.BackColor = Color.White; commEnabled = false; } else { CommLED.BackColor = Color.Green; commEnabled = true; }
                    break;
                case 21:
                    CommLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (commEnabled == true) { CommLED.BackColor = Color.White; commEnabled = false; } else { CommLED.BackColor = Color.Red; commEnabled = true; }
                    break;
                case 31:
                    CommLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (commEnabled == true) { CommLED.BackColor = Color.White; commEnabled = false; } else { CommLED.BackColor = Color.Yellow; commEnabled = true; }
                    break;
            }
            if (commState != 11 && commState != 12 && commState != 21 && commState != 22 && commState != 31 && commState != 32) { CommLED.BackColor = Color.White; }
        }

        private void modeUpdate(object myObject, EventArgs myEventArgs)
        {
            modeState = ModeLEDColorPicker.SelectedIndex * 10 + ModeLEDPatternPicker.SelectedIndex;
            switch (modeState)
            {
                case 11:
                    ModeLED.BackColor = Color.Green;
                    break;            
                case 21:
                    ModeLED.BackColor = Color.Red;
                    break;                
                case 31:
                    ModeLED.BackColor = Color.Yellow;
                    break;               
            }
            if (modeState != 11 && modeState != 21 && modeState != 31) { ModeLED.BackColor = Color.White; }
        }
        private void rslUpdate(object myObject, EventArgs myEventArgs) 
        {
            rslState = RSLLEDColorPicker.SelectedIndex * 10 + RSLLEDPatternPicker.SelectedIndex;
            switch (rslState)
            {
                case 11:
                    RSLLed.BackColor = Color.Yellow;
                    break;
                case 12:
                    if (rslEnabled == true) { RSLLed.BackColor = Color.White; rslEnabled = false; } else { RSLLed.BackColor = Color.Yellow; rslEnabled = true; }
                    break;
            }
            if (rslState != 11 && rslState != 12) { RSLLed.BackColor = Color.White; }
        }
    }
}