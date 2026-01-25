using Microsoft.JSInterop;

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
}
