
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StorageTexture : Texture
    {
        #region Constructors
        /// <inheritdoc/>
        public StorageTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(width?: number, height?: number);
        /// </summary>
        public StorageTexture(float width, float height) : base(JS.New("THREE.StorageTexture", width, height)) { }
        
        #endregion

        #region Properties

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
