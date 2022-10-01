using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeQrCode.Models
{
    public class Base64Converter
    {

        public static string ConvertFileToBase64(string fileName)
        {
            return Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName));
        }


        public static void ConvertBase64ToFile(string fileName, string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);
            fs.Write(base64EncodedBytes, 0, base64EncodedBytes.Length);
            fs.Close();
        }

    }
}
