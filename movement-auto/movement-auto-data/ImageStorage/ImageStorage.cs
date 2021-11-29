using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.ImageStorage
{
    /// <summary>
    /// File system image storage
    /// </summary>
    public class ImageStorage : IImageStorage
    {
        public async Task<string> StoreImage(string uploadsFolderPath, IFormFile file)
        {
            if (!Directory.Exists(uploadsFolderPath))
                Directory.CreateDirectory(uploadsFolderPath);

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(uploadsFolderPath, fileName);

            using (var filestream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(filestream);
            }

            return fileName;
        }
    }
}
