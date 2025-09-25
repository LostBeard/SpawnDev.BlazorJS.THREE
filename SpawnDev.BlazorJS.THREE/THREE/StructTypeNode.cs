
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StructTypeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public StructTypeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(membersLayout: MembersLayout, name?: string | null);
        /// </summary>
        public StructTypeNode(MembersLayout membersLayout, string name) : base(JS.New("THREE.StructTypeNode", membersLayout, name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isStructLayoutNode: true;
        /// </summary>
        public bool IsStructLayoutNode { get => JSRef!.Get<bool>("isStructLayoutNode"); }
        /// <summary>
        /// membersLayout: MemberLayout[];
        /// </summary>
        public Array<MemberLayout> MembersLayout { get => JSRef!.Get<Array<MemberLayout>>("membersLayout"); set => JSRef!.Set("membersLayout", value); }
        /// <summary>
        /// name: string | null;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// static get type(): string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setup(builder: NodeBuilder): void;
        /// </summary>
        public void Setup(NodeBuilder builder)
        {
            JSRef!.CallVoid("setup", builder);
        }
        /// <summary>
        /// getNodeType(builder: NodeBuilder): string;
        /// </summary>
        public string GetNodeType(NodeBuilder builder)
        {
            return JSRef!.Call<string>("getNodeType", builder);
        }
        /// <summary>
        /// getMemberType(builder: NodeBuilder, name: string): string;
        /// </summary>
        public string GetMemberType(NodeBuilder builder, string name)
        {
            return JSRef!.Call<string>("getMemberType", builder, name);
        }
        /// <summary>
        /// getLength(): number;
        /// </summary>
        public float GetLength()
        {
            return JSRef!.Call<float>("getLength");
        }
        /// <summary>
        /// generate(builder: NodeBuilder): string;
        /// </summary>
        public string Generate(NodeBuilder builder)
        {
            return JSRef!.Call<string>("generate", builder);
        }
        #endregion
    }
}
