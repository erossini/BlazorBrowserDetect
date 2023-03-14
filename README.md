# Browser Detect for Blazor
This is a browser detect component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) with .NET6. If you need help or info about it, leave your message in the [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/). Read the full post on [PureSourceCode.com](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/).

Now, you can try your component by yourself from the website. [Try it now!](https://browserdetect.puresourcecode.com/)

![browsers](https://user-images.githubusercontent.com/9497415/153390277-3c9ef12c-5e4e-488e-bc3b-c02d84da5195.jpg)

## Detected capabilities or properties

| Property | Value |
| --- | --- |
| BrowserName | Name of the browser |
| BrowserMajor | Major version of the browser |
| BrowserVersion | Version of the browser |
| CPUArchitect | If it is possible, the component detect the CPU architecture of the machine |
| DeviceModel | Device model (if it is possible) |
| DeviceType | Device type (if it is possible) |
| DeviceVendor | Device Vendor (if it is possible) |
| EngineName | Browser engine name |
| EngineVersion | Browser engine version |
| GPURenderer | Type of the GPU renderer |
| GPUVendor | Vendor of the GPU |
| IsDesktop | Detect if the device is a desktop computer |
| IsMobile | Detect if the device is a mobile |
| IsTablet | Detect if the device is a tablet |
| IsAndroid | Detect if the device is an Android device |
| IsIPhone | Detect if the device is an iPhone or iPod |
| IsIPad | Detect if the device is an iPad (any version) |
| IsIPadPro | Detect if the device is an iPad Pro |
| OSName | Detect the operating system |
| OSVersion | Version of the operating system |
| ScreenResolution | Detect the screen resolution |
| TimeZone | Read the time zone |
| UserAgent | The full user agent |

### Detecting Windows

To detect the browser and all the other details from the user, it is not always accurate. For example, if the client has `Windows 11` there is no way to
return the correct version of the operating system. The JavaScript can detect the `OSName`, in this case `Windows` but not the exact version.

To detect in a correct way the correct version of the operating system and the architecture of the CPU, the component has to run few tests that take time.

For this reason I added 2 events in the component:

- WindowsArchitectureUpdate
- WindowsVersionUpdate

So, if you want to receive the notification when of the correct version of Windows and the CPU architecture, the component is like this code:

```
<BrowserDetect @bind-BrowserInfo="@Info" 
               WindowsArchitectureUpdate="WindowsArchitectureString"
               WindowsVersionUpdate="WindowsUpdateString" />
```

then the functions look like

```csharp
public BrowserInfo? Info { get; set; }
public string? WindowsInfo { get; set; } = "";
public string? WindowsCPUInfoString { get; set; }

private void WindowsArchitectureString(string cpu)
{
    WindowsCPUInfoString = cpu;
}

private void WindowsUpdateString(string version)
{
    WindowsInfo = version;
}
```

Both events return a simple string with the values. For example:

- if the operating system is `Windows 11`, the `WindowsUpdateString` receives the string `11`; 
- if the operating system is `Windows 10 1809`, the `WindowsUpdateString` receives the string `10 (1809)`
- if the CPU is 32 bit, the `WindowsArchitectureString`, receives the string `x86`

#### Windows Architecture Values

- x86_64
- x86
- ARM64
- ARM32

#### Windows Version

| Version    | platformVersion                   |
|------------|-----------------------------------|
| Win7/8/8.1 | 7/8/8.1                           |
| Win10 1507 | 10 (1507)                         |
| Win10 1511 | 10 (1511)                         |
| Win10 1607 | 10 (1607)                         |
| Win10 1703 | 10 (1703)                         |
| Win10 1709 | 10 (1709)                         |
| Win10 1803 | 10 (1803)                         |
| Win10 1809 | 10 (1809)                         |
| Win10 1903 | 10 (1903 or 10 1909)              |
| Win10 1909 | 10 (1903 or 10 1909)              |
| Win10 2004 | 10 (2004 or 20H2 or 21H1 or 21H2) |
| Win10 20H2 | 10 (2004 or 20H2 or 21H1 or 21H2) |
| Win10 21H1 | 10 (2004 or 20H2 or 21H1 or 21H2) |
| Win10 21H2 | 10 (2004 or 20H2 or 21H1 or 21H2) |
| Win11      | 11                                |

## Screenshot

### Windows 11
![image](https://user-images.githubusercontent.com/9497415/224862912-9b85159a-5ae4-416c-a5ff-08ff13723960.png)

### Windows 10
![image](https://user-images.githubusercontent.com/9497415/153378372-4c0d0449-7e70-49ce-9c09-3fd5de2538a7.png)

## iPhone
![image](https://user-images.githubusercontent.com/9497415/153378671-8469e052-a17f-45b2-9d8c-1d9822aa7a19.png)

## Android mobile
![Screenshot_20220210-093352 4335](https://user-images.githubusercontent.com/9497415/153379124-1934e7c9-f9ba-4ed0-8c8c-72831914c377.jpg)

## Amazon Fire tablet
![Screenshot_20220210-093737 4338](https://user-images.githubusercontent.com/9497415/153380151-07f11db7-0ef3-450f-9a9d-a9b34eee0c11.png)

## iPad
![image](https://user-images.githubusercontent.com/9497415/153380116-819ea3bc-1a6f-4d86-9213-24f092fc7372.png)

## iMac
<img width="1893" alt="Screenshot 2022-02-10 at 09 42 16" src="https://user-images.githubusercontent.com/9497415/153380566-bea2447f-e025-40c2-9693-32c4962f9b70.png">

---
    
## PureSourceCode.com

[PureSourceCode.com](https://www.puresourcecode.com/) is my personal blog where I publish posts about technologies and in particular source code and projects in [.NET](https://www.puresourcecode.com/category/dotnet/). 

In the last few months, I created a lot of components for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).

My name is Enrico Rossini and you can contact me via:
- [Personal Twitter](https://twitter.com/erossiniuk)
- [LinkedIn](https://www.linkedin.com/in/rossiniuk)
- [Facebook](https://www.facebook.com/puresourcecode)

## Blazor Components

| Component name | Forum | NuGet | Website | Description |
|---|---|---|---|---|
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) | | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) | | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) | | Add a button to copy text in the clipboard | 
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) | | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) | | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) | | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) | | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) | | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) | | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) | | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) | | This is a new responsive timeline  for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) | | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) | | Guide your users in your Blazor applications |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

## More examples and documentation
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
