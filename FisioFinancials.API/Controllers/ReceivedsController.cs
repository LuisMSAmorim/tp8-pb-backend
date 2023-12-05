using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Domain.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace FisioFinancials.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReceivedsController : ControllerBase
{
    private readonly IReceivedService _receivedService;

    public ReceivedsController
    (
        IReceivedService receivedService
    )
    {
        _receivedService = receivedService;
    }

    // GET: api/<ReceivedsController>
    [HttpGet]
    public async Task<List<Received>> Get()
    {
        return await _receivedService.GetAllAsync();
    }

    // GET api/<ReceivedsController>/5
    [HttpGet("{id}")]
    public async Task<Received> Get(int id)
    {
        return await _receivedService.GetByIdAsync(id);
    }

    // POST api/<ReceivedsController>
    [HttpPost]
    public async Task<CreatedResult> Post([FromBody] ReceivedDTO receivedDTO)
    {
        Received received = await _receivedService.CreateAsync(receivedDTO);
        return Created("receiveds", received);
    }

    // PUT api/<ReceivedsController>/5
    [HttpPut("{id}")]
    public async Task<NoContentResult> Put(int id, [FromBody] ReceivedDTO receivedDTO)
    {
        await _receivedService.UpdateAsync(id, receivedDTO);
        return NoContent();
    }

    // DELETE api/<ReceivedsController>/5
    [HttpDelete("{id}")]
    public async Task<NoContentResult> Delete(int id)
    {
        await _receivedService.DeleteAsync(id);
        return NoContent();
    }
}
