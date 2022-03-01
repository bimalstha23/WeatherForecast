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
    public partial class Calender : UserControl
    {
        int month, year;
        public static int static_month,static_year;
        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            static_month = month;
            static_year= year;
            string monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName + "  " + year;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

            int days =DateTime.DaysInMonth(now.Year, now.Month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for(int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDay ucday = new UserControlDay();
                ucday.days(i);
                dayContainer.Controls.Add(ucday);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            string monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName +"  " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucday = new UserControlDay();
                ucday.days(i);
                dayContainer.Controls.Add(ucday);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            dayContainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            string monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName + "  " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days =DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for(int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDay ucday = new UserControlDay();
                ucday.days(i);
                dayContainer.Controls.Add(ucday);
            }
        }
    }
}
