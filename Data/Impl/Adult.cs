using System;
using System.Text.Json.Serialization;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    
    public class Adult : Person
    {
        [JsonPropertyName("jobTitle")]
        public string job { set; get; }

        /*public Adult(string firstName, string lastName, int ID, string hairColor, 
            string eyeColor, int age, double weight, double height, string job) : base(firstName,
            lastName, ID, hairColor, eyeColor, age, weight, height)
        {
            this.job = job;
        }
        */

    }
}