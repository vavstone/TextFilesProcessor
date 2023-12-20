using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Text;

namespace TextFilesProcessor
{
    public static class ZipHelper
    {

        public static string DecompressString(string str)
        {
            string result = string.Empty;
            var zip = Convert.FromBase64String(str.Replace(System.Environment.NewLine, "").Replace(" ", ""));
            using (var inStream = new MemoryStream(zip))
            {
                using (ZipInputStream s = new ZipInputStream(inStream))
                {

                    ZipEntry theEntry;
                    while ((theEntry = s.GetNextEntry()) != null)
                    {
                        using (var outStream = new MemoryStream())
                        {
                            int size = 1024;
                            byte[] data = new byte[size];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    outStream.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            result = Encoding.UTF8.GetString(outStream.ToArray());
                        }
                    }
                }
            }

            return result;
        }




        

     

        public static string CompressString(string str)
        {
            string result = string.Empty;
            var data = UTF8Encoding.UTF8.GetBytes(str);
            using (var outstream = new MemoryStream())
            {
                using (ZipOutputStream zipOStream = new ZipOutputStream(outstream))
                {
                    zipOStream.UseZip64 = UseZip64.Off;
                    var entry = new ICSharpCode.SharpZipLib.Zip.ZipEntry("zip");
                    entry.DateTime = DateTime.Now;
                    zipOStream.PutNextEntry(entry);
                    using (var inStream = new MemoryStream(data))
                    {
                        byte[] transferBuffer = new byte[1024];
                        int bytesRead;
                        do
                        {
                            bytesRead = inStream.Read(transferBuffer, 0, transferBuffer.Length);
                            zipOStream.Write(transferBuffer, 0, bytesRead);
                        } while (bytesRead > 0);
                    }
                    zipOStream.Finish();
                    zipOStream.Close();
                }
                result = Convert.ToBase64String(outstream.ToArray());
            }
            return result;
        }

       
    }

  
}
