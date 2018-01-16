using BookModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace BooksSearch.GoogleAPIClient
{
    public class GoogleAPIs
    {
        const string baseurl = "https://www.googleapis.com";
        //api caller for default parm return all
        public static async Task<List<items>> Results()
        {
            var bookResult = new List<items>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("/books/v1/volumes?q=English");

                if (Res.IsSuccessStatusCode)
                {
                    string catagoryResponse = Res.Content.ReadAsStringAsync().Result;

                    string TrimedRsponse = JsonTrimer(catagoryResponse);//remov extra bress
                    int ind = TrimedRsponse.Length-2;
                    var finals = TrimedRsponse.Remove(ind);
                    string myfinalTrim = finals;
                    var js = new JavaScriptSerializer();

                    bookResult = (List<items>)js.Deserialize(myfinalTrim, typeof(List<items>));

                }
                return bookResult.ToList();
            }
        }


        //remove extera curly bress
        static string JsonTrimer(string jsonResponse)
        {
            var indexValue = jsonResponse.IndexOf('[');

            var leftTrimedResponse = jsonResponse.Remove(0, indexValue);

            var rightTrimedResponse = leftTrimedResponse.TrimEnd('}');
            var r = rightTrimedResponse;
            var finale = r.TrimEnd('}');
            return finale;
        }






        ////api caller fro catagorys
        //public static async Task<List<items>> Results(dynamic userInput)
        //{
        //    var bookResult = new List<items>();

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseurl);

        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage Res = await client.GetAsync("v1/volumes?q=" + userInput);

        //        if (Res.IsSuccessStatusCode)
        //        {
        //            var catagoryResponse = Res.Content.ReadAsStringAsync().Result;

        //            string TrimedRsponse = JsonTrimer(catagoryResponse);//remov extra bress
        //            string myTrime = TrimedRsponse.TrimEnd('}');
        //            var js = new JavaScriptSerializer();

        //            bookResult = (List<items>)js.Deserialize(myTrime, typeof(List<items>));

        //        }
        //        return bookResult.ToList();
        //    }
        //}
    }
}
