using MassTransit;
using Sample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Components.Consumers
{
    public class PingConsumer : IConsumer<PingRequest>
    {
        public async Task Consume(ConsumeContext<PingRequest> context)
        {
           await context.RespondAsync<PingResponse>(new { 

               Ping = "Hello World",
               SecondPing="Hello Saturn!!"
           });
        }
    }
}
