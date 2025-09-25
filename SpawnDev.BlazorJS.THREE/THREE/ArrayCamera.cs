
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ArrayCamera : PerspectiveCamera
    {
        #region Constructors
        /// <inheritdoc/>
        public ArrayCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(cameras?: PerspectiveCamera[]);
        /// </summary>
        public ArrayCamera(Array<PerspectiveCamera> cameras) : base(JS.New("THREE.ArrayCamera", cameras)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// cameras: PerspectiveCamera[];
        /// </summary>
        public Array<PerspectiveCamera> Cameras { get => JSRef!.Get<Array<PerspectiveCamera>>("cameras"); set => JSRef!.Set("cameras", value); }
        /// <summary>
        /// index: number;
        /// </summary>
        public float Index { get => JSRef!.Get<float>("index"); set => JSRef!.Set("index", value); }
        /// <summary>
        /// readonly isArrayCamera: true;
        /// </summary>
        public bool IsArrayCamera { get => JSRef!.Get<bool>("isArrayCamera"); }
        /// <summary>
        /// isMultiViewCamera: boolean;
        /// </summary>
        public bool IsMultiViewCamera { get => JSRef!.Get<bool>("isMultiViewCamera"); set => JSRef!.Set("isMultiViewCamera", value); }
        #endregion

        #region Methods

        #endregion
    }
}
