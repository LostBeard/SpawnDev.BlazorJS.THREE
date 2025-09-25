
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageInstancedBufferAttribute : InstancedBufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageInstancedBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray | number, itemSize: number);
        /// </summary>
        public StorageInstancedBufferAttribute(Union<TypedArray, float> array, float itemSize) : base(JS.New("THREE.StorageInstancedBufferAttribute", array, itemSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isStorageInstancedBufferAttribute: true;
        /// </summary>
        public bool IsStorageInstancedBufferAttribute { get => JSRef!.Get<bool>("isStorageInstancedBufferAttribute"); }
        #endregion

        #region Methods

        #endregion
    }
}
