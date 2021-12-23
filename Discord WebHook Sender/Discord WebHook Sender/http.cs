using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Webhook_Sender
{
    internal class http
    {
        public http()
        {
        }

        public static byte[] Post(string url, NameValueCollection pairs)
        {
            byte[] numArray;
            using (WebClient webClient = new WebClient())
            {
                numArray = webClient.UploadValues(url, pairs);
            }
            return numArray;
        }
    }
}
