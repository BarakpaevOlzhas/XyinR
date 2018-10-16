using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace mailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person
            //{
            //    Phone = "77029742404",
            //    Message = "dagestan",
            //};

            string parameteres = "\"phone\": \"77029742404\"&\"message\": \"dagestan\"";
            //string json = @"{
            //    ""phone"":""77029742404"",
            //    ""body"":""dagestan"",
            // }'";

            var httpRequest = (HttpWebRequest)WebRequest.Create("https://eu10.chat-api.com/instance13606/message?token=sknjtt7j5tjmm72z");
            httpRequest.Method = "POST";
            var body = Encoding.UTF8.GetBytes(parameteres);
            httpRequest.ContentType = "application/json";
            httpRequest.ContentLength = parameteres.Length;
            using (Stream stream = httpRequest.GetRequestStream())
            {
                stream.Write(body, 0, body.Length);
            }

            using (HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse())
            {
                response.Close();
            }
        }

    }
}
//string jsonData = JsonConvert.SerializeObject(person);

//var body = Encoding.UTF8.GetBytes(jsonData);
//var request = (HttpWebRequest)WebRequest.Create("https://eu10.chat-api.com/instance13606/message?token=sknjtt7j5tjmm72");

//request.Method = "POST";
//request.ContentType = "application/json";
//request.ContentLength = body.Length;

//using (Stream stream = request.GetRequestStream())
//{
//    stream.Write(body, 0, body.Length);
//    stream.Close();
//}

//using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
//{
//    response.Close();
//}