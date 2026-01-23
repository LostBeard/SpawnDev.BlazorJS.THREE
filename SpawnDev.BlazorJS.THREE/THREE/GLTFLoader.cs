using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Result object from GLTFLoader.load() and GLTFLoader.loadAsync()
    /// </summary>
    public class GLTF : JSObject
    {
        /// <inheritdoc/>
        public GLTF(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// The loaded scene(s) of the glTF asset
        /// </summary>
        public Group Scene => JSRef!.Get<Group>("scene");

        /// <summary>
        /// Array of all scenes in the glTF asset
        /// </summary>
        public Group[] Scenes => JSRef!.Get<Group[]>("scenes");

        /// <summary>
        /// Array of AnimationClips found in the glTF asset
        /// </summary>
        public AnimationClip[] Animations => JSRef!.Get<AnimationClip[]>("animations");

        /// <summary>
        /// Array of cameras found in the glTF asset
        /// </summary>
        public Camera[] Cameras => JSRef!.Get<Camera[]>("cameras");

        /// <summary>
        /// Object containing extension data
        /// </summary>
        public JSObject? Asset => JSRef!.Get<JSObject?>("asset");

        /// <summary>
        /// The raw JSON data from the glTF file
        /// </summary>
        public JSObject? Parser => JSRef!.Get<JSObject?>("parser");

        /// <summary>
        /// User data from the glTF file
        /// </summary>
        public JSObject? UserData => JSRef!.Get<JSObject?>("userData");
    }

    /// <summary>
    /// A loader for glTF 2.0 resources.
    /// glTF (GL Transmission Format) is an open format specification for efficient delivery 
    /// and loading of 3D content. Assets may be provided either in JSON (.gltf) or binary (.glb) format.
    /// </summary>
    public class GLTFLoader : Loader<GLTF>
    {
        #region Constructors
        /// <inheritdoc/>
        public GLTFLoader(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new GLTFLoader
        /// </summary>
        public GLTFLoader() : base(JS.New("GLTFLoader")) { }

        /// <summary>
        /// Creates a new GLTFLoader with the specified loading manager
        /// </summary>
        public GLTFLoader(LoadingManager manager) : base(JS.New("GLTFLoader", manager)) { }
        #endregion

        #region Properties
        /// <summary>
        /// The DRACOLoader instance to use for decoding Draco compressed meshes
        /// </summary>
        public JSObject? DracoLoader { get => JSRef!.Get<JSObject?>("dracoLoader"); set => JSRef!.Set("dracoLoader", value); }

        /// <summary>
        /// The KTX2Loader instance to use for loading KTX2 textures
        /// </summary>
        public JSObject? Ktx2Loader { get => JSRef!.Get<JSObject?>("ktx2Loader"); set => JSRef!.Set("ktx2Loader", value); }
        #endregion

        #region Methods
        /// <summary>
        /// Loads a glTF asset from the specified URL
        /// </summary>
        /// <param name="url">URL to load</param>
        /// <returns>A task that resolves to the loaded GLTF object</returns>
        public Task<GLTF> LoadAsync(string url)
        {
            return JSRef!.CallAsync<GLTF>("loadAsync", url);
        }

        /// <summary>
        /// Sets the DRACOLoader to use for decoding Draco compressed meshes
        /// </summary>
        public GLTFLoader SetDRACOLoader(JSObject dracoLoader)
        {
            JSRef!.CallVoid("setDRACOLoader", dracoLoader);
            return this;
        }

        /// <summary>
        /// Sets the KTX2Loader to use for loading KTX2 textures
        /// </summary>
        public GLTFLoader SetKTX2Loader(JSObject ktx2Loader)
        {
            JSRef!.CallVoid("setKTX2Loader", ktx2Loader);
            return this;
        }

        /// <summary>
        /// Sets the MeshoptDecoder to use for decoding meshopt compressed data
        /// </summary>
        public GLTFLoader SetMeshoptDecoder(JSObject meshoptDecoder)
        {
            JSRef!.CallVoid("setMeshoptDecoder", meshoptDecoder);
            return this;
        }

        /// <summary>
        /// Registers a plugin callback
        /// </summary>
        public GLTFLoader Register(Callback callback)
        {
            JSRef!.CallVoid("register", callback);
            return this;
        }

        /// <summary>
        /// Unregisters a plugin callback
        /// </summary>
        public GLTFLoader Unregister(Callback callback)
        {
            JSRef!.CallVoid("unregister", callback);
            return this;
        }
        #endregion
    }
}
