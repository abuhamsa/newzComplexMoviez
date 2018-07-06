using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    //OLDER OWN CLASS FOR MAKING HTTP CALLS OVER POST OR GET
    //TODO: TAKE A CLOSER LOOK IF THIS IS STILL WORKING
    //TODO: DOCUMENTING THIS STUFF
    class HTTPCom
    {

        public String url;

        public HTTPCom(String m_url)
        {

            this.url = m_url;

        }


        public string POST(string m_postData, string method)
        {

            var request = (HttpWebRequest)WebRequest.Create(url + method);

            var postData = m_postData;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString.ToString();

        }

        public string GET(string method)
        {
            var request = (HttpWebRequest)WebRequest.Create(url + method);

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString.ToString();
        }


    }
}
