
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ComputeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public ComputeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(computeNode: Node, workgroupSize: number[]);
        /// </summary>
        public ComputeNode(Node computeNode, Array<float> workgroupSize) : base(JS.New("THREE.ComputeNode", computeNode, workgroupSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// computeNode: Node;
        /// </summary>
        public Node ComputeNodeV { get => JSRef!.Get<Node>("computeNode"); set => JSRef!.Set("computeNode", value); }
        /// <summary>
        /// count: number | null;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// readonly isComputeNode: true;
        /// </summary>
        public bool IsComputeNode { get => JSRef!.Get<bool>("isComputeNode"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// onInitFunction: ((args: { renderer: Renderer }) => void) | null;
        /// </summary>
        public Callback OnInitFunction { get => JSRef!.Get<Callback>("onInitFunction"); set => JSRef!.Set("onInitFunction", value); }
        /// <summary>
        /// workgroupSize: number[];
        /// </summary>
        public Array<float> WorkgroupSize { get => JSRef!.Get<Array<float>>("workgroupSize"); set => JSRef!.Set("workgroupSize", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setName(name: string): this;
        /// </summary>
        public ComputeNode SetName(string name)
        {
            return JSRef!.Call<ComputeNode>("setName", name);
        }
        /// <summary>
        /// setCount(count: number): this;
        /// </summary>
        public ComputeNode SetCount(float count)
        {
            return JSRef!.Call<ComputeNode>("setCount", count);
        }
        /// <summary>
        /// onInit(callback: ((args: { renderer: Renderer }) => void) | null): void;
        /// </summary>
        public void OnInit(Callback callback, object args)
        {
            JSRef!.CallVoid("onInit", callback, args);
        }
        /// <summary>
        /// label(name: string): this;
        /// </summary>
        public ComputeNode Label(string name)
        {
            return JSRef!.Call<ComputeNode>("label", name);
        }
        /// <summary>
        /// getCount(): number | null;
        /// </summary>
        public float GetCount()
        {
            return JSRef!.Call<float>("getCount");
        }
        #endregion
    }
}
