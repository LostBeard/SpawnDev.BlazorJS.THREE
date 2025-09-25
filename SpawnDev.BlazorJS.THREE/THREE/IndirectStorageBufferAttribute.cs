
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class IndirectStorageBufferAttribute : StorageBufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public IndirectStorageBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray, itemSize: number);
        /// </summary>
        public IndirectStorageBufferAttribute(TypedArray array, float itemSize) : base(JS.New("THREE.IndirectStorageBufferAttribute", array, itemSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isIndirectStorageBufferAttribute: true;
        /// </summary>
        public bool IsIndirectStorageBufferAttribute { get => JSRef!.Get<bool>("isIndirectStorageBufferAttribute"); }
        #endregion

        #region Methods

        #endregion
    }
}
