using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialApi.Models;
using FinancialApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinancialApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService service;

        public AccountController(IAccountService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            var accounts = await service.GetAccounts();
            return Ok(accounts);
        }

        [HttpGet("{id}/balance")]
        public async Task<ActionResult<double>> GetBalance(Guid id)
        {
            try
            {
                var balance = await service.GetBalance(id);
                return Ok(balance);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(Guid id)
        {
            try
            {
                var account = await service.GetAccount(id);
                return Ok(account);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Account>> PostAccount(AccountRequest request)
        {
            try
            {
                var account = await service.RegisterAccount(request);
                return Ok(account);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("{id}/increase")]
        public async Task<ActionResult> Increase(Guid id, [FromBody] double count)
        {
            try
            {
                await service.Increase(id, count);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPatch("{id}/reduce")]
        public async Task<ActionResult> Reduce(Guid id, [FromBody] double count)
        {
            try
            {
                await service.Reduce(id, count);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(Guid id)
        {
            try
            {
                await service.DeleteAccount(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}