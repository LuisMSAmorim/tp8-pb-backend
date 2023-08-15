
using System.Data.Entity;
using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Interfaces.Repositories;
using FisioFinancials.Infrastructure.Data.Context;

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

    public async Task DeleteAsync(Received received)
    {
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

    public async Task UpdateAsync(int id, ReceivedDTO receivedDTO)
    {
        var received = await _context.Receiveds.FindAsync(id);

        if (received == null)
            throw new Exception("Received not found");

        received.PatientName = receivedDTO.PatientName;
        received.Value = receivedDTO.Value;
        received.City = receivedDTO.City;
        received.Local = receivedDTO.Local;
        received.Date = receivedDTO.Date;

        await _context.SaveChangesAsync();
    }
}
