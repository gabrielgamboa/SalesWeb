using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Services.Exceptions;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext _context;

        public SellerService (SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync ()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task Insert (Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync (int id)
        {
            //include = join
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(seller => seller.Id == id);
        }

        public async Task RemoveAsync (int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync (Seller obj)
        {

            var hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            //caso não existir esse id:
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }

        }

    }
}
