using System;
using System.Windows.Forms;
using System.Drawing;

namespace EzRioLED
{
    public partial class Form1 : Form
    {
        #region Roborio Variables and Timers
        Timer roboloop = new Timer();
        Timer roboPower = new Timer();
        Timer roboStatus = new Timer();
        Timer roboRadio = new Timer();
        Timer roboComm = new Timer();
        Timer roboMode = new Timer();
        Timer roboRSL = new Timer();

        static bool robopowerEnabled = false;
        static bool robostatusEnabled = false;
        static int robostatusBlinkState = 0;
        static bool roboradioEnabled = false;
        static bool robocommEnabled = false;
        static bool roborslEnabled = false;

        static int robopowerState;
        static int robostatusState;
        static int roboradioState;
        static int robomodeState;
        static int robocommState;
        static int roborslState;

        string[] roboresponseBox = new string[] { " ", " ", " ", " ", " ", " " };
        #endregion
        #region Talon Variables and Timers
        Timer talonled = new Timer();
        Timer talonbox = new Timer();

        static int talonState;
        #endregion

        #region Form1 Init
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Roborio Init
            roboloop.Interval = 50;
            roboPower.Interval = 400;
            roboStatus.Interval = 400;
            roboRadio.Interval = 400;
            roboComm.Interval = 400;
            roboMode.Interval = 50;
            roboRSL.Interval = 400;

            roboloop.Tick += new EventHandler(roboLoop);
            roboPower.Tick += new EventHandler(robopowerUpdate);
            roboStatus.Tick += new EventHandler(robostatusUpdate);
            roboRadio.Tick += new EventHandler(roboradioUpdate);
            roboComm.Tick += new EventHandler(robocommUpdate);
            roboMode.Tick += new EventHandler(robomodeUpdate);
            roboRSL.Tick += new EventHandler(roborslUpdate);

            roboloop.Enabled = true;
            roboPower.Enabled = true;
            roboStatus.Enabled = true;
            roboRadio.Enabled = true;
            roboComm.Enabled = true;
            roboMode.Enabled = true;
            roboRSL.Enabled = true;

            //setting good default values.

            roboPowerLEDColorPicker.SetSelected(1, true);
            roboPowerLEDPatternPicker.SetSelected(1, true);
            roboStatusLEDColorPicker.SetSelected(0, true);
            roboStatusLEDPatternPicker.SetSelected(0, true);
            roboRadioLEDColorPicker.SetSelected(3, true);
            roboRadioLEDPatternPicker.SetSelected(1, true);
            roboCommLEDColorPicker.SetSelected(1, true);
            roboCommLEDPatternPicker.SetSelected(1, true);
            roboModeLEDColorPicker.SetSelected(3, true);
            roboModeLEDPatternPicker.SetSelected(1, true);
            roboRSLLEDColorPicker.SetSelected(1, true);
            roboRSLLEDPatternPicker.SetSelected(2, true);
            #endregion
            #region Talon Init
            talonled.Interval = 400;
            talonbox.Interval = 50;

            talonled.Tick += new EventHandler(talonLED);
            talonbox.Tick += new EventHandler(talonUpdate);

            talonled.Enabled = true;
            talonbox.Enabled = true;

            //setting default selected values, the ones you want to see.
            talonModeSelector.SetSelected(1, true);
            talonTopColorSelector.SetSelected(3, true);
            talonBottomColorSelector.SetSelected(0, true);
            talonPatternSelector.SetSelected(6, true);

            #endregion
        }

