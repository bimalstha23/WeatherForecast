using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxCelcius_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFahrenheit.Checked = !checkBoxCelcius.Checked;
        }

        private void checkBoxFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCelcius.Checked = !checkBoxFahrenheit.Checked;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            setSettings();
        }
        bool checkMeter()
        {
            if(checkBoxCelcius.Checked == true)
            return true;
            else
            return false;
        }
        void setSettings()
        {
            textBoxPanel1.Text = Properties.Settings.Default.favFirstPanelLoc1;
            textBoxPanel2.Text = Properties.Settings.Default.favFirstPanelLoc2;
            textBoxPanel3.Text = Properties.Settings.Default.favFirstPanelLoc3;
            textBoxPanel4.Text = Properties.Settings.Default.favFirstPanelLoc4;
            textBoxPanel5.Text = Properties.Settings.Default.favFirstPanelLoc5;
            if(Properties.Settings.Default.tempratureStatusCelcius ==true)
            {
                checkBoxCelcius.Checked = true; 
            }
            else
            {
                checkBoxCelcius.Checked = false;
            }
            if(Properties.Settings.Default.tempratureStatusFahrenheit == true)
            {
                checkBoxFahrenheit.Checked = true;
            }
            else
            {
                checkBoxFahrenheit.Checked = false;
            }
        }
        void getSettings()
        {
            Properties.Settings.Default.favFirstPanelLoc1 = textBoxPanel1.Text;
            Properties.Settings.Default.favFirstPanelLoc2 = textBoxPanel2.Text;
            Properties.Settings.Default.favFirstPanelLoc3 = textBoxPanel3.Text;
            Properties.Settings.Default.favFirstPanelLoc4 = textBoxPanel4.Text;
            Properties.Settings.Default.favFirstPanelLoc5 = textBoxPanel5.Text;
            if (checkBoxCelcius.Checked ==true)
            {
                Properties.Settings.Default.tempratureStatusCelcius = true;
            }
            else
            {
                Properties.Settings.Default.tempratureStatusCelcius = false;
            }
            if(checkBoxFahrenheit.Checked == true)
            {
                Properties.Settings.Default.tempratureStatusFahrenheit = true;
            }
            else
            {
                Properties.Settings.Default.tempratureStatusFahrenheit = false;
            }
            Properties.Settings.Default.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            getSettings();
            setSettings();
            MessageBox.Show("Settings Saved!");
           /* WeatherMan weatherform = new WeatherMan();
            weatherform.updateweather(weatherform.deviceLon,weatherform.deviceLat);*/
        }
    }
}
