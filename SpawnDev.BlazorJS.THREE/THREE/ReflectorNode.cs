
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ReflectorNode : TextureNode
    {
        #region Constructors
        /// <inheritdoc/>
        public ReflectorNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameters?: ReflectorNodeParameters);
        /// </summary>
        public ReflectorNode(ReflectorNodeParameters parameters) : base(JS.New("THREE.ReflectorNode", parameters)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// get reflector(): ReflectorBaseNode;
        /// </summary>
        public ReflectorBaseNode Reflector { get => JSRef!.Get<ReflectorBaseNode>("reflector"); }
        /// <summary>
        /// get target(): Object3D;
        /// </summary>
        public Object3D Target { get => JSRef!.Get<Object3D>("target"); }
        #endregion

        #region Methods
        /// <summary>
        /// getDepthNode(): ShaderNodeObject<ReflectorNode>;
        /// </summary>
        public ShaderNodeObject<ReflectorNode> GetDepthNode()
        {
            return JSRef!.Call<ShaderNodeObject<ReflectorNode>>("getDepthNode");
        }
        #endregion
    }
}