        #region Roborio Logic
        private void roboLoop(object myObject, EventArgs myEventArgs)
        {
            switch (robopowerState)
            {
                default:
                    roboresponseBox[0] = "Invalid Input";
                    break;
                case 0:
                    roboresponseBox[0] = "Power is outside valid input range.";
                    break;
                case 11:
                    roboresponseBox[0] = "Power is valid with no fault condition.";
                    break;
                case 21:
                    roboresponseBox[0] = "One or more user voltage rails are in short-circuit or overcurrent condition.";
                    break;
                case 22:
                    roboresponseBox[0] = "Input voltage is too high (greater than 16V), and all outputs, including RSL, are disabled.";
                    break;
                case 31:
                    roboresponseBox[0] = "Brownout condition detected. 6V user rail and outputs are disabled.";
                    break;
            }
            switch (robostatusState)
            {
                default:
                    roboresponseBox[1] = "Invalid Input";
                    break;
                case -1:
                    roboresponseBox[1] = "Normal Operation";
                    break;
                case 0:
                    roboresponseBox[1] = "Normal Operation";
                    break;
                case 1:
                    roboresponseBox[1] = "Normal Operation";
                    break;
                case 2:
                    roboresponseBox[1] = "Normal Operation";
                    break;
                case 3:
                    roboresponseBox[1] = "Normal Operation";
                    break;
                case 10:
                    roboresponseBox[1] = "Error detected with software. Reinstall software on this device.";
                    break;
                case 11:
                    roboresponseBox[1] = "Device is in safe mode.";
                    break;
                case 12:
                    roboresponseBox[1] = "Software has crashed twice without reboot or power cycle. Check memory usage in VI.";
                    break;
                case 13:
                    roboresponseBox[1] = "This device has detected an unrecoverable error. Contact National Instruments.";
                    break;
            }
            switch (roboradioState)
            {
                default:
                    roboresponseBox[2] = "Invalid Input";
                    break;
                case 0:
                    roboresponseBox[2] = "No connection detected";
                    break;
                case 11:
                    roboresponseBox[2] = "Radio is enabled and bridge configured with SSID.";
                    break;
                case 12:
                    roboresponseBox[2] = "Radio is enabled and bridging is in progress.";
                    break;
                case 21:
                    roboresponseBox[2] = "Reserved";
                    break;
                case 22:
                    roboresponseBox[2] = "Reserved";
                    break;
                case 32:
                    roboresponseBox[2] = "Radio is enabled and access point is being constructed.";
                    break;
                case 31:
                    roboresponseBox[2] = "Radio is enabled and in access point mode.";
                    break;
            }
            switch (robocommState)
            {
                default:
                    roboresponseBox[3] = "Invalid Input";
                    break;
                case 0:
                    roboresponseBox[3] = "No communication detected. No heartbeat detected.";
                    break;
                case 11:
                    roboresponseBox[3] = "Active. Driver station is in convtrol of the robot.";
                    break;
                case 21:
                    roboresponseBox[3] = "No robot code.";
                    break;
                case 22:
                    roboresponseBox[3] = "Driver station has E-Stopped the robot.";
                    break;
                case 31:
                    roboresponseBox[3] = "Reserved.";
                    break;
                case 32:
                    roboresponseBox[3] = "Reserved.";
                    break;
            }
            switch (robomodeState)
            {
                default:
                    roboresponseBox[4] = "Invalid Input";
                    break;
                case 0:
                    roboresponseBox[4] = "Outputs disabled.";
                    break;
                case 11:
                    roboresponseBox[4] = "Outputs enabled. Autonomous mode.";
                    break;
                case 31:
                    roboresponseBox[4] = "Outputs enabled. TeleOperated mode.";
                    break;
                case 21:
                    roboresponseBox[4] = "Outputs unknown, undetermined, or in test mode.";
                    break;
            }
            switch (roborslState)
            {
                default:
                    roboresponseBox[5] = "Invalid Input";
                    break;
                case 0:
                    roboresponseBox[5] = "Outputs disabled. No power";
                    break;
                case 11:
                    roboresponseBox[5] = "Outputs disabled. Robot is powered.";
                    break;
                case 12:
                    roboresponseBox[5] = "Outputs enabled. Robot is powered.";
                    break;
            }
            roboResponseOutputBox.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                roboResponseOutputBox.Items.Add(roboresponseBox[i]);
            }
        }
        private void robopowerUpdate(object myObject, EventArgs myEventArgs)
        {
            robopowerState = roboPowerLEDColorPicker.SelectedIndex * 10 + roboPowerLEDPatternPicker.SelectedIndex;
            switch (robopowerState)
            {
                case 11:
                    roboPowerLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (robopowerEnabled == true) { roboPowerLED.BackColor = Color.White; robopowerEnabled = false; } else { roboPowerLED.BackColor = Color.Green; robopowerEnabled = true; }
                    break;
                case 21:
                    roboPowerLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (robopowerEnabled == true) { roboPowerLED.BackColor = Color.White; robopowerEnabled = false; } else { roboPowerLED.BackColor = Color.Red; robopowerEnabled = true; }
                    break;
                case 31:
                    roboPowerLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (robopowerEnabled == true) { roboPowerLED.BackColor = Color.White; robopowerEnabled = false; } else { roboPowerLED.BackColor = Color.Yellow; robopowerEnabled = true; }
                    break;
                default:
                    roboPowerLED.BackColor = Color.White;
                    break;
            }
        }
        private void robostatusUpdate(object myObject, EventArgs myEventArgs)
        {
            robostatusState = roboStatusLEDColorPicker.SelectedIndex * 10 + roboStatusLEDPatternPicker.SelectedIndex;
            switch (robostatusState)
            {
                case 10:
                    switch (robostatusBlinkState)
                    {
                        case 0:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;

                        case 1:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                roboStatus.Interval = 1500;
                                robostatusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 11:
                    switch (robostatusBlinkState)
                    {
                        case 0:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;
                        case 1:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;

                        case 2:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                roboStatus.Interval = 1500;
                                robostatusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 12:
                    switch (robostatusBlinkState)
                    {
                        case 0:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;
                        case 1:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;
                        case 2:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                robostatusBlinkState++;
                            }
                            break;

                        case 3:
                            roboStatus.Interval = 150;
                            if (robostatusEnabled == false)
                            {
                                roboStatusLED.BackColor = Color.Yellow;
                                robostatusEnabled = true;
                            }
                            else
                            {
                                roboStatusLED.BackColor = Color.White;
                                robostatusEnabled = false;
                                roboStatus.Interval = 1500;
                                robostatusBlinkState = 0;
                            }
                            break;
                    }
                    break;
                case 13:
                    roboStatus.Interval = 150;
                    if (robostatusEnabled == true) { roboStatusLED.BackColor = Color.White; robostatusEnabled = false; } else { roboStatusLED.BackColor = Color.Yellow; robostatusEnabled = true; }
                    break;
                default:
                    roboStatusLED.BackColor = Color.White;
                    break;
            }
        }
        private void roboradioUpdate(object myObject, EventArgs myEventArgs)
        {
            roboradioState = roboRadioLEDColorPicker.SelectedIndex * 10 + roboRadioLEDPatternPicker.SelectedIndex;
            switch (roboradioState)
            {
                case 11:
                    roboRadioLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (roboradioEnabled == true) { roboRadioLED.BackColor = Color.White; roboradioEnabled = false; } else { roboRadioLED.BackColor = Color.Green; roboradioEnabled = true; }
                    break;
                case 21:
                    roboRadioLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (roboradioEnabled == true) { roboRadioLED.BackColor = Color.White; roboradioEnabled = false; } else { roboRadioLED.BackColor = Color.Red; roboradioEnabled = true; }
                    break;
                case 31:
                    roboRadioLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (roboradioEnabled == true) { roboRadioLED.BackColor = Color.White; roboradioEnabled = false; } else { roboRadioLED.BackColor = Color.Yellow; roboradioEnabled = true; }
                    break;
                default:
                    roboRadioLED.BackColor = Color.White;
                    break;
            }
        }
        private void robocommUpdate(object myObject, EventArgs myEventArgs)
        {
            robocommState = roboCommLEDColorPicker.SelectedIndex * 10 + roboCommLEDPatternPicker.SelectedIndex;
            switch (robocommState)
            {
                case 11:
                    roboCommLED.BackColor = Color.Green;
                    break;
                case 12:
                    if (robocommEnabled == true) { roboCommLED.BackColor = Color.White; robocommEnabled = false; } else { roboCommLED.BackColor = Color.Green; robocommEnabled = true; }
                    break;
                case 21:
                    roboCommLED.BackColor = Color.Red;
                    break;
                case 22:
                    if (robocommEnabled == true) { roboCommLED.BackColor = Color.White; robocommEnabled = false; } else { roboCommLED.BackColor = Color.Red; robocommEnabled = true; }
                    break;
                case 31:
                    roboCommLED.BackColor = Color.Yellow;
                    break;
                case 32:
                    if (robocommEnabled == true) { roboCommLED.BackColor = Color.White; robocommEnabled = false; } else { roboCommLED.BackColor = Color.Yellow; robocommEnabled = true; }
                    break;
                default:
                    roboCommLED.BackColor = Color.White;
                    break;
            }
        }
        private void robomodeUpdate(object myObject, EventArgs myEventArgs)
        {
            robomodeState = roboModeLEDColorPicker.SelectedIndex * 10 + roboModeLEDPatternPicker.SelectedIndex;
            switch (robomodeState)
            {
                case 11:
                    roboModeLED.BackColor = Color.Green;
                    break;
                case 21:
                    roboModeLED.BackColor = Color.Red;
                    break;
                case 31:
                    roboModeLED.BackColor = Color.Yellow;
                    break;
                default:
                    roboModeLED.BackColor = Color.White;
                    break;
            }
        }
        private void roborslUpdate(object myObject, EventArgs myEventArgs)
        {
            roborslState = roboRSLLEDColorPicker.SelectedIndex * 10 + roboRSLLEDPatternPicker.SelectedIndex;
            switch (roborslState)
            {
                case 11:
                    roboRSLLed.BackColor = Color.Yellow;
                    break;
                case 12:
                    if (roborslEnabled == true) { roboRSLLed.BackColor = Color.White; roborslEnabled = false; } else { roboRSLLed.BackColor = Color.Yellow; roborslEnabled = true; }
                    break;
                default:
                    roboRSLLed.BackColor = Color.White;
                    break;
            }
        }
        #endregion
        #region Talon Logic

        //logic for blinking lights
        private void talonLED(object myObject, EventArgs myEventArgs)
        {
            talonState = talonModeSelector.SelectedIndex * 1000 + talonTopColorSelector.SelectedIndex * 100 + talonBottomColorSelector.SelectedIndex * 10 + talonPatternSelector.SelectedIndex;
            switch (talonState)
            {
                default:
                    talonled.Interval = 100;
                    if (talonTopLED.BackColor == Color.White) { talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.Red; }
                    else if (talonTopLED.BackColor == Color.Red) { talonTopLED.BackColor = Color.Orange; talonBotLED.BackColor = Color.Orange; }
                    else if (talonTopLED.BackColor == Color.Orange) { talonTopLED.BackColor = Color.Green; talonBotLED.BackColor = Color.Green; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; }
                    break;
                //calibration blink codes

                case 122:
                    if (talonTopLED.BackColor == Color.White) { talonTopLED.BackColor = Color.Green; talonBotLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; talonled.Interval = 400; }                   
                    break;
                case 212:
                    if (talonTopLED.BackColor == Color.White) { talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.Green; talonled.Interval = 100; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; talonled.Interval = 400; }
                    break;
                case 113:
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Green; talonBotLED.BackColor = Color.Green; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; }
                    break;
                case 223:
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.Red; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; }
                    break;
                //normal opertaion blink codes
                case 1113:  //flash red/green
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Green; talonBotLED.BackColor = Color.Green; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; }
                    break;
                case 1223: //flash red/green
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.Red; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.White; }
                    break;
                case 1036: //alt orange
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Orange; talonBotLED.BackColor = Color.White; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Orange; }
                    break;
                case 1306: //alt orange
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Orange; talonBotLED.BackColor = Color.White; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Orange; }
                    break;
                case 1026: //alt red
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.White; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Red; }
                    break;
                case 1206: //alt red
                    if (talonTopLED.BackColor == Color.White) { talonled.Interval = 400; talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.White; }
                    else { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Red; }
                    break;
                case 1236: //alt red/orange
                    if (talonTopLED.BackColor == Color.Red) { talonled.Interval = 400; talonTopLED.BackColor = Color.Orange; talonBotLED.BackColor = Color.Red; }
                    else { talonTopLED.BackColor = Color.Red; talonled.Interval = 400; talonBotLED.BackColor = Color.Orange; }
                    break;
                case 1326: //alt red/orange
                    if (talonTopLED.BackColor == Color.Red) { talonled.Interval = 400; talonTopLED.BackColor = Color.Orange; talonBotLED.BackColor = Color.Red; }
                    else { talonTopLED.BackColor = Color.Red; talonBotLED.BackColor = Color.Orange; }
                    break;
                case 1025: //str red
                    if(talonTopLED.BackColor == Color.White && talonBotLED.BackColor == Color.White) { talonTopLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else if (talonTopLED.BackColor == Color.Red ) { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else { talonBotLED.BackColor = Color.White; talonled.Interval = 400; }
                    break;
                case 1205: //str red
                    if (talonTopLED.BackColor == Color.White && talonBotLED.BackColor == Color.White) { talonTopLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else if (talonTopLED.BackColor == Color.Red) { talonTopLED.BackColor = Color.White; talonBotLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else { talonBotLED.BackColor = Color.White; talonled.Interval = 400; }
                    break;
                case 1024: //str red
                    if (talonBotLED.BackColor == Color.White && talonTopLED.BackColor == Color.White) { talonBotLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else if (talonBotLED.BackColor == Color.Red) { talonBotLED.BackColor = Color.White; talonTopLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else { talonTopLED.BackColor = Color.White; talonled.Interval = 400; }
                    break;
                case 1204: //str red
                    if (talonBotLED.BackColor == Color.White && talonTopLED.BackColor == Color.White) { talonBotLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else if (talonBotLED.BackColor == Color.Red) { talonBotLED.BackColor = Color.White; talonTopLED.BackColor = Color.Red; talonled.Interval = 100; }
                    else { talonTopLED.BackColor = Color.White; talonled.Interval = 400; }
                    break;
                case 1017: //cha green
                    if (talonBotLED.BackColor == Color.Green) { talonled.Interval = 400; talonBotLED.BackColor = Color.Orange; }
                    else { talonBotLED.BackColor = Color.Green; }
                    break;
                case 1037: //cha orange
                    if (talonBotLED.BackColor == Color.Green) { talonled.Interval = 400; talonBotLED.BackColor = Color.Orange; }
                    else { talonBotLED.BackColor = Color.Green; }
                    break;
                case 1331: //solid orange
                    talonled.Interval = 400;
                    talonTopLED.BackColor = Color.Orange;
                    talonBotLED.BackColor = Color.Orange;
                    break;
                //B/C CAL Blink Codes
                case 2221: //solid red
                    talonled.Interval = 400;
                    talonTopLED.BackColor = Color.Red;
                    talonBotLED.BackColor = Color.Red;
                    break;
                case 1000:
                    talonTopLED.BackColor = Color.White;
                    talonBotLED.BackColor = Color.White;
                    break;
                case 2000:
                    talonTopLED.BackColor = Color.White;
                    talonBotLED.BackColor = Color.White;
                    break;
            }
        }
        //logic for output box
        private void talonUpdate(object myObject, EventArgs myEventArgs)
        {
            talonOutputBox.Items.Clear();
            switch (talonState)
            {
                default:
                    talonOutputBox.Items.Add("Invalid Input.");
                    break;
                //calibration
                case 122:
                    talonOutputBox.Items.Add("Calibration Mode");
                    break;
                case 212:
                    talonOutputBox.Items.Add("Calibration Mode");
                    break;
                case 113:
                    talonOutputBox.Items.Add("Successful Calibration");
                    break;
                case 223:
                    talonOutputBox.Items.Add("Failed Calibration");
                    break;
                //normal operation
                case 1113:
                    talonOutputBox.Items.Add("Forward throttle is applied.");
                    talonOutputBox.Items.Add("Blink Rate is proportional to Duty Cycle.");
                    break;
                case 1223:
                    talonOutputBox.Items.Add("Reverse throttle is applied.");
                    talonOutputBox.Items.Add("Blink Rate is proportional to Duty Cycle.");
                    break;
                case 1000:
                    talonOutputBox.Items.Add("No Power is being applied to Talon");
                    break;
                case 1306:
                    talonOutputBox.Items.Add("CAN bus detected, robot disabled.");
                    break;
                case 1036:
                    talonOutputBox.Items.Add("CAN bus detected, robot disabled.");
                    break;
                case 1206:
                    talonOutputBox.Items.Add("CAN bus/PWM is not detected.");
                    break;
                case 1026:
                    talonOutputBox.Items.Add("CAN bus/PWM is not detected.");
                    break;
                case 1236:
                    talonOutputBox.Items.Add("Damaged Hardware.");
                    break;
                case 1326:
                    talonOutputBox.Items.Add("Damaged Hardware.");
                    break;
                case 1025:
                    talonOutputBox.Items.Add("Forward Limit Switch or Forward Soft Limit.");
                    break;
                case 1205:
                    talonOutputBox.Items.Add("Forward Limit Switch or Forward Soft Limit.");
                    break;
                case 1024:
                    talonOutputBox.Items.Add("Reverse Limit Switch or Reverse Soft Limit.");
                    break;
                case 1204:
                    talonOutputBox.Items.Add("Reverse Limit Switch or Reverse Soft Limit.");
                    break;
                case 1017:
                    talonOutputBox.Items.Add("In Boot-loader");
                    break;
                case 1037:
                    talonOutputBox.Items.Add("In Boot-loader");
                    break;
                case 1331:
                    talonOutputBox.Items.Add("Neutral throttle is applied.");
                    talonOutputBox.Items.Add("Throttle is zero or is within dead band.");
                    break;
                //b/c cal
                case 2221:
                    talonOutputBox.Items.Add("Brake Mode");
                    break;
                case 2000:
                    talonOutputBox.Items.Add("Coast Mode");
                    break;
            }
        }
        #endregion

    }
}