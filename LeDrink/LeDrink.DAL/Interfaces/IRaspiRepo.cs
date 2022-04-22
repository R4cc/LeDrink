using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IRaspiRepo
    {
        Task ControlSlot(Slot slot, int milliliter);
        Task Flush();
        Task FlushSlot(int slot);
        Task MakeDrink(Drink drink);
    }
}