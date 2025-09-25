
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Buffer : Binding
    {
        #region Constructors
        /// <inheritdoc/>
        public Buffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name?: string, buffer?: Float32Array | null);
        /// </summary>
        public Buffer(string name, Float32Array buffer) : base(JS.New("THREE.Buffer", name, buffer)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get buffer(): Float32Array | null;
        /// </summary>
        public Float32Array BufferV { get => JSRef!.Get<Float32Array>("buffer"); }
        /// <summary>
        /// get byteLength(): number;
        /// </summary>
        public float ByteLength { get => JSRef!.Get<float>("byteLength"); }
        /// <summary>
        /// bytesPerElement: number;
        /// </summary>
        public float BytesPerElement { get => JSRef!.Get<float>("bytesPerElement"); set => JSRef!.Set("bytesPerElement", value); }
        /// <summary>
        /// readonly isBuffer: true;
        /// </summary>
        public bool IsBuffer { get => JSRef!.Get<bool>("isBuffer"); }
        #endregion

        #region Methods
        /// <summary>
        /// update(): boolean;
        /// </summary>
        public bool Update()
        {
            return JSRef!.Call<bool>("update");
        }
        #endregion
    }
}
