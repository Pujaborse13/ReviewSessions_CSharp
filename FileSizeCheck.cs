using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    //Q.6 ) Custom File Read Exception: Raise a custom exception if a file size is too large.
    internal class FileSizeCheck
    {
        public string FilePath = @"D:\AcessMeditech\ReviewSession_4\ReviewSession_4\demo.txt";

        public void CheckFileSize()
        {

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File Not Exist");
                return;
            }

            Console.WriteLine("File Exist");



            long fileSize = new FileInfo(FilePath).Length;
            long maxSizeInBytes = 1024 * 1024; // 1 MB limit

            Console.WriteLine($"Current file size: {fileSize} bytes ({fileSize / 1024} KB)");

            try
            {
                if (fileSize > maxSizeInBytes)
                {
                    throw new FileTooLargeException($"File '{FilePath}' is too large ({fileSize} bytes). Max allowed: {maxSizeInBytes} bytes.");
                }

                Console.WriteLine("file Size is less than limit");
            }

            catch (FileTooLargeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);


            }
        }


    }


}

