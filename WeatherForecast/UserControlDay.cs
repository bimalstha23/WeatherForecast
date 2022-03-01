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
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lblDay.Text = numday.ToString();
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            eventForm eventForm = new eventForm();
            eventForm.Show();
        }
    }
}
