using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Infrastructure.Shared;

namespace FisioFinancials.Domain.Model.Interfaces.Services;

public interface IReceivedService
{
    Task<ApiResponse<List<Received>>> GetAllAsync();
    Task<ApiResponse<Received>> GetByIdAsync(int id);
    Task<ApiResponse<Received>> CreateAsync(ReceivedDTO receivedDTO);
    Task<ApiResponse<Received>> UpdateAsync(int id, ReceivedDTO receivedDTO);
    Task<ApiResponse<Received>> DeleteAsync(int id);
}
