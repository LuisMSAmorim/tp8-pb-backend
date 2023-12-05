
using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;

namespace FisioFinancials.Domain.Model.Interfaces.Repositories;

public interface IReceivedRepository
{
    Task<Received> AddAsync(Received received);
    Task<Received> GetByIdAsync(int id);
    Task<List<Received>> GetAllAsync();
    Task<Received> UpdateAsync(Received received);
    Task DeleteAsync(int id);
}
