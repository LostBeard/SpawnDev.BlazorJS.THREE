
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BufferNode<TValue> : UniformNode<TValue>
    {
        #region Constructors
        /// <inheritdoc/>
        public BufferNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(value: TValue, bufferType: string, bufferCount?: number);
        /// </summary>
        public BufferNode(TValue value, string bufferType, float bufferCount) : base(JS.New("THREE.BufferNode", value, bufferType, bufferCount)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bufferCount: number;
        /// </summary>
        public float BufferCount { get => JSRef!.Get<float>("bufferCount"); set => JSRef!.Set("bufferCount", value); }
        /// <summary>
        /// bufferType: string;
        /// </summary>
        public string BufferType { get => JSRef!.Get<string>("bufferType"); set => JSRef!.Set("bufferType", value); }
        /// <summary>
        /// isBufferNode: true;
        /// </summary>
        public bool IsBufferNode { get => JSRef!.Get<bool>("isBufferNode"); set => JSRef!.Set("isBufferNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
