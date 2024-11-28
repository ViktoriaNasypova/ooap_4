using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ooap
{
    public class DigitalAlarmImpl : IAlarmCImpl
    {
        public void Ring()
        {
            MessageBox.Show("Digital Alarm: Beeping!");
        }

        public void Notify()
        {
            MessageBox.Show("Digital Alarm: Sending digital notification.");
        }
    }
}
