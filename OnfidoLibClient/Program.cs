using Newtonsoft.Json;
using OnfidoLib.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace OnfidoLibClient
{
    //This project is not offcially supported or maintained by Onfido. It is available to use for demo purposes but we are unable to provide assistance for any technical queries.
    //The project is running a document & live photo check using Onfido API.
    class Program
    {
        static void Main(string[] args)
        {
            //set your Onfido API Token (sandbox or live)
            string apiToken = "";
            //set your document file that you want to test with or use the default sample_driving_licence.png (National ID, Passport, Driving Licence) - (JPG, PNG or PDF) 
            string docFilePath = "sample_driving_licence.png";
            //set your selfie file that you want to test with or use sample_live_photo.png
            string photoFilePath = "sample_live_photo.png";
            string apiVersion = "v3.2";
            string apiUrl = "api.eu.onfido.com";

            //create a doc + selfie check

            try
            {
                //initialize onfidoLib with onfido api token, version and url
                OnfidoLib.OnfidoLibApi api = new OnfidoLib.OnfidoLibApi(apiToken, apiVersion, apiUrl);

                Console.WriteLine("---------------- Applicant ----------------");

                //create the new applicant
                Applicant applicant = api.Applicants.Create(new Applicant() { FirstName = "OnfidoLib", LastName = "Test" });
                Console.WriteLine(JsonConvert.SerializeObject(applicant));

                Console.WriteLine();
                Console.WriteLine("---------------- Document ----------------");

                //upload driving licence
                Document doc = api.Documents.Create(applicant.Id, new FileStream(docFilePath, FileMode.Open), Path.GetFileName(docFilePath), DocumentType.DrivingLicence, DocumentSide.Front);
                Console.WriteLine(JsonConvert.SerializeObject(doc));

                Console.WriteLine();
                Console.WriteLine("---------------- Live Photo ----------------");

                //upload live photo
                LivePhoto photo = api.LivePhotos.Create(applicant.Id, new FileStream(photoFilePath, FileMode.Open), Path.GetFileName(photoFilePath));
                Console.WriteLine(JsonConvert.SerializeObject(photo));

                Console.WriteLine();
                Console.WriteLine("---------------- Check ----------------");

                //run the check
                Check check = api.Checks.Create(applicant.Id, new List<ReportsType>() { ReportsType.Document, ReportsType.Facial });
                Console.WriteLine(JsonConvert.SerializeObject(check));

                Console.WriteLine();
                Console.WriteLine("---------------- Done ----------------");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }


            Console.ReadKey();
        }
    }
}
