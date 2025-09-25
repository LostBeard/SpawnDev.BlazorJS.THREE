
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeUniform<TValue> : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, type: string | null, node: UniformNode<TValue>);
        /// </summary>
        public NodeUniform(string name, string type, UniformNode<TValue> node) : base(JS.New("THREE.NodeUniform", name, type, node)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// default;
        /// </summary>
        public TValue Default { get => JSRef!.Get<TValue>("default"); set => JSRef!.Set("default", value); }
        /// <summary>
        /// get groupNode():
        /// </summary>
        public object GroupNode { get => JSRef!.Get<object>("groupNode"); }
        /// <summary>
        /// get id(): number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// readonly isNodeUniform: true;
        /// </summary>
        public bool IsNodeUniform { get => JSRef!.Get<bool>("isNodeUniform"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// needsUpdate: boolean | undefined;
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// node: UniformNode<TValue>;
        /// </summary>
        public UniformNode<TValue> Node { get => JSRef!.Get<UniformNode<TValue>>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// type: string | null;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        /// <summary>
        /// get value(): TValue;
        /// </summary>
        public TValue Value { get => JSRef!.Get<TValue>("value"); set => JSRef!.Set("value", value); }
        #endregion

        #region Methods
        /// <summary>
        /// import(
        /// </summary>
        public object Import()
        {
            return JSRef!.Call<object>("import");
        }
        #endregion
    }
}
