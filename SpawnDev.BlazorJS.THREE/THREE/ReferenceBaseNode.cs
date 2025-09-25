
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ReferenceBaseNode<T> : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ReferenceBaseNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(property: string, uniformType: string, object?: T | null, count?: number | null);
        /// </summary>
        public ReferenceBaseNode(string property, string uniformType, T obj, float count) : base(JS.New("THREE.ReferenceBaseNode", property, uniformType, obj, count)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// count: number | null;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// node: Node | null;
        /// </summary>
        public Node Node { get => JSRef!.Get<Node>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// object: T;
        /// </summary>
        public T Object { get => JSRef!.Get<T>("object"); set => JSRef!.Set("object", value); }
        /// <summary>
        /// properties: string[];
        /// </summary>
        public Array<string> Properties { get => JSRef!.Get<Array<string>>("properties"); set => JSRef!.Set("properties", value); }
        /// <summary>
        /// property: string;
        /// </summary>
        public string Property { get => JSRef!.Get<string>("property"); set => JSRef!.Set("property", value); }
        /// <summary>
        /// reference: T | null;
        /// </summary>
        public T Reference { get => JSRef!.Get<T>("reference"); set => JSRef!.Set("reference", value); }
        /// <summary>
        /// uniformType: string;
        /// </summary>
        public string UniformType { get => JSRef!.Get<string>("uniformType"); set => JSRef!.Set("uniformType", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setNodeType(uniformType: string): void;
        /// </summary>
        public void SetNodeType(string uniformType)
        {
            JSRef!.CallVoid("setNodeType", uniformType);
        }
        #endregion
    }
}
