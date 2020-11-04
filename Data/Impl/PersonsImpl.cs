using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class PersonsImpl 
    {

        private string toFile = @"C:\JetBrains Rider staff\C# files\adults.json";

        private IList<Adult> personsList;

        public PersonsImpl()
        {
            if (!File.Exists(toFile))
            {
                seed();
                writeToFile();
            }
            else
            {
                string content = File.ReadAllText(toFile);
                personsList = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }
        
        public List<Adult> GetPersons()
        {
            List<Adult> persons = (List<Adult>)personsList;
            return persons;
        }

        public void AddPerson(Adult person)
        {
            personsList.Add(person);
            writeToFile();
        }

        public void RemovePerson(int id)
        {
            Adult toRemove = personsList.First(person => person.ID == id);
            personsList.Remove(toRemove);
            writeToFile();
        }

        

        public void seed()
        {
            HairColor hairColor = new HairColor();
            EyeColor eyeColor = new EyeColor();
            Job job = new Job();
            
            Adult[] persons = {new Adult
                {
                    firstName = "Alex", lastName = "Clinton", ID = 1, hairColor = 
                    hairColor.blackColor, eyeColor = eyeColor.blueColor, age = 17, weight = 80,
                    height = 170, job = job.astronautJob
                }, new Adult
                {
                    firstName = "John", lastName = "Smith", ID = 2, hairColor = 
                        hairColor.blueColor, eyeColor = eyeColor.brownColor, age = 20, weight = 73,
                    height = 180, job = job.captainJob
                }, new Adult
                {
                    firstName = "Sara", lastName = "Jordan", ID = 3, hairColor = 
                        hairColor.brownColor, eyeColor = eyeColor.greyColor, age = 30, weight = 60,
                    height = 173, job = job.chefJob
                }
            };

            personsList = persons.ToList();
        }


        public void writeToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(personsList);
            File.WriteAllText(toFile, productsAsJson);
        }
        
        
    }
}