
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLGeometries : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLGeometries(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(gl: WebGLRenderingContext, attributes: WebGLAttributes, info: WebGLInfo);
        /// </summary>
        public WebGLGeometries(WebGLRenderingContext gl, WebGLAttributes attributes, WebGLInfo info) : base(JS.New("THREE.WebGLGeometries", gl, attributes, info)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// update(geometry: BufferGeometry): void;
        /// </summary>
        public void Update(BufferGeometry geometry)
        {
            JSRef!.CallVoid("update", geometry);
        }
        /// <summary>
        /// getWireframeAttribute(geometry: BufferGeometry): BufferAttribute;
        /// </summary>
        public BufferAttribute GetWireframeAttribute(BufferGeometry geometry)
        {
            return JSRef!.Call<BufferAttribute>("getWireframeAttribute", geometry);
        }
        /// <summary>
        /// get(object: Object3D, geometry: BufferGeometry): BufferGeometry;
        /// </summary>
        public BufferGeometry Get(Object3D obj, BufferGeometry geometry)
        {
            return JSRef!.Call<BufferGeometry>("get", obj, geometry);
        }
        #endregion
    }
}
