
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BindGroup : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public BindGroup(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         name?: string,
        ///         bindings?: NodeUniformsGroup[],
        ///         index?: number,
        ///         bindingsReference?: NodeUniformsGroup[] | BindGroup,
        ///     );
        /// </summary>
        public BindGroup(string name, Array<NodeUniformsGroup> bindings, float index, Union<Array<NodeUniformsGroup>, BindGroup> bindingsReference) : base(JS.New("THREE.BindGroup", name, bindings, index, bindingsReference)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bindings: NodeUniformsGroup[] | Binding[];
        /// </summary>
        public Union<Array<NodeUniformsGroup>, Array<Binding>> Bindings { get => JSRef!.Get<Union<Array<NodeUniformsGroup>, Array<Binding>>>("bindings"); set => JSRef!.Set("bindings", value); }
        /// <summary>
        /// bindingsReference: NodeUniformsGroup[] | BindGroup;
        /// </summary>
        public Union<Array<NodeUniformsGroup>, BindGroup> BindingsReference { get => JSRef!.Get<Union<Array<NodeUniformsGroup>, BindGroup>>("bindingsReference"); set => JSRef!.Set("bindingsReference", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// index: number;
        /// </summary>
        public float Index { get => JSRef!.Get<float>("index"); set => JSRef!.Set("index", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        #endregion

        #region Methods

        #endregion
    }
}
