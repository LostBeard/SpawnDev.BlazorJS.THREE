
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InterleavedBuffer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public InterleavedBuffer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray, stride: number);
        /// </summary>
        public InterleavedBuffer(TypedArray array, float stride) : base(JS.New("THREE.InterleavedBuffer", array, stride)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// array: TypedArray;
        /// </summary>
        public TypedArray Array { get => JSRef!.Get<TypedArray>("array"); set => JSRef!.Set("array", value); }
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// readonly isInterleavedBuffer: true;
        /// </summary>
        public bool IsInterleavedBuffer { get => JSRef!.Get<bool>("isInterleavedBuffer"); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// onUploadCallback: () => void;
        /// </summary>
        public Callback OnUploadCallback { get => JSRef!.Get<Callback>("onUploadCallback"); set => JSRef!.Set("onUploadCallback", value); }
        /// <summary>
        /// stride: number;
        /// </summary>
        public float Stride { get => JSRef!.Get<float>("stride"); set => JSRef!.Set("stride", value); }
        /// <summary>
        /// updateRanges: Array<{
                ///         /**
                ///          * Position at which to start update.
                ///          */
                ///         start: number;
                ///         /**
                ///          * The number of components to update.
                ///          */
                ///         count: number;
                ///     }>;
        /// </summary>
        public Array<object> UpdateRanges { get => JSRef!.Get<Array<object>>("updateRanges"); set => JSRef!.Set("updateRanges", value); }
        /// <summary>
        /// usage: Usage;
        /// </summary>
        public Usage Usage { get => JSRef!.Get<Usage>("usage"); set => JSRef!.Set("usage", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(data: {}): {
        ///         uuid: string;
        ///         buffer: string;
        ///         type: string;
        ///         stride: number;
        ///     };
        /// </summary>
        public object ToJSON(object data)
        {
            return JSRef!.Call<object>("toJSON", data);
        }
        /// <summary>
        /// setUsage(value: Usage): this;
        /// </summary>
        public InterleavedBuffer SetUsage(Usage value)
        {
            return JSRef!.Call<InterleavedBuffer>("setUsage", value);
        }
        /// <summary>
        /// set(value: ArrayLike<number>, offset: number): this;
        /// </summary>
        public InterleavedBuffer Set(ArrayLikeFloat value, float offset)
        {
            return JSRef!.Call<InterleavedBuffer>("set", value, offset);
        }
        /// <summary>
        /// onUpload(callback: () => void): this;
        /// </summary>
        public InterleavedBuffer OnUpload(Callback callback)
        {
            return JSRef!.Call<InterleavedBuffer>("onUpload", callback);
        }
        /// <summary>
        /// copyAt(index1: number, attribute: InterleavedBufferAttribute, index2: number): this;
        /// </summary>
        public InterleavedBuffer CopyAt(float index1, InterleavedBufferAttribute attribute, float index2)
        {
            return JSRef!.Call<InterleavedBuffer>("copyAt", index1, attribute, index2);
        }
        /// <summary>
        /// copy(source: InterleavedBuffer): this;
        /// </summary>
        public InterleavedBuffer Copy(InterleavedBuffer source)
        {
            return JSRef!.Call<InterleavedBuffer>("copy", source);
        }
        /// <summary>
        /// clone(data: {}): InterleavedBuffer;
        /// </summary>
        public InterleavedBuffer Clone(object data)
        {
            return JSRef!.Call<InterleavedBuffer>("clone", data);
        }
        /// <summary>
        /// clearUpdateRanges(): void;
        /// </summary>
        public void ClearUpdateRanges()
        {
            JSRef!.CallVoid("clearUpdateRanges");
        }
        /// <summary>
        /// addUpdateRange(start: number, count: number): void;
        /// </summary>
        public void AddUpdateRange(float start, float count)
        {
            JSRef!.CallVoid("addUpdateRange", start, count);
        }
        #endregion
    }
}
