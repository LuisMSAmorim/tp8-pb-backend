using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Interfaces.Repositories;
using FisioFinancials.Domain.Model.Interfaces.Services;

namespace FisioFinancials.Domain.Services.Services;

public sealed class ReceivedService : IReceivedService
{
    private readonly IReceivedRepository _repository;

    public ReceivedService
    (
        IReceivedRepository repository
    )
    {
        _repository = repository;   
    }

    public Task CreateAsync(Received received)
    {
        
    }

    public Task DeleteAsync(ReceivedDTO received)
    {
        throw new NotImplementedException();
    }

    public Task<List<Received>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Received> GetByIdAsync(int id, bool SendVisualizationMessage)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, ReceivedDTO receivedDTO)
    {
        throw new NotImplementedException();
    }
}
