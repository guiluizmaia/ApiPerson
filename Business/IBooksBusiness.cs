﻿using IntegraçãoBD.Data.VO;
using System.Collections.Generic;

namespace IntegraçãoBD.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO books);
        BooksVO FindByID(long id);
        List<BooksVO> FindAll();
        BooksVO Update(BooksVO books);
        void Delete(long id);
    }
}
