using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDlibary;

namespace datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateDifference_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date1 = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;

                TimeSpan difference = MDHelper.GetDateDifference(date1, date2);

                lblResult1.Text = $"Разница между датами: {difference.Days} дней, {difference.Hours} часов, {difference.Minutes} минут";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIsLeapYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);

            bool isLeapYear = MDHelper.IsLeapYear(year);

            lblResult1.Text = isLeapYear ? $"{year} - високосный год" : $"{year} - не високосный год";
        }

        private void btnGetTimeOfDay_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePickerTime.Value;
            string timeOfDay = MDHelper.GetTimeOfDay(time);

            lblResult1.Text = $"Время суток: {timeOfDay}";
        }

        private void btnFormatDateTime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerFormat.Value;
            string format = txtFormat.Text;

            string formattedDateTime = MDHelper.FormatDateTime(dateTime, format);

            lblResult1.Text = $"Форматированная дата и время: {formattedDateTime}";
        }
    }
}
