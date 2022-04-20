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

            Task.Delay((milliliter / (1700 / 60)) * 1000).Wait();

            StopPin(pin);
        }

        private void PumpTime()
        {
            StartPin(40);
            Task.Delay(Convert.ToInt32(0.016 * 100 * 1000)).Wait();
            StopPin(40);
        }

        public Task MakeDrink(Drink drink)
        {
            foreach (var mix in drink.Mixes)
            {
                switch (mix.Bottle.BottleSlotId)
                {
                    case 1:
                        ControlSlot(Slot.Slot1, (int)mix.Milliliters);
                        break;
                    case 2:
                        ControlSlot(Slot.Slot2, (int)mix.Milliliters);
                        break;
                    case 3:
                        ControlSlot(Slot.Slot3, (int)mix.Milliliters);
                        break;
                    case 4:
                        ControlSlot(Slot.Slot4, (int)mix.Milliliters);
                        break;
                }
            }

            return Task.CompletedTask;
        }

        public async Task Flush()
        {
            ControlSlot(Slot.Slot1, 1000);
            ControlSlot(Slot.Slot2, 1000);
            ControlSlot(Slot.Slot3, 1000);
            ControlSlot(Slot.Slot4, 1000);
        }
    }
}
