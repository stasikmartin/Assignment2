using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LoginExample.Models;

namespace LoginExample.Data
{
      public abstract class Person 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        [Required, Range(1, int.MaxValue, ErrorMessage = "Enter a value bigger than 1")]
        
        [JsonPropertyName("id")]
        public int ID { get; set; }
        public string hairColor { get; set; }
        public string eyeColor { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        
        public string sex { get; set; }
        
        
       /* public Person(string firstName, string lastName, int id, string hairColor, string eyeColor,
            int age, double weight, double height)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            ID = id;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        */
        
        
        

    }
}