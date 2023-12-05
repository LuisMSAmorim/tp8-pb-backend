using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Exceptions;
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

    public async Task<Received> CreateAsync(ReceivedDTO receivedDTO)
    {
        var (PatientName, Value, City, Local, Date) = receivedDTO;

        Received received = new(PatientName, Value, City, Local, Date);

        return await _repository.AddAsync(received);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<List<Received>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Received> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Received> UpdateAsync(int id, ReceivedDTO receivedDTO)
    {
        Received received = await _repository.GetByIdAsync(id);

        if (received == null)
        {
            throw new ResourceNotFoundException("Resource not found");
        }

        (received.PatientName, received.Value, received.City, received.Local, received.Date) = receivedDTO;

        return await _repository.UpdateAsync(received);
    }
}
