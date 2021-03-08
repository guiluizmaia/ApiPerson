
using IntegraçãoBD.Data.VO;
using IntegraçãoBD.Model;
using System.Collections.Generic;

namespace IntegraçãoBD.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
