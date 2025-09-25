
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstancedInterleavedBuffer : InterleavedBuffer
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedInterleavedBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray, stride: number, meshPerAttribute?: number);
        /// </summary>
        public InstancedInterleavedBuffer(TypedArray array, float stride, float meshPerAttribute) : base(JS.New("THREE.InstancedInterleavedBuffer", array, stride, meshPerAttribute)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// meshPerAttribute: number;
        /// </summary>
        public float MeshPerAttribute { get => JSRef!.Get<float>("meshPerAttribute"); set => JSRef!.Set("meshPerAttribute", value); }
        #endregion

        #region Methods

        #endregion
    }
}
