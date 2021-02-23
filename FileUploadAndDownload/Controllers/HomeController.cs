using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FileUploadAndDownload.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FileUploadAndDownload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FileDownload()
        {
            string[] filepaths = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Upload/"));
            List<FileModel> list = new List<FileModel>();

            foreach (string filepath in filepaths)
            {
                list.Add(new FileModel { FileName = Path.GetFileName(filepath) });
            }
            return View(list);
        }
        public FileResult DownloadFile(string filename)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Upload/") + filename;


            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", filename);
        }

        public IActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> FileUpload(IFormFile file)
        {
            await UploadFile(file);
            TempData["msg"] = "File Uploaded Successfully";
            return View();
        }

        public async Task<bool> UploadFile(IFormFile file)
        {
            string path = "";
            bool isCopied = false;

            try
            {
                if (file.Length > 0)
                {
                    string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "Upload"));

                    using(var filestream=new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        await file.CopyToAsync(filestream);
                    }

                    isCopied = true;
                }

                else
                {
                    isCopied = false;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isCopied;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
