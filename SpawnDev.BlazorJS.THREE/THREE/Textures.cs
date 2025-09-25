
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Textures : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Textures(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(renderer: Renderer, backend: Backend, info: Info);
        /// </summary>
        public Textures(Renderer renderer, Backend backend, Info info) : base(JS.New("THREE.Textures", renderer, backend, info)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateTexture(texture: Texture, options?: TextureOptions): void;
        /// </summary>
        public void UpdateTexture(Texture texture, TextureOptions options)
        {
            JSRef!.CallVoid("updateTexture", texture, options);
        }
        /// <summary>
        /// updateRenderTarget(renderTarget: RenderTarget, activeMipmapLevel?: number): void;
        /// </summary>
        public void UpdateRenderTarget(RenderTarget renderTarget, float activeMipmapLevel)
        {
            JSRef!.CallVoid("updateRenderTarget", renderTarget, activeMipmapLevel);
        }
        /// <summary>
        /// needsMipmaps(texture: Texture): boolean;
        /// </summary>
        public bool NeedsMipmaps(Texture texture)
        {
            return JSRef!.Call<bool>("needsMipmaps", texture);
        }
        ///// <summary>
        ///// getSize(texture: Texture, target?: SizeVector3Uninitialized): SizeVector3;
        ///// </summary>
        //public SizeVector3 GetSize(Texture texture, SizeVector3Uninitialized target)
        //{
        //    return JSRef!.Call<SizeVector3>("getSize", texture, target);
        //}
        /// <summary>
        /// getMipLevels(texture: Texture, width: number, height: number): number;
        /// </summary>
        public float GetMipLevels(Texture texture, float width, float height)
        {
            return JSRef!.Call<float>("getMipLevels", texture, width, height);
        }
        #endregion
    }
}
