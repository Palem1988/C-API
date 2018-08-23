using System;
namespace ApiTest
{
    class Program
    {     
        //  public string GetArticles(string coin = "dragonchain")
        // {
        //     string json = string.Empty;
        //     string url = @"https://cryptocontrol.io/api/v1/public/twitter/coin/";
 
        //     HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+coin);
        //     request.ContentType = "application/json; charset=utf-8";
        //     request.Headers.Add("x-api-key", "YOUR-API-KEY");
 
        //     using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //     using (Stream stream = response.GetResponseStream())
        //     using (StreamReader reader = new StreamReader(stream))
        //     {
        //         json = reader.ReadToEnd();
        //     }
        //     return json;
        // }

         static void Main(string[] args)
        {   
            //This are test case scenario which are being called by the class library created
            //probably all the functions are to build in stringUtility(stringLibrary.cs) and are to be implemented here 
            Console.WriteLine("hello World!");
            stringUtility.StringLibrary clsString = new stringUtility.StringLibrary ();
            Console.WriteLine(clsString.StartsWithUpper("kts"));
            Console.WriteLine(clsString.IsStringPalindrome("12321"));
        }
    }
}