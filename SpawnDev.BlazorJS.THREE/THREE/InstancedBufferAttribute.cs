
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstancedBufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray, itemSize: number, normalized?: boolean, meshPerAttribute?: number);
        /// </summary>
        public InstancedBufferAttribute(TypedArray array, float itemSize, bool normalized, float meshPerAttribute) : base(JS.New("THREE.InstancedBufferAttribute", array, itemSize, normalized, meshPerAttribute)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isInstancedBufferAttribute: true;
        /// </summary>
        public bool IsInstancedBufferAttribute { get => JSRef!.Get<bool>("isInstancedBufferAttribute"); }
        /// <summary>
        /// meshPerAttribute: number;
        /// </summary>
        public float MeshPerAttribute { get => JSRef!.Get<float>("meshPerAttribute"); set => JSRef!.Set("meshPerAttribute", value); }
        #endregion

        #region Methods

        #endregion
    }
}
