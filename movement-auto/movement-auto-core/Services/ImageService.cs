using Microsoft.AspNetCore.Http;
using movement_auto_core.Interfaces;
using movement_auto_data;
using movement_auto_data.ImageStorage;
using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_core.Services
{
    public class ImageService : IIMageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImageStorage _imageStorage;

        public ImageService(IUnitOfWork unitOfWork, IImageStorage imageStorage)
        {
            _unitOfWork = unitOfWork;
            _imageStorage = imageStorage;
        }
        public async Task<Image> UploadImage(Vehicle vehicle, IFormFile file, string uploadsFolderPath)
        {
            string fileName = await _imageStorage.StoreImage(uploadsFolderPath, file);

            Image image = new() { FileName = fileName };
            vehicle.Images.Add(image);
            await _unitOfWork.CompleteAsync();

            return image;
        }
    }
}
