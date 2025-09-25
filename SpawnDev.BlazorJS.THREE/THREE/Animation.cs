
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Animation : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Animation(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(nodes: Nodes, info: Info);
        /// </summary>
        public Animation(Nodes nodes, Info info) : base(JS.New("THREE.Animation", nodes, info)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// nodes: Nodes;
        /// </summary>
        public Nodes Nodes { get => JSRef!.Get<Nodes>("nodes"); set => JSRef!.Set("nodes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// stop(): void;
        /// </summary>
        public void Stop()
        {
            JSRef!.CallVoid("stop");
        }
        /// <summary>
        /// start(): void;
        /// </summary>
        public void Start()
        {
            JSRef!.CallVoid("start");
        }
        /// <summary>
        /// setContext(context: AnimationContext): void;
        /// </summary>
        public void SetContext(AnimationContext context)
        {
            JSRef!.CallVoid("setContext", context);
        }
        /// <summary>
        /// setAnimationLoop(callback: ((time: DOMHighResTimeStamp, xrFrame?: XRFrame) => void) | null): void;
        /// </summary>
        public void SetAnimationLoop(Callback callback, DOMHighResTimeStamp time, XRFrame xrFrame)
        {
            JSRef!.CallVoid("setAnimationLoop", callback, time, xrFrame);
        }
        /// <summary>
        /// getContext(): AnimationContext | null;
        /// </summary>
        public AnimationContext GetContext()
        {
            return JSRef!.Call<AnimationContext>("getContext");
        }
        /// <summary>
        /// getAnimationLoop(): ((time: DOMHighResTimeStamp, xrFrame?: XRFrame) => void) | null;
        /// </summary>
        public Callback GetAnimationLoop(DOMHighResTimeStamp time, XRFrame xrFrame)
        {
            return JSRef!.Call<Callback>("getAnimationLoop", time, xrFrame);
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
