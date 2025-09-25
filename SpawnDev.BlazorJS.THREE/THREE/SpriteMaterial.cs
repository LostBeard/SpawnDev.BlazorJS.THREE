
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SpriteMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public SpriteMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: SpriteMaterialParameters);
        /// </summary>
        public SpriteMaterial(SpriteMaterialParameters parameters) : base(JS.New("THREE.SpriteMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isSpriteMaterial: boolean;
        /// </summary>
        public bool IsSpriteMaterial { get => JSRef!.Get<bool>("isSpriteMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// setValues(values?: SpriteMaterialParameters): void;
        /// </summary>
        public void SetValues(SpriteMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
