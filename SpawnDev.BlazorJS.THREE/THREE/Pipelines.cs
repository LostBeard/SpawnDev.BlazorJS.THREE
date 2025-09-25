
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Pipelines : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Pipelines(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(backend: Backend, nodes: Nodes);
        /// </summary>
        public Pipelines(Backend backend, Nodes nodes) : base(JS.New("THREE.Pipelines", backend, nodes)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// backend: Backend;
        /// </summary>
        public Backend Backend { get => JSRef!.Get<Backend>("backend"); set => JSRef!.Set("backend", value); }
        /// <summary>
        /// bindings: Bindings | null;
        /// </summary>
        public Bindings Bindings { get => JSRef!.Get<Bindings>("bindings"); set => JSRef!.Set("bindings", value); }
        /// <summary>
        /// caches: Map<string, Pipeline>;
        /// </summary>
        public Map<string, Pipeline> Caches { get => JSRef!.Get<Map<string, Pipeline>>("caches"); set => JSRef!.Set("caches", value); }
        /// <summary>
        /// nodes: Nodes;
        /// </summary>
        public Nodes Nodes { get => JSRef!.Get<Nodes>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// programs: {
                ///         vertex: Map<string, ProgrammableStage>;
                ///         fragment: Map<string, ProgrammableStage>;
                ///         compute: Map<string, ProgrammableStage>;
                ///     };
        /// </summary>
        public object Programs { get => JSRef!.Get<object>("programs"); set => JSRef!.Set("programs", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateForRender(renderObject: RenderObject): void;
        /// </summary>
        public void UpdateForRender(RenderObject renderObject)
        {
            JSRef!.CallVoid("updateForRender", renderObject);
        }
        /// <summary>
        /// getForRender(renderObject: RenderObject, promises?: Promise<void>[] | null): RenderPipeline;
        /// </summary>
        public RenderPipeline GetForRender(RenderObject renderObject, Array<Promise> promises)
        {
            return JSRef!.Call<RenderPipeline>("getForRender", renderObject, promises);
        }
        /// <summary>
        /// getForCompute(computeNode: ComputeNode, bindings: Binding[]): ComputePipeline;
        /// </summary>
        public ComputePipeline GetForCompute(ComputeNode computeNode, Array<Binding> bindings)
        {
            return JSRef!.Call<ComputePipeline>("getForCompute", computeNode, bindings);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// delete(object: ComputeNode | RenderObject): never;
        /// </summary>
        public object Delete(Union<ComputeNode, RenderObject> obj)
        {
            return JSRef!.Call<object>("delete", obj);
        }
        #endregion
    }
}
