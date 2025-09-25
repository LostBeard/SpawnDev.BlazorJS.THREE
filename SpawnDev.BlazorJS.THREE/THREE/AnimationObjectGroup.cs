
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationObjectGroup : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationObjectGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(...args: Object3D[]);
        /// </summary>
        public AnimationObjectGroup(params Object3D[] args) : base(JS.NewApply("THREE.AnimationObjectGroup", args)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isAnimationObjectGroup: true;
        /// </summary>
        public bool IsAnimationObjectGroup { get => JSRef!.Get<bool>("isAnimationObjectGroup"); }
        /// <summary>
        /// readonly uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); }
        #endregion

        #region Methods
        /// <summary>
        /// uncache(...args: Object3D[]): void;
        /// </summary>
        public void Uncache(params Object3D[] args)
        {
            JSRef!.CallApplyVoid("uncache", args);
        }
        /// <summary>
        /// remove(...args: Object3D[]): void;
        /// </summary>
        public void Remove(params Object3D[] args)
        {
            JSRef!.CallApplyVoid("remove", args);
        }
        /// <summary>
        /// add(...args: Object3D[]): void;
        /// </summary>
        public void Add(params Object3D[] args)
        {
            JSRef!.CallApplyVoid("add", args);
        }
        #endregion
    }
}
