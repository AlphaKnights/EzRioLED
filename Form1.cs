using System;
using System.Windows.Forms;

namespace EzRioLED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigSelectorBoxes();
            FillColorSelectorBoxes();
            FillPatternSelectorBoxes();

            PowerLEDColorPicker.EnabledChanged += PowerLEDColorPicker_EnabledChanged;
        }

        public void ConfigSelectorBoxes()
        {
            PowerLEDColorPicker.AutoSize = true;
            PowerLEDColorPicker.SelectionMode = SelectionMode.One;

            PowerLEDPatternPicker.AutoSize = true;
            PowerLEDPatternPicker.SelectionMode = SelectionMode.One;

            StatusLEDColorPicker.AutoSize = true;
            StatusLEDColorPicker.SelectionMode = SelectionMode.One;

            StatusLEDPatternPicker.AutoSize = true;
            StatusLEDPatternPicker.SelectionMode = SelectionMode.One;

            RadioLEDColorPicker.AutoSize = true;
            RadioLEDColorPicker.SelectionMode = SelectionMode.One;

            RadioLEDPatternPicker.AutoSize = true;
            RadioLEDPatternPicker.SelectionMode = SelectionMode.One;

            CommLEDColorPicker.AutoSize = true;
            CommLEDColorPicker.SelectionMode = SelectionMode.One;

            CommLEDPatternPicker.AutoSize = true;
            CommLEDPatternPicker.SelectionMode = SelectionMode.One;

            ModeLEDColorPicker.AutoSize = true;
            ModeLEDColorPicker.SelectionMode = SelectionMode.One;

            ModeLEDPatternPicker.AutoSize = true;
            ModeLEDPatternPicker.SelectionMode = SelectionMode.One;

            RSLLEDColorPicker.AutoSize = true;
            RSLLEDColorPicker.SelectionMode = SelectionMode.One;

            RSLLEDPatternPicker.AutoSize = true;
            RSLLEDPatternPicker.SelectionMode = SelectionMode.One;
        }

        public void FillColorSelectorBoxes()
        {
            PowerLEDColorPicker.Items.Add("Off");
            PowerLEDColorPicker.Items.Add("Green");
            PowerLEDColorPicker.Items.Add("Red");
            PowerLEDColorPicker.Items.Add("Yellow");
            PowerLEDColorPicker.SetSelected(0, true);

            StatusLEDColorPicker.Items.Add("Yellow");
            StatusLEDColorPicker.SetSelected(0, true);

            RadioLEDColorPicker.Items.Add("Off");
            RadioLEDColorPicker.Items.Add("Green");
            RadioLEDColorPicker.Items.Add("Red");
            RadioLEDColorPicker.Items.Add("Yellow");
            RadioLEDColorPicker.SetSelected(0, true);

            CommLEDColorPicker.Items.Add("Off");
            CommLEDColorPicker.Items.Add("Green");
            CommLEDColorPicker.Items.Add("Red");
            CommLEDColorPicker.Items.Add("Yellow");
            CommLEDColorPicker.SetSelected(0, true);

            ModeLEDColorPicker.Items.Add("Off");
            ModeLEDColorPicker.Items.Add("Green");
            ModeLEDColorPicker.Items.Add("Red");
            ModeLEDColorPicker.Items.Add("Yellow");
            ModeLEDColorPicker.SetSelected(0, true);

            RSLLEDColorPicker.Items.Add("Yellow");
            RSLLEDColorPicker.SetSelected(0, true);
        }

        public void FillPatternSelectorBoxes()
        {
            PowerLEDPatternPicker.Items.Add("Off");
            PowerLEDPatternPicker.Items.Add("Solid");
            PowerLEDPatternPicker.Items.Add("Flashing");
            PowerLEDPatternPicker.SetSelected(0, true);

            StatusLEDPatternPicker.Items.Add("2");
            StatusLEDPatternPicker.Items.Add("3");
            StatusLEDPatternPicker.Items.Add("4");
            StatusLEDPatternPicker.Items.Add("Fast/Solid");
            StatusLEDPatternPicker.SetSelected(0, true);

            RadioLEDPatternPicker.Items.Add("Off");
            RadioLEDPatternPicker.Items.Add("Solid");
            RadioLEDPatternPicker.Items.Add("Blinking");
            RadioLEDPatternPicker.SetSelected(0, true);

            CommLEDPatternPicker.Items.Add("Off");
            CommLEDPatternPicker.Items.Add("Solid");
            CommLEDPatternPicker.Items.Add("Blinking");
            CommLEDPatternPicker.SetSelected(0, true);

            ModeLEDPatternPicker.Items.Add("Off");
            ModeLEDPatternPicker.Items.Add("Solid");
            ModeLEDPatternPicker.SetSelected(0, true);

            RSLLEDPatternPicker.Items.Add("Off");
            RSLLEDPatternPicker.Items.Add("Solid");
            RSLLEDPatternPicker.Items.Add("Blinking");
            RSLLEDPatternPicker.SetSelected(0, true);
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
    }
}