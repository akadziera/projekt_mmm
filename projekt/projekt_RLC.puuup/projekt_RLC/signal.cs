using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_RLC
{
    class signal
    {
        public diode our_diode = new diode();
        
        public List<double> getVoltageSignal()
        {
            return _signalVoltageList;
        }

        public List<double> getCurrentSignal()
        {
            return _signalCurrentList;
        }
        public List<double> getResistorVoltage()
        {
            return _resistorVoltage;
        }

        public List<double> getCapacitorVoltage()
        {
            return _capacitorVoltage;
        }
        public List<double> getInductorVoltage()
        {
            return _signalCurrentList;
        }
        private List<double> _signalVoltageList = new List<double>();
        private List<double> _signalCurrentList = new List<double>();
        private List<double> _resistorVoltage = new List<double>();
        private List<double> _capacitorVoltage = new List<double>();
        private List<double> _inductorVoltage = new List<double>();

        

        public signal()
        {
        }
        private void CalculateCurrent(double R, double L, double C, int sample_freq)
        {
           

            _signalCurrentList.Clear();
            for (int i = 0; i < _signalVoltageList.Count(); i++)
            {
                double wartosc = 0;
                if (_signalVoltageList[i] > 0.7)
                {
                    wartosc = _signalVoltageList[i] / (R + (1 / _signalVoltageList[i]) * L + (1 / C) * _signalVoltageList[i] + our_diode.getRes());
                }



                _signalCurrentList.Add(wartosc);
            }
        }

        public void CalculateDiodeVoltage()
        {   
            for (int i = 0; i < _signalCurrentList.Count(); i++)
            { 
                double wartosc = _signalCurrentList[i] * our_diode.getRes();
                our_diode._diodeVoltage.Add(wartosc);
            }
        }


        private void CalculateResistorVoltage(double R)
        {
            _resistorVoltage.Clear();
            for (int i = 0; i < _signalCurrentList.Count(); i++)
            {
                double wartosc = _signalCurrentList[i]*R;
                _resistorVoltage.Add(wartosc);
            }
        }
        private void CalculateCapacitorVoltage(double C, int sample_freq)
        {    
            _capacitorVoltage.Clear();
            for (int i = 0; i < _signalCurrentList.Count()-1; i++)
            { 


                double wartosc = Operations.Integral(_signalCurrentList[i],_signalCurrentList[i+1], sample_freq)/C;
                
                _capacitorVoltage.Add(wartosc);
            }
        }

        
        private void CalculateVoltage(double C, double L, double R, int n_samples)
        {
            CalculateCapacitorVoltage(C, n_samples);
            CalculateInductorVoltage(L);
            CalculateResistorVoltage(R);
            CalculateDiodeVoltage();
        }
        private void CalculateInductorVoltage(double L)
        {
            _inductorVoltage.Clear();
            for (int i = 0; i < _signalCurrentList.Count() -1; i++)
            {
                double wartosc = L * Operations.Derivative(_signalCurrentList[i], _signalCurrentList[i+1]);

                _inductorVoltage.Add(wartosc);

            }
        }
        public signal(int n_samples, double amplitude, double fill, string type, double R, double L, double C)
        {
            switch(type)
            {
                case "triangle":    //trojkat
                    double k =  amplitude; //nachylenie
                    for(int i = 0; i < n_samples/2; i++)
                    {
                        _signalVoltageList.Add(2 * i * k / n_samples);
                    }
                    for (int i = n_samples / 2; i > 0; i--)
                    {
                        _signalVoltageList.Add(2 * i * (k) / n_samples);
                    }
                    break;
                case "sine":        //sinus
                    for (int i = 0; i < n_samples; i++)
                    {
                        _signalVoltageList.Add((Math.Sin(i * 2 * Math.PI / n_samples)) * (amplitude)/2 + amplitude / 2);
                    }
                    break;
                case "square":
                    for (int i = 0; i < n_samples; i++)
                    {
                        if (i < n_samples * fill / 100)
                        {
                            _signalVoltageList.Add(amplitude);
                        }
                        else
                        {
                            _signalVoltageList.Add(0);
                        }
                    }
                    break;
                    
            }

            _signalVoltageList.AddRange(_signalVoltageList);
            _signalVoltageList.AddRange(_signalVoltageList);
            _signalVoltageList.AddRange(_signalVoltageList);



            CalculateCurrent(R, L, C, n_samples);
            CalculateVoltage(C, L, R, n_samples);

        }

    
    }
}
