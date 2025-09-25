
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ObjectLoader : Loader<Object3D>
    {
        #region Constructors
        /// <inheritdoc/>
        public ObjectLoader(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(manager?: LoadingManager);
        /// </summary>
        public ObjectLoader(LoadingManager manager) : base(JS.New("THREE.ObjectLoader", manager)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        ///// <summary>
        ///// parseTextures(json: object, images: { [key: string]: Source }): { [key: string]: Texture };
        ///// </summary>
        //public object ParseTextures(object json, object images, string key, string key)
        //{
        //    return JSRef!.Call<object>("parseTextures", json, images, key, key);
        //}
        ///// <summary>
        ///// parseObject(
        /////         data: object,
        /////         geometries: { [key: string]: InstancedBufferGeometry | BufferGeometry },
        /////         materials: { [key: string]: Material },
        /////         animations: { [key: string]: AnimationClip },
        /////     ): Object3D;
        ///// </summary>
        //public Object3D ParseObject(object data, object geometries, string key, object materials, string key, object animations, string key)
        //{
        //    return JSRef!.Call<Object3D>("parseObject", data, geometries, key, materials, key, animations, key);
        //}
        ///// <summary>
        ///// parseMaterials(json: object, textures: { [key: string]: Texture }): { [key: string]: Material };
        ///// </summary>
        //public object ParseMaterials(object json, object textures, string key, string key)
        //{
        //    return JSRef!.Call<object>("parseMaterials", json, textures, key, key);
        //}
        /// <summary>
        /// parseImagesAsync(json: object): Promise<{ [key: string]: Source }>;
        /// </summary>
        public Task<object> ParseImagesAsync(object json, string key)
        {
            return JSRef!.CallAsync<object>("parseImagesAsync", json, key);
        }
        /// <summary>
        /// parseImages(json: object, onLoad?: () => void): { [key: string]: Source };
        /// </summary>
        public object ParseImages(object json, Callback onLoad, string key)
        {
            return JSRef!.Call<object>("parseImages", json, onLoad, key);
        }
        /// <summary>
        /// parseGeometries(json: object): { [key: string]: InstancedBufferGeometry | BufferGeometry };
        /// </summary>
        public object ParseGeometries(object json, string key)
        {
            return JSRef!.Call<object>("parseGeometries", json, key);
        }
        /// <summary>
        /// parseAsync(json: object): Promise<Object3D>;
        /// </summary>
        public Task<Object3D> ParseAsync(object json)
        {
            return JSRef!.CallAsync<Object3D>("parseAsync", json);
        }
        /// <summary>
        /// parseAnimations(json: object): { [key: string]: AnimationClip };
        /// </summary>
        public object ParseAnimations(object json, string key)
        {
            return JSRef!.Call<object>("parseAnimations", json, key);
        }
        /// <summary>
        /// parse(json: object, onLoad?: (object: Object3D) => void): Object3D;
        /// </summary>
        public Object3D Parse(object json, Callback onLoad, Object3D obj)
        {
            return JSRef!.Call<Object3D>("parse", json, onLoad, obj);
        }
        /// <summary>
        /// load(
        ///         url: string,
        ///         onLoad?: (data: Object3D) => void,
        ///         onProgress?: (event: ProgressEvent) => void,
        ///         onError?: (err: object) => void,
        ///     ): void;
        /// </summary>
        public void Load(string url, Callback onLoad, Object3D data, Callback onProgress, ProgressEvent ev, Callback onError, object err)
        {
            JSRef!.CallVoid("load", url, onLoad, data, onProgress, ev, onError, err);
        }
        #endregion
    }
}
