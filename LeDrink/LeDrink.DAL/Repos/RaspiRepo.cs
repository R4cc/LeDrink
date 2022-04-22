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
            PWMSlot((int)slot, milliliter);
        }

        public void FlushSlot(int slot)
        {
            StartPin(slot);
            Task.Delay(10000).Wait();
            StopPin(slot);
        }

        private void PWMSlot(int pin, int milliliter)
        {
            var runTime = (milliliter / (1800 / 60)) * 1000;

            Console.WriteLine("Run for {0} ms", runTime);

            // (runTime / 2)

            for (int i = 0; i <= (runTime / 4); i++)
            {
                StartPin(pin);
                Task.Delay(1).Wait();
                StopPin(pin);
                Task.Delay(1).Wait();
            }

            Console.WriteLine("DONE");
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

        public void Flush()
        {
            FlushSlot((int)Slot.Slot1);
            FlushSlot((int)Slot.Slot2);
            FlushSlot((int)Slot.Slot3);
            FlushSlot((int)Slot.Slot4);
        }
    }
}