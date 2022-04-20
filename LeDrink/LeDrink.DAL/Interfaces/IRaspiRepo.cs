using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IRaspiRepo
    {
        void ControlSlot(Slot slot, int milliliter);
        Task MakeDrink(Drink drink);
        Task Flush();
    }
}