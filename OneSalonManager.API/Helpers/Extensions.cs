using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace OneSalonManager.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", HtmlEncoder.Default.Encode(message));
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            if(theDateTime.AddYears(age) > DateTime.Today)
                age--;

            return age;
        }
    }
}