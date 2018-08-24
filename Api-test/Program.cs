using System;
using System.Net.Http;
using System.Net.Http.Headers;
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


        // c# code to make the http request (modify the headers)
        // parse the response as json
        // prase the json into the right object

        // class Article {
        //     string title;
        // }

         static void Main(string[] args)
            {   
            //This are test case scenario which are being called by the class library created
            //probably all the functions are to build in stringUtility(stringLibrary.cs) and are to be implemented here 
            // Console.WriteLine("hello World!");
            // stringUtility.StringLibrary clsString = new stringUtility.StringLibrary ();
            // Console.WriteLine(clsString.StartsWithUpper("kts"));
            // Console.WriteLine(clsString.IsStringPalindrome("12321"));
            // //clsString.BadResponseException();
            // ApiTest.Exception ex = new ApiTest.Exception ();
            // ex.BadResponseException();
            // ex.InvalidKey();
            // string u = GetRequest("http://www.google.com");
            // Console.WriteLine(u);
            GetRequest("http://www.google.com");
            Console.ReadKey();
            
            }
            //testing with http request
            async static void GetRequest(string url)
            {
                using (HttpClient client = new HttpClient())
                {
                    using(HttpResponseMessage response = await client.GetAsync(url))
                    {
                        using(HttpContent content = response.Content)
                        {
                            
                            HttpContentHeaders  headers = content.Headers;
                            
                                //string mycontent = await content.ReadAsStringAsync();
                                //Console.WriteLine(mycontent); 
                                  Console.WriteLine(headers);
                            
                        }
                    } 
                }
            }
        
    }
}