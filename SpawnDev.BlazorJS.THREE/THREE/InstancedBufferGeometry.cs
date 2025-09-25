
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstancedBufferGeometry : BufferGeometry
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedBufferGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public InstancedBufferGeometry() : base(JS.New("THREE.InstancedBufferGeometry")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// instanceCount: number;
        /// </summary>
        public float InstanceCount { get => JSRef!.Get<float>("instanceCount"); set => JSRef!.Set("instanceCount", value); }
        /// <summary>
        /// readonly isInstancedBufferGeometry: true;
        /// </summary>
        public bool IsInstancedBufferGeometry { get => JSRef!.Get<bool>("isInstancedBufferGeometry"); }
        /// <summary>
        /// type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods
        /// <summary>
        /// copy(source: InstancedBufferGeometry): this;
        /// </summary>
        public InstancedBufferGeometry Copy(InstancedBufferGeometry source)
        {
            return JSRef!.Call<InstancedBufferGeometry>("copy", source);
        }
        #endregion
    }
}
