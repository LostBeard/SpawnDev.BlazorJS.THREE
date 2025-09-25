
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Scene : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Scene(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Scene() : base(JS.New("THREE.Scene")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// background: Color | Texture | CubeTexture | null;
        /// </summary>
        public Union<Color, Texture, CubeTexture> Background { get => JSRef!.Get<Union<Color, Texture, CubeTexture>>("background"); set => JSRef!.Set("background", value); }
        /// <summary>
        /// backgroundBlurriness: number;
        /// </summary>
        public float BackgroundBlurriness { get => JSRef!.Get<float>("backgroundBlurriness"); set => JSRef!.Set("backgroundBlurriness", value); }
        /// <summary>
        /// backgroundIntensity: number;
        /// </summary>
        public float BackgroundIntensity { get => JSRef!.Get<float>("backgroundIntensity"); set => JSRef!.Set("backgroundIntensity", value); }
        /// <summary>
        /// backgroundRotation: Euler;
        /// </summary>
        public Euler BackgroundRotation { get => JSRef!.Get<Euler>("backgroundRotation"); set => JSRef!.Set("backgroundRotation", value); }
        /// <summary>
        /// environment: Texture | null;
        /// </summary>
        public Texture Environment { get => JSRef!.Get<Texture>("environment"); set => JSRef!.Set("environment", value); }
        /// <summary>
        /// environmentIntensity: number;
        /// </summary>
        public float EnvironmentIntensity { get => JSRef!.Get<float>("environmentIntensity"); set => JSRef!.Set("environmentIntensity", value); }
        /// <summary>
        /// environmentRotation: Euler;
        /// </summary>
        public Euler EnvironmentRotation { get => JSRef!.Get<Euler>("environmentRotation"); set => JSRef!.Set("environmentRotation", value); }
        /// <summary>
        /// fog: Fog | FogExp2 | null;
        /// </summary>
        public Union<Fog, FogExp2> Fog { get => JSRef!.Get<Union<Fog, FogExp2>>("fog"); set => JSRef!.Set("fog", value); }
        /// <summary>
        /// readonly isScene: true;
        /// </summary>
        public bool IsScene { get => JSRef!.Get<bool>("isScene"); }
        /// <summary>
        /// overrideMaterial: Material | null;
        /// </summary>
        public Material OverrideMaterial { get => JSRef!.Get<Material>("overrideMaterial"); set => JSRef!.Set("overrideMaterial", value); }
        /// <summary>
        /// type: "Scene";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: JSONMeta): SceneJSON;
        /// </summary>
        public SceneJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<SceneJSON>("toJSON", meta);
        }
        #endregion
    }
}
