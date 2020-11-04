using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Data.Impl;

namespace LoginExample.Data
{
    public interface IPersons
    {
        Task<List<Adult>> GetPersons();

        Task AddPerson(Adult person);

        Task RemovePerson(int id);

        
    }
}