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
            label_Mode.Text = mode.ToString();
        }

        private void changeMode(EMode _mode)
        {
            mode.Update(_mode);
            label_Mode.Text = mode.ToString();
        }

        private void button_DistanceMode_Click(object sender, EventArgs e)
        {
            changeMode(EMode.DISTANCE);
        }

        private void button_WeightMode_Click(object sender, EventArgs e)
        {
            changeMode(EMode.WEIGHT);
        }

        private void button_TemperatureMode_Click(object sender, EventArgs e)
        {
            changeMode(EMode.TEMPERATURE);
        }

        public Mode CurrentMode
        {
            get => mode;
            set => mode = value;
        }
    }
}
