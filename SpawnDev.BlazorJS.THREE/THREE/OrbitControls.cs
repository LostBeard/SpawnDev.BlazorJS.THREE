using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// OrbitControls performs orbiting, dollying (zooming), and panning.
    /// </summary>
    public class OrbitControls : Controls
    {
        #region Constructors
        /// <inheritdoc/>
        public OrbitControls(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// constructor(object: Object3D, domElement?: HTMLElement | null);
        /// </summary>
        public OrbitControls(Object3D obj, HTMLElement domElement) : base(JS.New("OrbitControls", obj, domElement)) { }
        #endregion

        #region Properties
        /// <summary>
        /// "target" sets the location of focus, where the object orbits around
        /// </summary>
        public Vector3 Target => JSRef!.Get<Vector3>("target");
        /// <summary>
        /// Set to true to enable damping (inertia)
        /// If damping is enabled, you must call controls.update() in your animation loop
        /// </summary>
        public bool EnableDamping { get => JSRef!.Get<bool>("enableDamping"); set => JSRef!.Set("enableDamping", value); }
        /// <summary>
        /// The damping factor
        /// </summary>
        public float DampingFactor { get => JSRef!.Get<float>("dampingFactor"); set => JSRef!.Set("dampingFactor", value); }
        /// <summary>
        /// Set to true to automatically rotate around the target
        /// If auto-rotate is enabled, you must call controls.update() in your animation loop
        /// </summary>
        public bool AutoRotate { get => JSRef!.Get<bool>("autoRotate"); set => JSRef!.Set("autoRotate", value); }
        /// <summary>
        /// The auto-rotate speed
        /// </summary>
        public float AutoRotateSpeed { get => JSRef!.Get<float>("autoRotateSpeed"); set => JSRef!.Set("autoRotateSpeed", value); }
        /// <summary>
        /// Set to false to disable zooming
        /// </summary>
        public bool EnableZoom { get => JSRef!.Get<bool>("enableZoom"); set => JSRef!.Set("enableZoom", value); }
        /// <summary>
        /// Set to false to disable rotating
        /// </summary>
        public bool EnableRotate { get => JSRef!.Get<bool>("enableRotate"); set => JSRef!.Set("enableRotate", value); }
        /// <summary>
        /// Set to false to disable panning
        /// </summary>
        public bool EnablePan { get => JSRef!.Get<bool>("enablePan"); set => JSRef!.Set("enablePan", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(delta?: number): boolean;
        /// </summary>
        public bool Update() => JSRef!.Call<bool>("update");
        /// <summary>
        /// update(delta: number): boolean;
        /// </summary>
        public bool Update(float delta) => JSRef!.Call<bool>("update", delta);
        /// <summary>
        /// Resets the controls to their initial state
        /// </summary>
        public void Reset() => JSRef!.CallVoid("reset");
        /// <summary>
        /// Saves the current state of the controls
        /// </summary>
        public void SaveState() => JSRef!.CallVoid("saveState");
        #endregion
    }
}
