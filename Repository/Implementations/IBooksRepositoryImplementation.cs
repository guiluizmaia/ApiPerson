using IntegraçãoBD.Model;
using IntegraçãoBD.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraçãoBD.Repository.Implementations
{
    public class BooksRepositoryImplementation : IBooksRepository
    {
        private MySQLContext _context;

        public BooksRepositoryImplementation (MySQLContext context)
        {
            _context = context;
        }
        public Books Create(Books books)
        {
            try
            {
                _context.Add(books);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return books;
        }

        public void Delete(long id)
        {
            var result = _context.Bookss.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Bookss.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
               

        public List<Books> FindAll()
        {
            return _context.Bookss.ToList();
        }

        public Books FindByID(long id)
        {
            return _context.Bookss.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Books Update(Books books)
        {
            if (!Exists(books.Id)) return new Books();

            var result = _context.Bookss.SingleOrDefault(p => p.Id.Equals(books.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(books);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return books;
        }
        public bool Exists(long id)
        {
            return _context.Bookss.Any(p => p.Id.Equals(id));
        }
    }
}
