
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SceneNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public SceneNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope?: SceneNodeScope, scene?: Scene | null);
        /// </summary>
        public SceneNode(SceneNodeScope scope, Scene scene) : base(JS.New("THREE.SceneNode", scope, scene)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static BACKGROUND_BLURRINESS: "backgroundBlurriness";
        /// </summary>
        public static string BACKGROUND_BLURRINESS { get => JS.Get<string>("THREE.SceneNode.BACKGROUND_BLURRINESS"); set => JS.Set("THREE.SceneNode.BACKGROUND_BLURRINESS", value); }
        /// <summary>
        /// static BACKGROUND_INTENSITY: "backgroundIntensity";
        /// </summary>
        public static string BACKGROUND_INTENSITY { get => JS.Get<string>("THREE.SceneNode.BACKGROUND_INTENSITY"); set => JS.Set("THREE.SceneNode.BACKGROUND_INTENSITY", value); }
        /// <summary>
        /// static BACKGROUND_ROTATION: "backgroundRotation";
        /// </summary>
        public static string BACKGROUND_ROTATION { get => JS.Get<string>("THREE.SceneNode.BACKGROUND_ROTATION"); set => JS.Set("THREE.SceneNode.BACKGROUND_ROTATION", value); }
        /// <summary>
        /// scene: Scene | null;
        /// </summary>
        public Scene Scene { get => JSRef!.Get<Scene>("scene"); set => JSRef!.Set("scene", value); }
        /// <summary>
        /// scope: SceneNodeScope;
        /// </summary>
        public SceneNodeScope Scope { get => JSRef!.Get<SceneNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        #endregion

        #region Methods

        #endregion
    }
}
