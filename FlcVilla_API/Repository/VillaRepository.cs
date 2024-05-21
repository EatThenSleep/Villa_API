using FlcVilla_API.Data;
using FlcVilla_API.Models;
using FlcVilla_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FlcVilla_API.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdateDate = DateTime.Now;
            if(entity != null)
            {
                _db.Villas.Update(entity);
                await _db.SaveChangesAsync();

            }
            return entity;
        }
    }
}
