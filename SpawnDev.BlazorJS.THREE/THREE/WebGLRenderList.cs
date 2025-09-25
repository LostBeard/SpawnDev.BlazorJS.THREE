
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WebGLRenderList : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public WebGLRenderList(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(properties: WebGLProperties);
        /// </summary>
        public WebGLRenderList(WebGLProperties properties) : base(JS.New("THREE.WebGLRenderList", properties)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// opaque: RenderItem[];
        /// </summary>
        public Array<RenderItem> Opaque { get => JSRef!.Get<Array<RenderItem>>("opaque"); set => JSRef!.Set("opaque", value); }
        /// <summary>
        /// transmissive: RenderItem[];
        /// </summary>
        public Array<RenderItem> Transmissive { get => JSRef!.Get<Array<RenderItem>>("transmissive"); set => JSRef!.Set("transmissive", value); }
        /// <summary>
        /// transparent: RenderItem[];
        /// </summary>
        public Array<RenderItem> Transparent { get => JSRef!.Get<Array<RenderItem>>("transparent"); set => JSRef!.Set("transparent", value); }
        #endregion

        #region Methods
        /// <summary>
        /// unshift(
        ///         object: Object3D,
        ///         geometry: BufferGeometry | null,
        ///         material: Material,
        ///         groupOrder: number,
        ///         z: number,
        ///         group: Group | null,
        ///     ): void;
        /// </summary>
        public void Unshift(Object3D obj, BufferGeometry geometry, Material material, float groupOrder, float z, Group group)
        {
            JSRef!.CallVoid("unshift", obj, geometry, material, groupOrder, z, group);
        }
        /// <summary>
        /// sort(opaqueSort: (a: any, b: any) => number, transparentSort: (a: any, b: any) => number): void;
        /// </summary>
        public void Sort(Callback opaqueSort, Callback transparentSort)
        {
            JSRef!.CallVoid("sort", opaqueSort, transparentSort);
        }
        /// <summary>
        /// push(
        ///         object: Object3D,
        ///         geometry: BufferGeometry | null,
        ///         material: Material,
        ///         groupOrder: number,
        ///         z: number,
        ///         group: Group | null,
        ///     ): void;
        /// </summary>
        public void Push(Object3D obj, BufferGeometry geometry, Material material, float groupOrder, float z, Group group)
        {
            JSRef!.CallVoid("push", obj, geometry, material, groupOrder, z, group);
        }
        /// <summary>
        /// init(): void;
        /// </summary>
        public void Init()
        {
            JSRef!.CallVoid("init");
        }
        /// <summary>
        /// finish(): void;
        /// </summary>
        public void Finish()
        {
            JSRef!.CallVoid("finish");
        }
        #endregion
    }
}
