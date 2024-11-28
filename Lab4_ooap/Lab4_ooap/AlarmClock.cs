using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ooap
{
    public class AlarmAdapter : IAlarmC
    {
        private readonly IAlarmCImpl _alarmCImpl; // Замінено на IAlarmCImpl

        public AlarmAdapter(IAlarmCImpl alarmCImpl)
        {
            _alarmCImpl = alarmCImpl;
        }

        // Метод для запуску будильника
        public void Start()
        {
            MessageBox.Show("Alarm started", "Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для зупинки будильника
        public void Stop()
        {
            MessageBox.Show("Alarm stopped", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для активації будильника (викликає дзвінок і повідомлення)
        public void ToWake()
        {
            _alarmCImpl.Ring();   // Викликаємо метод Ring() з конкретної реалізації будильника
            _alarmCImpl.Notify(); 
        }
    }
}
