using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Event
{
    public class TemperatureChangeedEventArgs : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }
        public double Diffrence { get; }

        // constractor
        public TemperatureChangeedEventArgs(double OldTemperature, double NewTemperature)
        {
            this.OldTemperature = OldTemperature;
            this.NewTemperature = NewTemperature;
            this.Diffrence = NewTemperature - OldTemperature;
        }
    }

    public class Thermostat
    {
        // create Event
        public event EventHandler<TemperatureChangeedEventArgs> TempretureChanged;

        public double OldTemperature;
        public double CurrentTemperature;  // = 0  ( by default )

        // SetTemperature Method that Fire the Event if NewTemperature != CurrentTemperature
        public void SetTemperature(double newTemperature)
        {
            if (newTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = newTemperature;

                // fire the event
                OnTempretureChanged(OldTemperature, CurrentTemperature);
                // now eny class will use this class can use delegate to chech if event fire will know and access data
            }
        }

        // Create Method            To Fill Object class With Data 
        private void OnTempretureChanged(double OldTemperature, double CurrentTemperature)
        {
            OnTempretureChanged(new TemperatureChangeedEventArgs(OldTemperature, CurrentTemperature));
        }

        // Create Protected Method  To Raise Data (Object after filled with dDta)
        protected virtual void OnTempretureChanged(TemperatureChangeedEventArgs e)
        {
            TempretureChanged?.Invoke(this, e);

        }
    }

    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TempretureChanged += HandleTempertureChange;
        }

        public void HandleTempertureChange(object Sender, TemperatureChangeedEventArgs e)// the parameters must be same
        {
            Console.WriteLine("\n\n Temperture Changed : ");
            Console.WriteLine($" Temperture Changed from : {e.OldTemperature}");
            Console.WriteLine($" Temperture Changed to   : {e.NewTemperature}");
            Console.WriteLine($" Temperture Differance   : {e.Diffrence}");
        }
    }

    //internal class Program
    //{
        //static void Main(string[] args)
        //{
            //// use Thermostat  to change Temperture
            //Thermostat termostat = new Thermostat();

            //// use Display     to Display changes
            //Display display = new Display();

            //display.Subscribe(termostat);

            //termostat.SetTemperature(25);
            //termostat.SetTemperature(25);
            //termostat.SetTemperature(30);
            //termostat.SetTemperature(30);
            //termostat.SetTemperature(30);

            //Console.ReadKey();
        //}
    //}
}
