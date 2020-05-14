using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private Mode mode;

        public Form1()
        {
            InitializeComponent();

            mode = new DistanceMode(this);
            setModeOptions();
        }

        private void setModeOptions()
        {
            label_Mode.Text = mode.ToString();

            comboBox_BaseUnit.Items.Clear();
            comboBox_TargetUnit.Items.Clear();
            
            foreach(var item in mode.UnitValues)
            {
                comboBox_BaseUnit.Items.Add(item);
                comboBox_TargetUnit.Items.Add(item);
            }
        }

        private void button_DistanceMode_Click(object sender, EventArgs e)
        {
            mode.Update(EMode.DISTANCE);
            setModeOptions();
        }

        private void button_WeightMode_Click(object sender, EventArgs e)
        {
            mode.Update(EMode.WEIGHT);
            setModeOptions();
        }

        private void button_TemperatureMode_Click(object sender, EventArgs e)
        {
            mode.Update(EMode.TEMPERATURE);
            setModeOptions();
        }

        public Mode CurrentMode
        {
            get => mode;
            set => mode = value;
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            double baseValue = Convert.ToDouble(textBox_Input.Text);

            double result = mode.ConvertUnit(
                (int)comboBox_BaseUnit.SelectedItem,
                (int)comboBox_TargetUnit.SelectedItem,
                baseValue
            );

            textBox_Output.Text = result.ToString();
        }
    }
}
