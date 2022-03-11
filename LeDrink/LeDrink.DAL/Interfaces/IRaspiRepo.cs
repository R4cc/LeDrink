using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IRaspiRepo
    {
        void ControlSlot(Slot slot, bool power);
    }
}