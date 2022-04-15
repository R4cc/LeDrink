namespace LeDrink.DAL.Interfaces
{
    public interface IFileUpload
    {
        Task Upload(BlazorInputFile.IFileListEntry file);
    }
}
