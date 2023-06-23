using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.BrowserDetect
{
    /// <summary>
    /// Class BrowserInfo.
    /// </summary>
    public class BrowserInfo
    {
        /// <summary>
        /// Gets or sets the browser major.
        /// </summary>
        /// <value>The browser major.</value>
        public string? BrowserMajor { get; set; }
        /// <summary>
        /// Gets or sets the name of the browser.
        /// </summary>
        /// <value>The name of the browser.</value>
        public string? BrowserName { get; set; }
        /// <summary>
        /// Gets or sets the browser version.
        /// </summary>
        /// <value>The browser version.</value>
        public string? BrowserVersion { get; set; }
        /// <summary>
        /// Gets or sets the cpu architect.
        /// </summary>
        /// <value>The cpu architect.</value>
        public string? CPUArchitect { get; set; }
        /// <summary>
        /// Gets or sets the device model.
        /// </summary>
        /// <value>The device model.</value>
        public string? DeviceModel { get; set; }
        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        /// <value>The type of the device.</value>
        public string? DeviceType { get; set; }
        /// <summary>
        /// Gets or sets the device vendor.
        /// </summary>
        /// <value>The device vendor.</value>
        public string? DeviceVendor { get; set; }
        /// <summary>
        /// Gets or sets the name of the engine.
        /// </summary>
        /// <value>The name of the engine.</value>
        public string? EngineName { get; set; }
        /// <summary>
        /// Gets or sets the engine version.
        /// </summary>
        /// <value>The engine version.</value>
        public string? EngineVersion { get; set; }
        /// <summary>
        /// Gets or sets the gpu renderer.
        /// </summary>
        /// <value>The gpu renderer.</value>
        public string? GPURenderer { get; set; }
        /// <summary>
        /// Gets or sets the gpu vendor.
        /// </summary>
        /// <value>The gpu vendor.</value>
        public string? GPUVendor { get; set; }
        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        /// <value>The ip.</value>
        public string? IP { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is android.
        /// </summary>
        /// <value><c>null</c> if [is android] contains no value, <c>true</c> if [is android]; otherwise, <c>false</c>.</value>
        public bool? IsAndroid { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is desktop.
        /// </summary>
        /// <value><c>null</c> if [is desktop] contains no value, <c>true</c> if [is desktop]; otherwise, <c>false</c>.</value>
        public bool? IsDesktop { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is i pad.
        /// </summary>
        /// <value><c>null</c> if [is i pad] contains no value, <c>true</c> if [is i pad]; otherwise, <c>false</c>.</value>
        public bool? IsIPad { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is i pad pro.
        /// </summary>
        /// <value><c>null</c> if [is i pad pro] contains no value, <c>true</c> if [is i pad pro]; otherwise, <c>false</c>.</value>
        public bool? IsIPadPro { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is i phone.
        /// </summary>
        /// <value><c>null</c> if [is i phone] contains no value, <c>true</c> if [is i phone]; otherwise, <c>false</c>.</value>
        public bool? IsIPhone { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is mobile.
        /// </summary>
        /// <value><c>null</c> if [is mobile] contains no value, <c>true</c> if [is mobile]; otherwise, <c>false</c>.</value>
        public bool? IsMobile { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is tablet.
        /// </summary>
        /// <value><c>null</c> if [is tablet] contains no value, <c>true</c> if [is tablet]; otherwise, <c>false</c>.</value>
        public bool? IsTablet { get; set; }
        /// <summary>
        /// Gets or sets the name of the os.
        /// </summary>
        /// <value>The name of the os.</value>
        public string? OSName { get; set; }
        /// <summary>
        /// Gets or sets the os version.
        /// </summary>
        /// <value>The os version.</value>
        public string? OSVersion { get; set; }
        /// <summary>
        /// Gets or sets the screen resolution.
        /// </summary>
        /// <value>The screen resolution.</value>
        public string? ScreenResolution { get; set; }
        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        public string? TimeZone { get; set; }
        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        public string? UserAgent { get; set; }
    }
}
