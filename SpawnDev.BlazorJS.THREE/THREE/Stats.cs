using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Stats.js - JavaScript Performance Monitor
    /// Provides a simple info box that will help you monitor your code performance.
    /// Shows FPS (frames per second), MS (milliseconds to render frame), and MB (megabytes of allocated memory)
    /// </summary>
    public class Stats : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Stats(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new Stats instance
        /// </summary>
        public Stats() : base(JS.New("Stats")) { }
        #endregion

        #region Properties
        /// <summary>
        /// The DOM element that contains the stats display
        /// </summary>
        public HTMLDivElement Dom => JSRef!.Get<HTMLDivElement>("dom");

        /// <summary>
        /// Alias for Dom property - the stats DOM element
        /// </summary>
        public HTMLDivElement DomElement => Dom;
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new custom panel to the stats display
        /// </summary>
        /// <param name="panel">The panel to add</param>
        /// <returns>The panel</returns>
        public StatsPanel AddPanel(StatsPanel panel)
        {
            return JSRef!.Call<StatsPanel>("addPanel", panel);
        }

        /// <summary>
        /// Switches to the specified panel (0 = FPS, 1 = MS, 2 = MB)
        /// </summary>
        /// <param name="id">Panel ID (0, 1, or 2)</param>
        public void ShowPanel(int id)
        {
            JSRef!.CallVoid("showPanel", id);
        }

        /// <summary>
        /// Call at the beginning of a frame
        /// </summary>
        public void Begin()
        {
            JSRef!.CallVoid("begin");
        }

        /// <summary>
        /// Call at the end of a frame
        /// </summary>
        public void End()
        {
            JSRef!.CallVoid("end");
        }

        /// <summary>
        /// Call once per frame to update the stats display
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }

        /// <summary>
        /// Sets the visibility mode
        /// </summary>
        /// <param name="mode">0 = show all, 1 = show FPS only, 2 = show MS only</param>
        public void SetMode(int mode)
        {
            JSRef!.CallVoid("setMode", mode);
        }
        #endregion
    }

    /// <summary>
    /// Custom panel for Stats.js
    /// </summary>
    public class StatsPanel : JSObject
    {
        /// <inheritdoc/>
        public StatsPanel(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new StatsPanel
        /// </summary>
        /// <param name="name">Name of the panel</param>
        /// <param name="fg">Foreground color (CSS color string)</param>
        /// <param name="bg">Background color (CSS color string)</param>
        public StatsPanel(string name, string fg, string bg) 
            : base(JS.Call<IJSInProcessObjectReference>("Stats.Panel", name, fg, bg)) { }

        /// <summary>
        /// Updates the panel with a new value
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="maxValue">Maximum value for scaling</param>
        public void Update(float value, float maxValue)
        {
            JSRef!.CallVoid("update", value, maxValue);
        }
    }
}
