
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLCapabilities : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLCapabilities(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(gl: WebGLRenderingContext, extensions: any, parameters: WebGLCapabilitiesParameters);
        /// </summary>
        public WebGLCapabilities(WebGLRenderingContext gl, object extensions, WebGLCapabilitiesParameters parameters) : base(JS.New("THREE.WebGLCapabilities", gl, extensions, parameters)) { }

        #endregion

        #region Properties
        /// <summary>
        /// readonly isWebGL2: boolean;
        /// </summary>
        public bool IsWebGL2 { get => JSRef!.Get<bool>("isWebGL2"); }
        /// <summary>
        /// logarithmicDepthBuffer: boolean;
        /// </summary>
        public bool LogarithmicDepthBuffer { get => JSRef!.Get<bool>("logarithmicDepthBuffer"); set => JSRef!.Set("logarithmicDepthBuffer", value); }
        /// <summary>
        /// maxAttributes: number;
        /// </summary>
        public float MaxAttributes { get => JSRef!.Get<float>("maxAttributes"); set => JSRef!.Set("maxAttributes", value); }
        /// <summary>
        /// maxCubemapSize: number;
        /// </summary>
        public float MaxCubemapSize { get => JSRef!.Get<float>("maxCubemapSize"); set => JSRef!.Set("maxCubemapSize", value); }
        /// <summary>
        /// maxFragmentUniforms: number;
        /// </summary>
        public float MaxFragmentUniforms { get => JSRef!.Get<float>("maxFragmentUniforms"); set => JSRef!.Set("maxFragmentUniforms", value); }
        /// <summary>
        /// maxSamples: number;
        /// </summary>
        public float MaxSamples { get => JSRef!.Get<float>("maxSamples"); set => JSRef!.Set("maxSamples", value); }
        /// <summary>
        /// maxTextures: number;
        /// </summary>
        public float MaxTextures { get => JSRef!.Get<float>("maxTextures"); set => JSRef!.Set("maxTextures", value); }
        /// <summary>
        /// maxTextureSize: number;
        /// </summary>
        public float MaxTextureSize { get => JSRef!.Get<float>("maxTextureSize"); set => JSRef!.Set("maxTextureSize", value); }
        /// <summary>
        /// maxVaryings: number;
        /// </summary>
        public float MaxVaryings { get => JSRef!.Get<float>("maxVaryings"); set => JSRef!.Set("maxVaryings", value); }
        /// <summary>
        /// maxVertexTextures: number;
        /// </summary>
        public float MaxVertexTextures { get => JSRef!.Get<float>("maxVertexTextures"); set => JSRef!.Set("maxVertexTextures", value); }
        /// <summary>
        /// maxVertexUniforms: number;
        /// </summary>
        public float MaxVertexUniforms { get => JSRef!.Get<float>("maxVertexUniforms"); set => JSRef!.Set("maxVertexUniforms", value); }
        /// <summary>
        /// precision: string;
        /// </summary>
        public string Precision { get => JSRef!.Get<string>("precision"); set => JSRef!.Set("precision", value); }
        /// <summary>
        /// reversedDepthBuffer: boolean;
        /// </summary>
        public bool ReversedDepthBuffer { get => JSRef!.Get<bool>("reversedDepthBuffer"); set => JSRef!.Set("reversedDepthBuffer", value); }
        /// <summary>
        /// vertexTextures: boolean;
        /// </summary>
        public bool VertexTextures { get => JSRef!.Get<bool>("vertexTextures"); set => JSRef!.Set("vertexTextures", value); }
        #endregion

        #region Methods
        /// <summary>
        /// (textureType: TextureDataType) => boolean
        /// </summary>
        public bool TextureTypeReadable(TextureDataType textureType)
        {
            return JSRef!.Call<bool>("textureTypeReadable", textureType);
        }
        /// <summary>
        /// (textureFormat: PixelFormat) => boolean
        /// </summary>
        public bool TextureFormatReadable(PixelFormat textureFormat)
        {
            return JSRef!.Call<bool>("textureFormatReadable", textureFormat);
        }
        /// <summary>
        /// (precision: string) => string
        /// </summary>
        public string GetMaxPrecision(string precision)
        {
            return JSRef!.Call<string>("getMaxPrecision", precision);
        }
        /// <summary>
        /// () => number
        /// </summary>
        public float GetMaxAnisotropy()
        {
            return JSRef!.Call<float>("getMaxAnisotropy");
        }
        #endregion
    }
}
