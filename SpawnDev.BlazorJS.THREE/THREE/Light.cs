
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Light<TShadowSupport> : Light
    {
        /// <inheritdoc/>
        public Light(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class Light : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Light(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation, intensity?: number);
        /// </summary>
        public Light(ColorRepresentation color, float intensity) : base(JS.New("THREE.Light", color, intensity)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// color: Color;
        /// </summary>
        public Color Color { get => JSRef!.Get<Color>("color"); set => JSRef!.Set("color", value); }
        /// <summary>
        /// intensity: number;
        /// </summary>
        public float Intensity { get => JSRef!.Get<float>("intensity"); set => JSRef!.Set("intensity", value); }
        /// <summary>
        /// readonly isLight: true;
        /// </summary>
        public bool IsLight { get => JSRef!.Get<bool>("isLight"); }
        /// <summary>
        /// shadow: TShadowSupport;
        /// </summary>
        public TShadowSupport Shadow { get => JSRef!.Get<TShadowSupport>("shadow"); set => JSRef!.Set("shadow", value); }
        /// <summary>
        /// override readonly type: string | "Light";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: JSONMeta): LightJSON;
        /// </summary>
        public LightJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<LightJSON>("toJSON", meta);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// copy(source: this, recursive?: boolean): this;
        /// </summary>
        public Light Copy(Light source, bool recursive)
        {
            return JSRef!.Call<Light>("copy", source, recursive);
        }
        #endregion
    }
}
