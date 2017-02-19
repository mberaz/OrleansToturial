using System.Threading.Tasks;
using Orleans;
using GrainInterfaces;
using System;

namespace Grains
{
    /// <summary>
    /// Grain implementation class MyGrain.
    /// </summary>
    public class MyGrain : Grain, IMyGrain
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }
    }
}

