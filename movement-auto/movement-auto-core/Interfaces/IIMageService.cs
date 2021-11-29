using Microsoft.AspNetCore.Http;
using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_core.Interfaces
{
    public interface IIMageService
    {
        Task<Image> UploadImage(Vehicle vehicle, IFormFile file, string uploadsFolderPath);
    }
}
