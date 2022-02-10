using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.BrowserDetect
{
    public class BrowserInfo
    {
        public string BrowserMajor { get; set; }
        public string BrowserName { get; set; }
        public string BrowserVersion { get; set; }
        public string CPUArchitect { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceType { get; set; }
        public string DeviceVendor { get; set; }
        public string EngineName { get; set; }
        public string EngineVersion { get; set; }
        public string GPURenderer { get; set; }
        public string GPUVendor { get; set; }
        public string IP { get; set; }
        public bool? IsAndroid { get; set; }
        public bool? IsDesktop { get; set; }
        public bool? IsIPad { get; set; }
        public bool? IsIPadPro { get; set; }
        public bool? IsIPhone { get; set; }
        public bool? IsMobile { get; set; }
        public bool? IsTablet { get; set; }
        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public string ScreenResolution { get; set; }
        public string TimeZone { get; set; }
        public string UserAgent { get; set; }
    }
}
