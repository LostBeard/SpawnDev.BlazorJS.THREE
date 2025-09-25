
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// https://threejs.org/docs/?q=BufferAttribute#api/en/core/BufferAttribute
    /// </summary>
    public class BufferAttribute : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(array: TypedArray, itemSize: number, normalized?: boolean);
        /// </summary>
        public BufferAttribute(TypedArray array, float itemSize, bool? normalized = null) : base(normalized == null ? JS.New("THREE.BufferAttribute", array, itemSize) : JS.New("THREE.BufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// array: TypedArray;
        /// </summary>
        public TypedArray Array { get => JSRef!.Get<TypedArray>("array"); set => JSRef!.Set("array", value); }
        /// <summary>
        /// readonly count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); }
        /// <summary>
        /// gpuType: AttributeGPUType;
        /// </summary>
        public AttributeGPUType GpuType { get => JSRef!.Get<AttributeGPUType>("gpuType"); set => JSRef!.Set("gpuType", value); }
        /// <summary>
        /// readonly id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// readonly isBufferAttribute: true;
        /// </summary>
        public bool IsBufferAttribute { get => JSRef!.Get<bool>("isBufferAttribute"); }
        /// <summary>
        /// itemSize: number;
        /// </summary>
        public float ItemSize { get => JSRef!.Get<float>("itemSize"); set => JSRef!.Set("itemSize", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// normalized: boolean;
        /// </summary>
        public bool Normalized { get => JSRef!.Get<bool>("normalized"); set => JSRef!.Set("normalized", value); }
        /// <summary>
        /// onUploadCallback: () => void;
        /// </summary>
        public Callback OnUploadCallback { get => JSRef!.Get<Callback>("onUploadCallback"); set => JSRef!.Set("onUploadCallback", value); }
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
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods
        /// <summary>
        /// transformDirection(m: Matrix4): this;
        /// </summary>
        public BufferAttribute TransformDirection(Matrix4 m)
        {
            return JSRef!.Call<BufferAttribute>("transformDirection", m);
        }
        /// <summary>
        /// toJSON(): BufferAttributeJSON;
        /// </summary>
        public BufferAttributeJSON ToJSON()
        {
            return JSRef!.Call<BufferAttributeJSON>("toJSON");
        }
        /// <summary>
        /// setZ(index: number, z: number): this;
        /// </summary>
        public BufferAttribute SetZ(float index, float z)
        {
            return JSRef!.Call<BufferAttribute>("setZ", index, z);
        }
        /// <summary>
        /// setY(index: number, y: number): this;
        /// </summary>
        public BufferAttribute SetY(float index, float y)
        {
            return JSRef!.Call<BufferAttribute>("setY", index, y);
        }
        /// <summary>
        /// setXYZW(index: number, x: number, y: number, z: number, w: number): this;
        /// </summary>
        public BufferAttribute SetXYZW(float index, float x, float y, float z, float w)
        {
            return JSRef!.Call<BufferAttribute>("setXYZW", index, x, y, z, w);
        }
        /// <summary>
        /// setXYZ(index: number, x: number, y: number, z: number): this;
        /// </summary>
        public BufferAttribute SetXYZ(float index, float x, float y, float z)
        {
            return JSRef!.Call<BufferAttribute>("setXYZ", index, x, y, z);
        }
        /// <summary>
        /// setXY(index: number, x: number, y: number): this;
        /// </summary>
        public BufferAttribute SetXY(float index, float x, float y)
        {
            return JSRef!.Call<BufferAttribute>("setXY", index, x, y);
        }
        /// <summary>
        /// setX(index: number, x: number): this;
        /// </summary>
        public BufferAttribute SetX(float index, float x)
        {
            return JSRef!.Call<BufferAttribute>("setX", index, x);
        }
        /// <summary>
        /// setW(index: number, z: number): this;
        /// </summary>
        public BufferAttribute SetW(float index, float z)
        {
            return JSRef!.Call<BufferAttribute>("setW", index, z);
        }
        /// <summary>
        /// setUsage(usage: Usage): this;
        /// </summary>
        public BufferAttribute SetUsage(Usage usage)
        {
            return JSRef!.Call<BufferAttribute>("setUsage", usage);
        }
        /// <summary>
        /// setComponent(index: number, component: number, value: number): void;
        /// </summary>
        public void SetComponent(float index, float component, float value)
        {
            JSRef!.CallVoid("setComponent", index, component, value);
        }
        /// <summary>
        /// set(value: ArrayLike<number> | ArrayBufferView, offset?: number): this;
        /// </summary>
        public BufferAttribute Set(Union<ArrayLikeFloat, ArrayBufferView> value, float offset)
        {
            return JSRef!.Call<BufferAttribute>("set", value, offset);
        }
        /// <summary>
        /// onUpload(callback: () => void): this;
        /// </summary>
        public BufferAttribute OnUpload(Callback callback)
        {
            return JSRef!.Call<BufferAttribute>("onUpload", callback);
        }
        /// <summary>
        /// getZ(index: number): number;
        /// </summary>
        public float GetZ(float index)
        {
            return JSRef!.Call<float>("getZ", index);
        }
        /// <summary>
        /// getY(index: number): number;
        /// </summary>
        public float GetY(float index)
        {
            return JSRef!.Call<float>("getY", index);
        }
        /// <summary>
        /// getX(index: number): number;
        /// </summary>
        public float GetX(float index)
        {
            return JSRef!.Call<float>("getX", index);
        }
        /// <summary>
        /// getW(index: number): number;
        /// </summary>
        public float GetW(float index)
        {
            return JSRef!.Call<float>("getW", index);
        }
        /// <summary>
        /// getComponent(index: number, component: number): number;
        /// </summary>
        public float GetComponent(float index, float component)
        {
            return JSRef!.Call<float>("getComponent", index, component);
        }
        /// <summary>
        /// copyAt(index1: number, attribute: BufferAttribute, index2: number): this;
        /// </summary>
        public BufferAttribute CopyAt(float index1, BufferAttribute attribute, float index2)
        {
            return JSRef!.Call<BufferAttribute>("copyAt", index1, attribute, index2);
        }
        /// <summary>
        /// copyArray(array: ArrayLike<number>): this;
        /// </summary>
        public BufferAttribute CopyArray(ArrayLikeFloat array)
        {
            return JSRef!.Call<BufferAttribute>("copyArray", array);
        }
        /// <summary>
        /// copy(source: BufferAttribute): this;
        /// </summary>
        public BufferAttribute Copy(BufferAttribute source)
        {
            return JSRef!.Call<BufferAttribute>("copy", source);
        }
        /// <summary>
        /// clone(): BufferAttribute;
        /// </summary>
        public BufferAttribute Clone()
        {
            return JSRef!.Call<BufferAttribute>("clone");
        }
        /// <summary>
        /// clearUpdateRanges(): void;
        /// </summary>
        public void ClearUpdateRanges()
        {
            JSRef!.CallVoid("clearUpdateRanges");
        }
        /// <summary>
        /// applyNormalMatrix(m: Matrix3): this;
        /// </summary>
        public BufferAttribute ApplyNormalMatrix(Matrix3 m)
        {
            return JSRef!.Call<BufferAttribute>("applyNormalMatrix", m);
        }
        /// <summary>
        /// applyMatrix4(m: Matrix4): this;
        /// </summary>
        public BufferAttribute ApplyMatrix4(Matrix4 m)
        {
            return JSRef!.Call<BufferAttribute>("applyMatrix4", m);
        }
        /// <summary>
        /// applyMatrix3(m: Matrix3): this;
        /// </summary>
        public BufferAttribute ApplyMatrix3(Matrix3 m)
        {
            return JSRef!.Call<BufferAttribute>("applyMatrix3", m);
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
