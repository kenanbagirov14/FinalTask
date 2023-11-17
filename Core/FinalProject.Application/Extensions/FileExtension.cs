using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject.Application.Extensions
{
    public static class ImageExtension
    {
        
        private static readonly string _uploadFolderPath = "images";
        public static Tuple<string, string> SaveFile(this IFormFile file, IWebHostEnvironment _env, int Height = default, int Width = default)
        {
            if (file == null || file.Length == 0)
            {
                return new Tuple<string, string>("", "");
            }

            string uniqueFileName = $"{Guid.NewGuid().ToString()}_{file.FileName}";

            var filePath= Path.Combine("/",_uploadFolderPath, uniqueFileName);
            var fullFilePath = Path.Combine(_env.WebRootPath, _uploadFolderPath, uniqueFileName);

            using (var stream = new FileStream(fullFilePath, FileMode.Create))
            {
                 file.CopyTo(stream);
            }

            return new Tuple<string,string>(filePath,fullFilePath);
        }

        public static async Task<Tuple<string, string>> SaveFileAsync(this IFormFile file, IWebHostEnvironment _env)
        {
            if (file == null || file.Length == 0)
            {
                return new Tuple<string, string>("","");
            }
            var uniqueFileName = $"{Guid.NewGuid().ToString()}_{file.FileName}";
            var filePath = Path.Combine("/", _uploadFolderPath, uniqueFileName);
            var fullFilePath = Path.Combine(_env.WebRootPath, _uploadFolderPath, uniqueFileName);

            using (var stream = new FileStream(fullFilePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return new Tuple<string, string>(filePath, fullFilePath); ;
        }



    }
}
