
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class UniformsGroup : UniformBuffer
    {
        #region Constructors
        /// <inheritdoc/>
        public UniformsGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name?: string);
        /// </summary>
        public UniformsGroup(string name) : base(JS.New("THREE.UniformsGroup", name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get buffer(): Float32Array;
        /// </summary>
        public Float32Array Buffer { get => JSRef!.Get<Float32Array>("buffer"); }
        /// <summary>
        /// get byteLength(): number;
        /// </summary>
        public float ByteLength { get => JSRef!.Get<float>("byteLength"); }
        /// <summary>
        /// readonly isUniformsGroup: true;
        /// </summary>
        public bool IsUniformsGroup { get => JSRef!.Get<bool>("isUniformsGroup"); }
        /// <summary>
        /// uniforms: NodeUniformGPU[];
        /// </summary>
        public Array<NodeUniformGPU> Uniforms { get => JSRef!.Get<Array<NodeUniformGPU>>("uniforms"); set => JSRef!.Set("uniforms", value); }
        /// <summary>
        /// get values(): number[];
        /// </summary>
        public Array<float> Values { get => JSRef!.Get<Array<float>>("values"); }
        #endregion

        #region Methods
        /// <summary>
        /// updateVector4(uniform: Vector4NodeUniform): boolean;
        /// </summary>
        public bool UpdateVector4(Vector4NodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateVector4", uniform);
        }
        /// <summary>
        /// updateVector3(uniform: Vector3NodeUniform): boolean;
        /// </summary>
        public bool UpdateVector3(Vector3NodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateVector3", uniform);
        }
        /// <summary>
        /// updateVector2(uniform: Vector2NodeUniform): boolean;
        /// </summary>
        public bool UpdateVector2(Vector2NodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateVector2", uniform);
        }
        /// <summary>
        /// updateNumber(uniform: NumberNodeUniform): boolean;
        /// </summary>
        public bool UpdateNumber(NumberNodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateNumber", uniform);
        }
        /// <summary>
        /// updateMatrix4(uniform: Matrix4NodeUniform): boolean;
        /// </summary>
        public bool UpdateMatrix4(Matrix4NodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateMatrix4", uniform);
        }
        /// <summary>
        /// updateMatrix3(uniform: Matrix3NodeUniform): boolean;
        /// </summary>
        public bool UpdateMatrix3(Matrix3NodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateMatrix3", uniform);
        }
        /// <summary>
        /// updateColor(uniform: ColorNodeUniform): boolean;
        /// </summary>
        public bool UpdateColor(ColorNodeUniform uniform)
        {
            return JSRef!.Call<bool>("updateColor", uniform);
        }
        /// <summary>
        /// updateByType(uniform: NodeUniformGPU): boolean | undefined;
        /// </summary>
        public bool UpdateByType(NodeUniformGPU uniform)
        {
            return JSRef!.Call<bool>("updateByType", uniform);
        }
        /// <summary>
        /// update(): boolean;
        /// </summary>
        public bool Update()
        {
            return JSRef!.Call<bool>("update");
        }
        /// <summary>
        /// removeUniform(uniform: NodeUniformGPU): this;
        /// </summary>
        public UniformsGroup RemoveUniform(NodeUniformGPU uniform)
        {
            return JSRef!.Call<UniformsGroup>("removeUniform", uniform);
        }
        /// <summary>
        /// addUniform(uniform: NodeUniformGPU): this;
        /// </summary>
        public UniformsGroup AddUniform(NodeUniformGPU uniform)
        {
            return JSRef!.Call<UniformsGroup>("addUniform", uniform);
        }
        #endregion
    }
}
