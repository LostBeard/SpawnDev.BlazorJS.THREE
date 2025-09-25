
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MaterialLoader : Loader<Material>
    {
        #region Constructors
        /// <inheritdoc/>
        public MaterialLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public MaterialLoader(LoadingManager manager) : base(JS.New("THREE.MaterialLoader", manager)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// textures: { [key: string]: Texture };
        /// </summary>
        public object Textures { get => JSRef!.Get<object>("textures"); set => JSRef!.Set("textures", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setTextures(textures: { [key: string]: Texture }): this;
        /// </summary>
        public MaterialLoader SetTextures(object textures, string key)
        {
            return JSRef!.Call<MaterialLoader>("setTextures", textures, key);
        }
        /// <summary>
        /// parse(json: object): Material;
        /// </summary>
        public Material Parse(object json)
        {
            return JSRef!.Call<Material>("parse", json);
        }
        /// <summary>
        /// createMaterialFromType(type: string): Material;
        /// </summary>
        public Material CreateMaterialFromType(string type)
        {
            return JSRef!.Call<Material>("createMaterialFromType", type);
        }
        /// <summary>
        /// static createMaterialFromType(type: string): Material;
        /// </summary>
        public T CreateMaterialFromType<T>(string type) where T : Material
        {
            return JSRef!.Call<T>("createMaterialFromType", type);
        }
        #endregion
    }
}
