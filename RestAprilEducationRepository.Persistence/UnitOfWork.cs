using RestAprilEducationRepository.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Persistence
{
    internal class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
