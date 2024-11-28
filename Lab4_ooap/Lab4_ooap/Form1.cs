using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ooap
{
    public partial class Form1 : Form
    {
        private IAlarmC alarmC;  // Абстракція будильника

        public Form1()
        {
            InitializeComponent();
            // Вибір типу сповіщення (можна замінити на DigitalAlarmImpl для іншого типу)
            IAlarmCImpl alarmImpl = new ClassicAlarmImpl(); // Використовуємо класичний будильник
            alarmC = new AlarmAdapter(alarmImpl);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            alarmC.Start(); // Запуск будильника
            lblStatus.Text = "Alarm started";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            alarmC.Stop(); // Зупинка будильника
            lblStatus.Text = "Alarm stopped";
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnWakeUp_Click(object sender, EventArgs e)
        {
            alarmC.ToWake(); // Викликаємо метод ToWake, який викликає Ring() і Notify()
            lblStatus.Text = "Wake-up initiated!";
        }
    }
}
