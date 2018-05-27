using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_RLC
{
    class diode
    {
        double current;
        double voltage;
        private double Vt = 0.0258; // napiecie termiczne
        private double Is = 1 * 10 ^ (-12); // natezenie pradu nasycenia zlacza
        private double rz = 10; //rezystancja w kierunku zaporowym
        private double Rd = 0.02;
        double resistance;
        signal my_signal;
        
        public List<double> getDiodeVoltage()
        {
            return _diodeVoltage;
        }
        private List<double> _diodeVoltage = new List<double>();
        public diode()
        {
            Vt = 0.0258; // napiecie termiczne
            Is = 1 * 10 ^ (-12); // natezenie pradu nasycenia zlacza
            rz = 10; //rezystancja w kierunku zaporowym
            Rd = 0.02;
        }
        public diode(double thermal_voltage, double saturation_current, double backward_resistance)
        {
            Vt = thermal_voltage;
            Is = saturation_current;
            rz = backward_resistance;
        }
      private double set_current(double voltage)
        {
            if (voltage > 0.7)
            {
                current = Is * (Math.Pow(Math.E, (voltage / Vt) - 1));
            } else if (voltage > -200)
            {
                current = 0;
            }
            else
            {
                current = voltage / rz;
            }

            return current;
        }

        private void DiodeVoltage(double current, double voltage)
        {   
            for(int i=0; i<my_signal.getCurrentSignal().Count(); i++)
            {
                double wartosc = voltage + my_signal.getCurrentSignal()[i] * Rd;
                _diodeVoltage.Add(wartosc);
            }

            DiodeVoltage(current, voltage);

        }
    }
}
