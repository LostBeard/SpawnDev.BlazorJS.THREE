
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StereoCamera : Camera
    {
        #region Constructors
        /// <inheritdoc/>
        public StereoCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public StereoCamera() : base(JS.New("THREE.StereoCamera")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// aspect: number;
        /// </summary>
        public float Aspect { get => JSRef!.Get<float>("aspect"); set => JSRef!.Set("aspect", value); }
        /// <summary>
        /// cameraL: PerspectiveCamera;
        /// </summary>
        public PerspectiveCamera CameraL { get => JSRef!.Get<PerspectiveCamera>("cameraL"); set => JSRef!.Set("cameraL", value); }
        /// <summary>
        /// cameraR: PerspectiveCamera;
        /// </summary>
        public PerspectiveCamera CameraR { get => JSRef!.Get<PerspectiveCamera>("cameraR"); set => JSRef!.Set("cameraR", value); }
        /// <summary>
        /// eyeSep: number;
        /// </summary>
        public float EyeSep { get => JSRef!.Get<float>("eyeSep"); set => JSRef!.Set("eyeSep", value); }
        /// <summary>
        /// type: "StereoCamera";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(camera: PerspectiveCamera): void;
        /// </summary>
        public void Update(PerspectiveCamera camera)
        {
            JSRef!.CallVoid("update", camera);
        }
        #endregion
    }
}
