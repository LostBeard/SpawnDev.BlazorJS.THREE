
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Geometries : DataMap
    {
        #region Constructors
        /// <inheritdoc/>
        public Geometries(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(attributes: Attributes, info: Info);
        /// </summary>
        public Geometries(Attributes attributes, Info info) : base(JS.New("THREE.Geometries", attributes, info)) { }
        
        #endregion

        #region Properties
        ///// <summary>
        ///// attributeCall: WeakMap<BufferAttribute | InterleavedBufferAttribute | InterleavedBuffer, number>;
        ///// </summary>
        //public WeakMap<Union<BufferAttribute, InterleavedBufferAttribute, InterleavedBuffer>, float> AttributeCall { get => JSRef!.Get<WeakMap<Union<BufferAttribute, InterleavedBufferAttribute, InterleavedBuffer>, float>>("attributeCall"); set => JSRef!.Set("attributeCall", value); }
        /// <summary>
        /// attributes: Attributes;
        /// </summary>
        public Attributes Attributes { get => JSRef!.Get<Attributes>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        ///// <summary>
        ///// wireframes: WeakMap<BufferGeometry, BufferAttribute>;
        ///// </summary>
        //public WeakMap<BufferGeometry, BufferAttribute> Wireframes { get => JSRef!.Get<WeakMap<BufferGeometry, BufferAttribute>>("wireframes"); set => JSRef!.Set("wireframes", value); }
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
        /// updateAttributes(renderObject: RenderObject): void;
        /// </summary>
        public void UpdateAttributes(RenderObject renderObject)
        {
            JSRef!.CallVoid("updateAttributes", renderObject);
        }
        /// <summary>
        /// updateAttribute(attribute: BufferAttribute | InterleavedBufferAttribute, type: AttributeType): void;
        /// </summary>
        public void UpdateAttribute(Union<BufferAttribute, InterleavedBufferAttribute> attribute, AttributeType type)
        {
            JSRef!.CallVoid("updateAttribute", attribute, type);
        }
        /// <summary>
        /// initGeometry(renderObject: RenderObject): void;
        /// </summary>
        public void InitGeometry(RenderObject renderObject)
        {
            JSRef!.CallVoid("initGeometry", renderObject);
        }
        /// <summary>
        /// import(
        /// </summary>
        public object Import()
        {
            return JSRef!.Call<object>("import");
        }
        /// <summary>
        /// has(renderObject: RenderObject | BufferGeometry): boolean;
        /// </summary>
        public bool Has(Union<RenderObject, BufferGeometry> renderObject)
        {
            return JSRef!.Call<bool>("has", renderObject);
        }
        /// <summary>
        /// getIndirect(renderObject: RenderObject):
        /// </summary>
        public object GetIndirect(RenderObject renderObject)
        {
            return JSRef!.Call<object>("getIndirect", renderObject);
        }
        #endregion
    }
}
