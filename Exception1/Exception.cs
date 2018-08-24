using System;

namespace Exception1
{
    public class Exception
    {
        public void BadResponseException()
        { 
            Console.WriteLine("BadResponseException");
        }
        
        public void InvalidKey()
        {
            Console.WriteLine("Please Make Sure Your Api key is set properly");
        }

        public void NotPremiumException()
        {
            Console.WriteLine("You are not a premium user. Visit https://cryptocontrol.io/about/premium for more info");
        }

    }
}
