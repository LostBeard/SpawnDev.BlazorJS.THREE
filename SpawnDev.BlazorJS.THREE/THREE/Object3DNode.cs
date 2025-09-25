
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Object3DNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public Object3DNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: string, object3d?: Object3D | null);
        /// </summary>
        public Object3DNode(string scope, Object3D object3d) : base(JS.New("THREE.Object3DNode", scope, object3d)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static DIRECTION: "direction";
        /// </summary>
        public static string DIRECTION { get => JS.Get<string>("THREE.Object3DNode.DIRECTION"); set => JS.Set("THREE.Object3DNode.DIRECTION", value); }
        /// <summary>
        /// object3d: Object3D | null;
        /// </summary>
        public Object3D Object3d { get => JSRef!.Get<Object3D>("object3d"); set => JSRef!.Set("object3d", value); }
        /// <summary>
        /// static POSITION: "position";
        /// </summary>
        public static string POSITION { get => JS.Get<string>("THREE.Object3DNode.POSITION"); set => JS.Set("THREE.Object3DNode.POSITION", value); }
        /// <summary>
        /// static RADIUS: "radius";
        /// </summary>
        public static string RADIUS { get => JS.Get<string>("THREE.Object3DNode.RADIUS"); set => JS.Set("THREE.Object3DNode.RADIUS", value); }
        /// <summary>
        /// static SCALE: "scale";
        /// </summary>
        public static string SCALE { get => JS.Get<string>("THREE.Object3DNode.SCALE"); set => JS.Set("THREE.Object3DNode.SCALE", value); }
        /// <summary>
        /// scope: string;
        /// </summary>
        public string Scope { get => JSRef!.Get<string>("scope"); set => JSRef!.Set("scope", value); }
        /// <summary>
        /// static VIEW_POSITION: "viewPosition";
        /// </summary>
        public static string VIEW_POSITION { get => JS.Get<string>("THREE.Object3DNode.VIEW_POSITION"); set => JS.Set("THREE.Object3DNode.VIEW_POSITION", value); }
        /// <summary>
        /// static WORLD_MATRIX: "worldMatrix";
        /// </summary>
        public static string WORLD_MATRIX { get => JS.Get<string>("THREE.Object3DNode.WORLD_MATRIX"); set => JS.Set("THREE.Object3DNode.WORLD_MATRIX", value); }
        #endregion

        #region Methods

        #endregion
    }
}
