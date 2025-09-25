
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeLibrary : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeLibrary(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public NodeLibrary() : base(JS.New("THREE.NodeLibrary")) { }
        
        #endregion

        #region Properties
        ///// <summary>
        ///// lightNodes: WeakMap<{
        //        ///         new(): Light;
        //        ///     }, {
        //        ///         new(light: Light): AnalyticLightNode<Light>;
        //        ///     }>;
        ///// </summary>
        //public WeakMap<object> LightNodes { get => JSRef!.Get<WeakMap<object>>("lightNodes"); set => JSRef!.Set("lightNodes", value); }
        /// <summary>
        /// materialNodes: Map<string, {
                ///         new(): NodeMaterial;
                ///     }>;
        /// </summary>
        public Map<string, object> MaterialNodes { get => JSRef!.Get<Map<string, object>>("materialNodes"); set => JSRef!.Set("materialNodes", value); }
        /// <summary>
        /// toneMappingNodes: Map<ToneMapping, (color: Node, exposure: Node) => ShaderNodeObject<Node>>;
        /// </summary>
        public Map<ToneMapping, Callback> ToneMappingNodes { get => JSRef!.Get<Map<ToneMapping, Callback>>("toneMappingNodes"); set => JSRef!.Set("toneMappingNodes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// getToneMappingFunction(toneMapping: ToneMapping): ((color: Node, exposure: Node) => ShaderNodeObject<Node>) | null;
        /// </summary>
        public Callback GetToneMappingFunction(ToneMapping toneMapping, Node color, Node exposure)
        {
            return JSRef!.Call<Callback>("getToneMappingFunction", toneMapping, color, exposure);
        }
        /// <summary>
        /// getMaterialNodeClass(materialType: string): (new() => NodeMaterial) | null;
        /// </summary>
        public Callback GetMaterialNodeClass(string materialType)
        {
            return JSRef!.Call<Callback>("getMaterialNodeClass", materialType);
        }
        ///// <summary>
        ///// getLightNodeClass(light: Light): (new(light: Light) => AnalyticLightNode<Light>) | null;
        ///// </summary>
        //public Callback GetLightNodeClass(Light light, Light light)
        //{
        //    return JSRef!.Call<Callback>("getLightNodeClass", light, light);
        //}
        /// <summary>
        /// fromMaterial(material: Material): Material | NodeMaterial | null;
        /// </summary>
        public Union<Material, NodeMaterial> FromMaterial(Material material)
        {
            return JSRef!.Call<Union<Material, NodeMaterial>>("fromMaterial", material);
        }
        /// <summary>
        /// addType<TNodeClass, TType>(nodeClass: TNodeClass, type: TType, library: Map<TType, TNodeClass>): void;
        /// </summary>
        public void AddType<TNodeClass, TType>(TNodeClass nodeClass, TType type, Map<TType, TNodeClass> library)
        {
            JSRef!.CallVoid("addType", nodeClass, type, library);
        }
        /// <summary>
        /// addToneMapping(
        ///         toneMappingNode: (color: Node, exposure: Node) => ShaderNodeObject<Node>,
        ///         toneMapping: ToneMapping,
        ///     ): void;
        /// </summary>
        public void AddToneMapping(Callback toneMappingNode, Node color, Node exposure, ToneMapping toneMapping)
        {
            JSRef!.CallVoid("addToneMapping", toneMappingNode, color, exposure, toneMapping);
        }
        /// <summary>
        /// addMaterial(materialNodeClass: {
        ///         new(): NodeMaterial;
        ///     }, materialClassType: string): void;
        /// </summary>
        public void AddMaterial(object materialNodeClass, string materialClassType)
        {
            JSRef!.CallVoid("addMaterial", materialNodeClass, materialClassType);
        }
        /// <summary>
        /// addLight<TLight extends Light>(lightNodeClass: {
        ///         new(light: TLight): AnalyticLightNode<TLight>;
        ///     }, lightClass: {
        ///         new(): TLight;
        ///     }): void;
        /// </summary>
        public void AddLight<TLight>(object lightNodeClass, TLight light, object lightClass)
        {
            JSRef!.CallVoid("addLight", lightNodeClass, light, lightClass);
        }
        /// <summary>
        /// addClass<TNodeClass, TBaseClass extends object>(
        ///         nodeClass: TNodeClass,
        ///         baseClass: TBaseClass,
        ///         library: WeakMap<TBaseClass, TNodeClass>,
        ///     ): void;
        /// </summary>
        public void AddClass<TNodeClass, TBaseClass>(TNodeClass nodeClass, TBaseClass baseClass, WeakMap<TBaseClass, TNodeClass> library)
        {
            JSRef!.CallVoid("addClass", nodeClass, baseClass, library);
        }
        #endregion
    }
}
