using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using System.Device.Gpio;
using System.Diagnostics;

namespace LeDrink.DAL.Repos
{
    public class RaspiRepo : IRaspiRepo
    {
        private GpioController controller = new GpioController(PinNumberingScheme.Board);

        private void StartPin(int pin)
        {
            Console.WriteLine("Turning on pin {0}", pin);
            controller.OpenPin(pin, PinMode.Output);
            controller.Write(pin, PinValue.High);
            controller.ClosePin(pin);
        }

        private void StopPin(int pin)
        {
            Console.WriteLine("Turning off pin {0}", pin);
            controller.OpenPin(pin, PinMode.Output);
            controller.Write(pin, PinValue.Low);
            controller.ClosePin(pin);
        }

        public void ControlSlot(Slot slot, bool power)
        {
            if (power)
            {
                StartPin((int)slot);
            }
            else
            {
                StopPin((int)slot);
            }
        }
    }
}
