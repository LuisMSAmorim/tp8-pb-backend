using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;

namespace FisioFinancials.Domain.Model.Interfaces.Services;

public interface IReceivedService
{
    Task<List<Received>> GetAllAsync();
    Task<Received> GetByIdAsync(int id, bool SendVisualizationMessage);
    Task CreateAsync(ReceivedDTO receivedDTO);
    Task UpdateAsync(int id, ReceivedDTO receivedDTO);
    Task DeleteAsync(int id);
}
