
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLBindingStates : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLBindingStates(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext, attributes: WebGLAttributes);
        /// </summary>
        public WebGLBindingStates(WebGLRenderingContext gl, WebGLAttributes attributes) : base(JS.New("THREE.WebGLBindingStates", gl, attributes)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// setup(
        ///         object: Object3D,
        ///         material: Material,
        ///         program: WebGLProgram,
        ///         geometry: BufferGeometry,
        ///         index: BufferAttribute,
        ///     ): void;
        /// </summary>
        public void Setup(Object3D obj, Material material, WebGLProgram program, BufferGeometry geometry, BufferAttribute index)
        {
            JSRef!.CallVoid("setup", obj, material, program, geometry, index);
        }
        /// <summary>
        /// resetDefaultState(): void;
        /// </summary>
        public void ResetDefaultState()
        {
            JSRef!.CallVoid("resetDefaultState");
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        /// <summary>
        /// releaseStatesOfProgram(): void;
        /// </summary>
        public void ReleaseStatesOfProgram()
        {
            JSRef!.CallVoid("releaseStatesOfProgram");
        }
        /// <summary>
        /// releaseStatesOfGeometry(): void;
        /// </summary>
        public void ReleaseStatesOfGeometry()
        {
            JSRef!.CallVoid("releaseStatesOfGeometry");
        }
        /// <summary>
        /// initAttributes(): void;
        /// </summary>
        public void InitAttributes()
        {
            JSRef!.CallVoid("initAttributes");
        }
        /// <summary>
        /// enableAttribute(attribute: number): void;
        /// </summary>
        public void EnableAttribute(float attribute)
        {
            JSRef!.CallVoid("enableAttribute", attribute);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// disableUnusedAttributes(): void;
        /// </summary>
        public void DisableUnusedAttributes()
        {
            JSRef!.CallVoid("disableUnusedAttributes");
        }
        #endregion
    }
}
