
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BufferGeometryLoader : Loader
    {
        #region Constructors
        /// <inheritdoc/>
        public BufferGeometryLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public BufferGeometryLoader(LoadingManager manager) : base(JS.New("THREE.BufferGeometryLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// parse(json: object): InstancedBufferGeometry | BufferGeometry;
        /// </summary>
        public Union<InstancedBufferGeometry, BufferGeometry> Parse(object json)
        {
            return JSRef!.Call<Union<InstancedBufferGeometry, BufferGeometry>>("parse", json);
        }
        #endregion
    }
}
