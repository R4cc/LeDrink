using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using System.Device.Gpio;

namespace LeDrink.DAL.Repos
{
    /// <summary>
    /// Direct interface with raspberry pi to controll pins
    /// </summary>
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

        public void ControlSlot(Slot slot, int milliliter)
        {
            FillSlot((int)slot, milliliter);
        }

        private void FillSlot(int pin, int milliliter)
        {
            StartPin(pin);

            Task.Delay((milliliter / 25) * 1000).Wait();

            StopPin(pin);
        }
    }
}
