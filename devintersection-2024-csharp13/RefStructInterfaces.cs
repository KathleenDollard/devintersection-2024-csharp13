using System.Runtime.InteropServices;

namespace CSharp13;


    ref struct File : IDisposable
    {
        private SafeHandle _handle;
        public void Dispose()
        {
            _handle.Dispose();
        }
    }

// ref struct can be useful for certain types of high perf/low allocations apps, 
// but it requires an investment to use safely, including ensuring that you respond
// to all warnings.

// - You can't cast a File to the interface (that would box, not allowed for ref struct)
// - The entire interface must be implemented, default interface methods cannot be used with ref struct interfaces
//   - This means your interface will break you users if you later change the interface