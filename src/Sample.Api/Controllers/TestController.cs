using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public IRequestClient<PingRequest> _client { get; }

        public TestController(IRequestClient<PingRequest> client)
        {
            _client = client;
        }

        //[HttpGet("ping")]
        [HttpGet]
        //[HttpGet("secondping")]
        public async Task<ActionResult> Ping()
        {
            var pong = await _client.GetResponse<PingResponse>(new
            {
                ping = "ping",
                secondping= "ping",
                thirdping = "ping"
            }) ;

           return Ok(pong);
            //return Ok(pong.Message);
            //return Ok();

        }

    }
}
