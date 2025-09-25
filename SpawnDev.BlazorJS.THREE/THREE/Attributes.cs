
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Attributes : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Attributes(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(backend: Backend);
        /// </summary>
        public Attributes(Backend backend) : base(JS.New("THREE.Attributes", backend)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(attribute: BufferAttribute | InterleavedBufferAttribute, type: AttributeType): void;
        /// </summary>
        public void Update(Union<BufferAttribute, InterleavedBufferAttribute> attribute, AttributeType type)
        {
            JSRef!.CallVoid("update", attribute, type);
        }
        /// <summary>
        /// delete(attribute: BufferAttribute | InterleavedBufferAttribute): Data;
        /// </summary>
        public Data Delete(Union<BufferAttribute, InterleavedBufferAttribute> attribute)
        {
            return JSRef!.Call<Data>("delete", attribute);
        }
        #endregion
    }
}
