using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Exceptions;
using FisioFinancials.Domain.Model.Interfaces.Repositories;
using FisioFinancials.Domain.Model.Interfaces.Services;
using FisioFinancials.Infrastructure.Shared;
using System.Net;

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

    public async Task<ApiResponse<Received>> CreateAsync(ReceivedDTO receivedDTO)
    {
        Received received = new()
        {
            City = receivedDTO.City,
            Date = receivedDTO.Date,
            Local = receivedDTO.Local,
            PatientName = receivedDTO.PatientName,
            Value = receivedDTO.Value
        };

        await _repository.AddAsync(received);

        return new ApiResponse<Received>(null, "Success", HttpStatusCode.Created);
    }

    public async Task<ApiResponse<Received>> DeleteAsync(int id)
    {
        try
        {
            await _repository.DeleteAsync(id);
            return new ApiResponse<Received>(null, "Success", HttpStatusCode.OK);
        }
        catch (ResourceNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return new ApiResponse<Received>(null, "Resource not found", HttpStatusCode.NotFound);
        }
    }

    public async Task<ApiResponse<List<Received>>> GetAllAsync()
    {
        List<Received> receiveds = await _repository.GetAllAsync();

        return new ApiResponse<List<Received>>(receiveds, "Success", HttpStatusCode.OK);
    }

    public async Task<ApiResponse<Received>> GetByIdAsync(int id)
    {
        Received received = await _repository.GetByIdAsync(id);

        return new ApiResponse<Received>(received, "Success", HttpStatusCode.OK);
    }

    public async Task<ApiResponse<Received>> UpdateAsync(int id, ReceivedDTO receivedDTO)
    {
        Received received = await _repository.GetByIdAsync(id);

        if (received == null)
        {
            return new ApiResponse<Received>(null, "Resource not found", HttpStatusCode.NotFound);
        }

        received.Date = receivedDTO.Date;
        received.Local = receivedDTO.Local;
        received.PatientName = receivedDTO.PatientName;
        received.Value = receivedDTO.Value;

        await _repository.UpdateAsync(received);

        return new ApiResponse<Received>(null, "Success", HttpStatusCode.OK);
    }
}
