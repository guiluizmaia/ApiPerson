<<<<<<< HEAD
﻿
using IntegraçãoBD.Model;
using System.Collections.Generic;

namespace IntegraçãoBD.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
=======
﻿
using IntegraçãoBD.Model;
using System.Collections.Generic;

namespace IntegraçãoBD.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
>>>>>>> b229451315734d9b753d51cf563749aeefb4c74f
