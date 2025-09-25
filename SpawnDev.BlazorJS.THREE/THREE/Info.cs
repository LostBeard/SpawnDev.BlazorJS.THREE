
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Info : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Info(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Info() : base(JS.New("THREE.Info")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoReset: boolean;
        /// </summary>
        public bool AutoReset { get => JSRef!.Get<bool>("autoReset"); set => JSRef!.Set("autoReset", value); }
        /// <summary>
        /// calls: number;
        /// </summary>
        public float Calls { get => JSRef!.Get<float>("calls"); set => JSRef!.Set("calls", value); }
        /// <summary>
        /// compute: {
                ///         calls: number;
                ///         frameCalls: number;
                ///         timestamp: number;
                ///     };
        /// </summary>
        public object Compute { get => JSRef!.Get<object>("compute"); set => JSRef!.Set("compute", value); }
        /// <summary>
        /// frame: number;
        /// </summary>
        public float Frame { get => JSRef!.Get<float>("frame"); set => JSRef!.Set("frame", value); }
        /// <summary>
        /// memory: {
                ///         geometries: number;
                ///         textures: number;
                ///     };
        /// </summary>
        public object Memory { get => JSRef!.Get<object>("memory"); set => JSRef!.Set("memory", value); }
        /// <summary>
        /// render: {
                ///         calls: number;
                ///         frameCalls: number;
                ///         drawCalls: number;
                ///         triangles: number;
                ///         points: number;
                ///         lines: number;
                ///         timestamp: number;
                ///     };
        /// </summary>
        public object Render { get => JSRef!.Get<object>("render"); set => JSRef!.Set("render", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(object: Object3D, count: number, instanceCount: number): void;
        /// </summary>
        public void Update(Object3D obj, float count, float instanceCount)
        {
            JSRef!.CallVoid("update", obj, count, instanceCount);
        }
        /// <summary>
        /// reset(): void;
        /// </summary>
        public void Reset()
        {
            JSRef!.CallVoid("reset");
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
