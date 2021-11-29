using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.ImageStorage
{
    public interface IImageStorage
    {
        Task<string> StoreImage(string uploadsFolderPath, IFormFile file);
    }
}
