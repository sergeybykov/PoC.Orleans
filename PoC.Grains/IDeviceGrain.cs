using Orleans;
using System;
using System.Threading.Tasks;

namespace PoC.Grains
{
    public interface IDeviceGrain : IGrainWithGuidKey
    {
        Task Foo();
    }
}
