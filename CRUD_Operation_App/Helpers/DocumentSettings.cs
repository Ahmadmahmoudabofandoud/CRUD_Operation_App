using Microsoft.AspNetCore.Http;
using System;
using System.IO;


namespace CRUD_Operation_App.Helpers
{
    //Common Module 
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            // 1. Get Located Folder Path
            //string folderPath = "D:\\El-asdekaa\\Documents\\Projects\\CRUD_Operation_App-Solution\\CRUD_Operation_App\\wwwroot\\Files\\" + folderName;
            //string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\Files\\" +folderName;
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files" , folderName);

            // 2. Get File Name and Make it Unique
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            // 3. Get File Path
            string filePath = Path.Combine(folderPath, fileName);

            // 4. Save File {as Streams}=>(Data Per Time)
            using var fileStream = new FileStream(filePath,FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;
        }  


        public static void DeleteFile( string fileName,string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", folderName, fileName);
             if(File.Exists(filePath))
                File.Delete(filePath);
        }

    }
}
