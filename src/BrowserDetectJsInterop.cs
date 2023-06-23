using Microsoft.JSInterop;

namespace PSC.Blazor.Components.BrowserDetect
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class BrowserDetectJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserDetectJsInterop"/> class.
        /// </summary>
        /// <param name="jsRuntime">The js runtime.</param>
        public BrowserDetectJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", 
                "./_content/PSC.Blazor.Components.BrowserDetect/js/browserDetect.js").AsTask());
        }

        /// <summary>
        /// Browsers the information.
        /// </summary>
        /// <param name="dotNetObjectRef">The dot net object reference.</param>
        /// <returns>BrowserInfo.</returns>
        public async ValueTask<BrowserInfo> BrowserInfo(DotNetObjectReference<BrowserDetect> dotNetObjectRef)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<BrowserInfo>("browserDetect", dotNetObjectRef);
        }

        /// <summary>
        /// Dispose as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;ValueTask&gt; representing the asynchronous operation.</returns>
        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}