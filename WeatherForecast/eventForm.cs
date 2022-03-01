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
    public partial class eventForm : Form
    {
        public eventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventForm_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = Calender.static_month + "/" + UserControlDay.static_day + "/" + Calender.static_year;
        }
    }
}
