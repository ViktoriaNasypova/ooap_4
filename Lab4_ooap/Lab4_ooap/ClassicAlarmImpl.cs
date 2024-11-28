using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ooap
{
    public class ClassicAlarmImpl : IAlarmCImpl
    {
        public void Ring()
        {
            MessageBox.Show("Classic Alarm: Ringing the bell!");
        }

        public void Notify()
        {
            MessageBox.Show("Classic Alarm: Sending a notification.");
        }
    }
}
