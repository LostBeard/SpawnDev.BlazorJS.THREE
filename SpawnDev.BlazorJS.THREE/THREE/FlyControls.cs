using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// FlyControls enables a navigation similar to fly modes in DCC tools like Blender.
    /// You can arbitrarily transform the camera in 3D space without any limitations 
    /// (e.g. focus on a specific target).
    /// </summary>
    public class FlyControls : Controls
    {
        #region Constructors
        /// <inheritdoc/>
        public FlyControls(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new FlyControls instance
        /// </summary>
        /// <param name="camera">The camera to be controlled</param>
        /// <param name="domElement">The HTML element used for event listeners</param>
        public FlyControls(Camera camera, HTMLElement domElement) 
            : base(JS.New("FlyControls", camera, domElement)) { }
        #endregion

        #region Properties
        /// <summary>
        /// If set to true, you can only look around by performing a drag interaction. Default is false.
        /// </summary>
        public bool DragToLook { get => JSRef!.Get<bool>("dragToLook"); set => JSRef!.Set("dragToLook", value); }

        /// <summary>
        /// The movement speed. Default is 1.
        /// </summary>
        public float MovementSpeed { get => JSRef!.Get<float>("movementSpeed"); set => JSRef!.Set("movementSpeed", value); }

        /// <summary>
        /// The rotation speed. Default is 0.005.
        /// </summary>
        public float RollSpeed { get => JSRef!.Get<float>("rollSpeed"); set => JSRef!.Set("rollSpeed", value); }

        /// <summary>
        /// If set to true, the camera automatically moves forward (and does not stop) when initially translated.
        /// Default is false.
        /// </summary>
        public bool AutoForward { get => JSRef!.Get<bool>("autoForward"); set => JSRef!.Set("autoForward", value); }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the controls. Usually called in the animation loop.
        /// </summary>
        /// <param name="delta">Time in seconds since the last call to update</param>
        public new void Update(float delta)
        {
            JSRef!.CallVoid("update", delta);
        }
        #endregion
    }
}
