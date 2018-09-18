
using System.Threading.Tasks;
using Orleans;

namespace PoC.Grains.Implementation
{
    public class DeviceGrain : Grain, IDeviceGrain
    {
        public Task Foo()
        {
            return Task.CompletedTask;
        }
    }
}