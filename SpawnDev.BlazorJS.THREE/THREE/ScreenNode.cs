
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ScreenNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ScreenNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: ScreenNodeScope);
        /// </summary>
        public ScreenNode(ScreenNodeScope scope) : base(JS.New("THREE.ScreenNode", scope)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static COORDINATE: "coordinate";
        /// </summary>
        public static string COORDINATE { get => JS.Get<string>("THREE.ScreenNode.COORDINATE"); set => JS.Set("THREE.ScreenNode.COORDINATE", value); }
        /// <summary>
        /// static DPR: "dpr";
        /// </summary>
        public static string DPR { get => JS.Get<string>("THREE.ScreenNode.DPR"); set => JS.Set("THREE.ScreenNode.DPR", value); }
        /// <summary>
        /// readonly isViewportNode: true;
        /// </summary>
        public bool IsViewportNode { get => JSRef!.Get<bool>("isViewportNode"); }
        /// <summary>
        /// scope: ScreenNodeScope;
        /// </summary>
        public ScreenNodeScope Scope { get => JSRef!.Get<ScreenNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        /// <summary>
        /// static SIZE: "size";
        /// </summary>
        public static string SIZE { get => JS.Get<string>("THREE.ScreenNode.SIZE"); set => JS.Set("THREE.ScreenNode.SIZE", value); }
        /// <summary>
        /// static UV: "uv";
        /// </summary>
        public static string UV { get => JS.Get<string>("THREE.ScreenNode.UV"); set => JS.Set("THREE.ScreenNode.UV", value); }
        /// <summary>
        /// static VIEWPORT: "viewport";
        /// </summary>
        public static string VIEWPORT { get => JS.Get<string>("THREE.ScreenNode.VIEWPORT"); set => JS.Set("THREE.ScreenNode.VIEWPORT", value); }
        #endregion

        #region Methods

        #endregion
    }
}
