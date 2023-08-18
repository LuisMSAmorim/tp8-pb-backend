
using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Exceptions;
using FisioFinancials.Domain.Model.Interfaces.Repositories;
using FisioFinancials.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FisioFinancials.Infrastructure.Data.Repositories;

public sealed class ReceivedRepository : IReceivedRepository
{
    private readonly FisioFinancialsDbContext _context;

    public ReceivedRepository
    (
        FisioFinancialsDbContext context
    )
    {
        _context = context;
    }

    public async Task AddAsync(Received received)
    {
        _context.Receiveds.Add(received);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var received = await _context.Receiveds.FindAsync(id);

        if (received == null)
            throw new ResourceNotFoundException("Received not found");

        _context.Receiveds.Remove(received);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Received>> GetAllAsync()
    {
        return await _context.Receiveds.ToListAsync();
    }

    public async Task<Received> GetByIdAsync(int id)
    {
        return await _context.Receiveds.FindAsync(id);
    }

    public async Task UpdateAsync(Received received)
    {
        _context.Entry(received).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
