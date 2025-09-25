
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MorphNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public MorphNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(mesh: Mesh);
        /// </summary>
        public MorphNode(Mesh mesh) : base(JS.New("THREE.MorphNode", mesh)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// mesh: Mesh;
        /// </summary>
        public Mesh Mesh { get => JSRef!.Get<Mesh>("mesh"); set => JSRef!.Set("mesh", value); }
        /// <summary>
        /// morphBaseInfluence: UniformNode<number>;
        /// </summary>
        public UniformNode<float> MorphBaseInfluence { get => JSRef!.Get<UniformNode<float>>("morphBaseInfluence"); set => JSRef!.Set("morphBaseInfluence", value); }
        #endregion

        #region Methods

        #endregion
    }
}
