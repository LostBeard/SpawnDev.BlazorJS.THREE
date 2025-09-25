
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Storage3DTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public Storage3DTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number, depth?: number);
        /// </summary>
        public Storage3DTexture(float width, float height, float depth) : base(JS.New("THREE.Storage3DTexture", width, height, depth)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// is3DTexture: boolean;
        /// </summary>
        public bool Is3DTexture { get => JSRef!.Get<bool>("is3DTexture"); set => JSRef!.Set("is3DTexture", value); }
        /// <summary>
        /// readonly isStorageTexture: true;
        /// </summary>
        public bool IsStorageTexture { get => JSRef!.Get<bool>("isStorageTexture"); }
        /// <summary>
        /// wrapR: Wrapping;
        /// </summary>
        public Wrapping WrapR { get => JSRef!.Get<Wrapping>("wrapR"); set => JSRef!.Set("wrapR", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setSize(width: number, height: number, depth: number): void;
        /// </summary>
        public void SetSize(float width, float height, float depth)
        {
            JSRef!.CallVoid("setSize", width, height, depth);
        }
        #endregion
    }
}
