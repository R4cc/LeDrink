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
            var runTime = (milliliter / (1700 / 60));

            for (int i = 0; i <= (runTime * 2); i++)
            {
                StartPin(pin);
                Task.Delay(1).Wait();
                StopPin(pin);
                Task.Delay(1).Wait();
            }
        }

        private void PumpTime()
        {
            StartPin(40);
            Task.Delay(Convert.ToInt32(0.016 * 100 * 1000)).Wait();
            StopPin(40);
        }

        public Task MakeDrink(Drink drink)
        {
            List<Task> tasks = new List<Task>();

            foreach (var mix in drink.Mixes)
            {
                switch (mix.Bottle.BottleSlotId)
                {
                    case 1:
                        tasks.Add(new(() =>
                        {
                            ControlSlot(Slot.Slot1, (int)mix.Milliliters);
                        }));
                        break;
                    case 2:
                        tasks.Add(new(() =>
                        {
                            ControlSlot(Slot.Slot2, (int)mix.Milliliters);
                        }));
                        break;
                    case 3:
                        tasks.Add(new(() =>
                        {
                            ControlSlot(Slot.Slot3, (int)mix.Milliliters);
                        }));
                        break;
                    case 4:
                        tasks.Add(new(() =>
                        {
                            ControlSlot(Slot.Slot4, (int)mix.Milliliters);
                        }));
                        break;
                }

            }

            Task.WaitAll(tasks.ToArray());

            return Task.CompletedTask;
        }
    }
}
