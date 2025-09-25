
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Lighting : ChainMap<(Object3D, Camera), LightsNode>
    {
        #region Constructors
        /// <inheritdoc/>
        public Lighting(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Lighting() : base(JS.New("THREE.Lighting")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// getNode(scene: Object3D, camera: Camera): LightsNode;
        /// </summary>
        public LightsNode GetNode(Object3D scene, Camera camera)
        {
            return JSRef!.Call<LightsNode>("getNode", scene, camera);
        }
        /// <summary>
        /// createNode(lights?: Light[]): LightsNode;
        /// </summary>
        public LightsNode CreateNode(Array<Light> lights)
        {
            return JSRef!.Call<LightsNode>("createNode", lights);
        }
        #endregion
    }
}
