
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DirectionalLight : Light<DirectionalLightShadow>
    {
        #region Constructors
        /// <inheritdoc/>
        public DirectionalLight(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(color?: ColorRepresentation, intensity?: number);
        /// </summary>
        public DirectionalLight(ColorRepresentation color, float intensity) : base(JS.New("THREE.DirectionalLight", color, intensity)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override castShadow: boolean;
        /// </summary>
        public bool CastShadow { get => JSRef!.Get<bool>("castShadow"); set => JSRef!.Set("castShadow", value); }
        /// <summary>
        /// readonly isDirectionalLight: true;
        /// </summary>
        public bool IsDirectionalLight { get => JSRef!.Get<bool>("isDirectionalLight"); }
        /// <summary>
        /// override readonly position: Vector3;
        /// </summary>
        public Vector3 Position { get => JSRef!.Get<Vector3>("position"); }
        /// <summary>
        /// shadow: DirectionalLightShadow;
        /// </summary>
        public DirectionalLightShadow Shadow { get => JSRef!.Get<DirectionalLightShadow>("shadow"); set => JSRef!.Set("shadow", value); }
        /// <summary>
        /// target: Object3D;
        /// </summary>
        public Object3D Target { get => JSRef!.Get<Object3D>("target"); set => JSRef!.Set("target", value); }
        /// <summary>
        /// override readonly type: string | "DirectionalLight";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
