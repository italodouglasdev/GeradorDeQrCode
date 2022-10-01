using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeQrCode.Models
{
    public class QrCode
    {

        public Bitmap bitmap { get; set; }

        public string  base64 { get; set; }



        public static QrCode Gerar(string Texto)
        {
            var qr = new QrCode();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Texto, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qr.bitmap = qrCode.GetGraphic(20);



            return qr;

        }

    }
}
