using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        try
        {
            string url = @"https://telerikacademy.com/Content/Images/";
            string fileName = "news-img01.png", urldirectory = null;
            using (WebClient wc = new WebClient())
            {
                urldirectory = url + fileName;
                wc.DownloadFile(urldirectory, fileName);
            }
        }
        catch (ArgumentNullException s)
        {
            Console.WriteLine(s.Message, s.StackTrace);
        }
        catch (WebException s)
        {
            Console.WriteLine(s.Message, s.StackTrace);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine();
        }
    }
}