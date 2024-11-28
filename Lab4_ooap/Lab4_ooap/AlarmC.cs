using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ooap
{
    public interface IAlarmC
    {
        void Start();
        void Stop();
        void ToWake();
    }
}
