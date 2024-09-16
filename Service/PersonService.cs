using Model.DataService;
using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public  class PersonService
    {
        private readonly PersonDataService _personDataService;

        #region [- Ctor -]
        public PersonService()
        {
            _personDataService = new PersonDataService();
        }
        #endregion

        #region [- FillGrid() -]

        public List<Person> FillGrid() => _personDataService.SelectAll();

        #endregion

        #region [- Save() -]
        public void Save(Person person) => _personDataService.Insert(person);
        #endregion

        #region [- Edit() -]
        public void Edit(int id, Person person) => _personDataService.Update(id, person);
        #endregion

        #region [- Delete() -]
        public void Delete(int id) => _personDataService.Delete(id);
        #endregion
    }
}
