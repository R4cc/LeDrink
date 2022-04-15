using BlazorInputFile;
using LeDrink.DAL.Interfaces;

namespace LeDrink.DAL.Repos
{
    public class FileUpload : IFileUpload
    {
        public async Task Upload(IFileListEntry file)
        {
            string fileName = (DateTime.Now.ToString("yyyy-MM-dd-h-mm-ss") + file.Name).Replace(" ", "_");
            var path = Path.Combine(@"./wwwroot/images/bottles", fileName);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using(FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
