
using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;

namespace FisioFinancials.Domain.Model.Interfaces.Repositories;

public interface IReceivedRepository
{
    Task AddAsync(Received received);
    Task<Received> GetByIdAsync(int id);
    Task<List<Received>> GetAllAsync();
    Task UpdateAsync(int id, ReceivedDTO receivedDTO);
    Task DeleteAsync(int id);
}
