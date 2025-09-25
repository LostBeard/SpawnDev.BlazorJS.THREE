
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageBufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray | number, itemSize: number);
        /// </summary>
        public StorageBufferAttribute(Union<TypedArray, float> array, float itemSize) : base(JS.New("THREE.StorageBufferAttribute", array, itemSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isStorageBufferAttribute: true;
        /// </summary>
        public bool IsStorageBufferAttribute { get => JSRef!.Get<bool>("isStorageBufferAttribute"); }
        #endregion

        #region Methods

        #endregion
    }
}
