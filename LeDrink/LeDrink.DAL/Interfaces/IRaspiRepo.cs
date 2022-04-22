using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IRaspiRepo
    {
        void ControlSlot(Slot slot, int milliliter);
        void Flush();
        void FlushSlot(int slot);
        Task MakeDrink(Drink drink);
    }
}