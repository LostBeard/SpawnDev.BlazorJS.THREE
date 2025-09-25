
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Layers : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Layers(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Layers() : base(JS.New("THREE.Layers")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// mask: number;
        /// </summary>
        public float Mask { get => JSRef!.Get<float>("mask"); set => JSRef!.Set("mask", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toggle(layer: number): void;
        /// </summary>
        public void Toggle(float layer)
        {
            JSRef!.CallVoid("toggle", layer);
        }
        /// <summary>
        /// test(layers: Layers): boolean;
        /// </summary>
        public bool Test(Layers layers)
        {
            return JSRef!.Call<bool>("test", layers);
        }
        /// <summary>
        /// set(layer: number): void;
        /// </summary>
        public void Set(float layer)
        {
            JSRef!.CallVoid("set", layer);
        }
        /// <summary>
        /// isEnabled(layer: number): boolean;
        /// </summary>
        public bool IsEnabled(float layer)
        {
            return JSRef!.Call<bool>("isEnabled", layer);
        }
        /// <summary>
        /// enableAll(): void;
        /// </summary>
        public void EnableAll()
        {
            JSRef!.CallVoid("enableAll");
        }
        /// <summary>
        /// enable(layer: number): void;
        /// </summary>
        public void Enable(float layer)
        {
            JSRef!.CallVoid("enable", layer);
        }
        /// <summary>
        /// disableAll(): void;
        /// </summary>
        public void DisableAll()
        {
            JSRef!.CallVoid("disableAll");
        }
        /// <summary>
        /// disable(layer: number): void;
        /// </summary>
        public void Disable(float layer)
        {
            JSRef!.CallVoid("disable", layer);
        }
        #endregion
    }
}
