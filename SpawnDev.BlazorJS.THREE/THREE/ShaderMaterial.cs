
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ShaderMaterial : Material
    {
        #region Constructors
        /// <inheritdoc/>
        public ShaderMaterial(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: ShaderMaterialParameters);
        /// </summary>
        public ShaderMaterial(ShaderMaterialParameters parameters) : base(JS.New("THREE.ShaderMaterial", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isShaderMaterial: boolean;
        /// </summary>
        public bool IsShaderMaterial { get => JSRef!.Get<bool>("isShaderMaterial"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: JSONMeta): ShaderMaterialJSON;
        /// </summary>
        public ShaderMaterialJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<ShaderMaterialJSON>("toJSON", meta);
        }
        /// <summary>
        /// setValues(values?: ShaderMaterialParameters): void;
        /// </summary>
        public void SetValues(ShaderMaterialParameters values)
        {
            JSRef!.CallVoid("setValues", values);
        }
        #endregion
    }
}
