
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeSampledTexture : SampledTexture
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeSampledTexture(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         name: string,
        ///         textureNode: TextureNode | undefined,
        ///         groupNode: UniformGroupNode,
        ///         access?: GPUStorageTextureAccess | null,
        ///     );
        /// </summary>
        public NodeSampledTexture(string name, TextureNode textureNode, UniformGroupNode groupNode, GPUStorageTextureAccess access) : base(JS.New("THREE.NodeSampledTexture", name, textureNode, groupNode, access)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// access: "read-write" | "read-only" | "write-only";
        /// </summary>
        public string Access { get => JSRef!.Get<string>("access"); set => JSRef!.Set("access", value); }
        /// <summary>
        /// groupNode: UniformGroupNode;
        /// </summary>
        public UniformGroupNode GroupNode { get => JSRef!.Get<UniformGroupNode>("groupNode"); set => JSRef!.Set("groupNode", value); }
        /// <summary>
        /// textureNode: TextureNode | undefined;
        /// </summary>
        public TextureNode TextureNode { get => JSRef!.Get<TextureNode>("textureNode"); set => JSRef!.Set("textureNode", value); }
        #endregion

        #region Methods

        #endregion
    }
}
