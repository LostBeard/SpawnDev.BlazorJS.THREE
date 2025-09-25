
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InterleavedBufferAttribute : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public InterleavedBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(interleavedBuffer: InterleavedBuffer, itemSize: number, offset: number, normalized?: boolean);
        /// </summary>
        public InterleavedBufferAttribute(InterleavedBuffer interleavedBuffer, float itemSize, float offset, bool normalized) : base(JS.New("THREE.InterleavedBufferAttribute", interleavedBuffer, itemSize, offset, normalized)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get array(): TypedArray;
        /// </summary>
        public TypedArray Array { get => JSRef!.Get<TypedArray>("array"); }
        /// <summary>
        /// get count(): number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); }
        /// <summary>
        /// data: InterleavedBuffer;
        /// </summary>
        public InterleavedBuffer Data { get => JSRef!.Get<InterleavedBuffer>("data"); set => JSRef!.Set("data", value); }
        /// <summary>
        /// readonly isInterleavedBufferAttribute: true;
        /// </summary>
        public bool IsInterleavedBufferAttribute { get => JSRef!.Get<bool>("isInterleavedBufferAttribute"); }
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
        /// offset: number;
        /// </summary>
        public float Offset { get => JSRef!.Get<float>("offset"); set => JSRef!.Set("offset", value); }
        #endregion

        #region Methods
        /// <summary>
        /// transformDirection(m: Matrix4): this;
        /// </summary>
        public InterleavedBufferAttribute TransformDirection(Matrix4 m)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("transformDirection", m);
        }
        /// <summary>
        /// toJSON(data?: {}): {
        ///         isInterleavedBufferAttribute: true;
        ///         itemSize: number;
        ///         data: string;
        ///         offset: number;
        ///         normalized: boolean;
        ///     };
        /// </summary>
        public object ToJSON(object data)
        {
            return JSRef!.Call<object>("toJSON", data);
        }
        /// <summary>
        /// setZ(index: number, z: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetZ(float index, float z)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setZ", index, z);
        }
        /// <summary>
        /// setY(index: number, y: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetY(float index, float y)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setY", index, y);
        }
        /// <summary>
        /// setXYZW(index: number, x: number, y: number, z: number, w: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetXYZW(float index, float x, float y, float z, float w)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setXYZW", index, x, y, z, w);
        }
        /// <summary>
        /// setXYZ(index: number, x: number, y: number, z: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetXYZ(float index, float x, float y, float z)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setXYZ", index, x, y, z);
        }
        /// <summary>
        /// setXY(index: number, x: number, y: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetXY(float index, float x, float y)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setXY", index, x, y);
        }
        /// <summary>
        /// setX(index: number, x: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetX(float index, float x)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setX", index, x);
        }
        /// <summary>
        /// setW(index: number, z: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetW(float index, float z)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setW", index, z);
        }
        /// <summary>
        /// setComponent(index: number, component: number, value: number): this;
        /// </summary>
        public InterleavedBufferAttribute SetComponent(float index, float component, float value)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("setComponent", index, component, value);
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
        /// clone(data?: {}): BufferAttribute;
        /// </summary>
        public BufferAttribute Clone(object data)
        {
            return JSRef!.Call<BufferAttribute>("clone", data);
        }
        /// <summary>
        /// applyNormalMatrix(m: Matrix3): this;
        /// </summary>
        public InterleavedBufferAttribute ApplyNormalMatrix(Matrix3 m)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("applyNormalMatrix", m);
        }
        /// <summary>
        /// applyMatrix4(m: Matrix4): this;
        /// </summary>
        public InterleavedBufferAttribute ApplyMatrix4(Matrix4 m)
        {
            return JSRef!.Call<InterleavedBufferAttribute>("applyMatrix4", m);
        }
        #endregion
    }
}
