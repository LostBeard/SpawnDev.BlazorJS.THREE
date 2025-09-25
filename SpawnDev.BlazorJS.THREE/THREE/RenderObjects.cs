
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderObjects : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderObjects(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// bindings: Bindings;
        /// </summary>
        public Bindings Bindings { get => JSRef!.Get<Bindings>("bindings"); set => JSRef!.Set("bindings", value); }
        /// <summary>
        /// chainMaps: {
                ///         [passId: string]: ChainMap<readonly[Object3D, Material, RenderContext, LightsNode], RenderObject>;
        /// </summary>
        public JSObject ChainMaps { get => JSRef!.Get<JSObject>("chainMaps"); set => JSRef!.Set("chainMaps", value); }
        /// <summary>
        /// geometries: Geometries;
        /// </summary>
        public Geometries Geometries { get => JSRef!.Get<Geometries>("geometries"); set => JSRef!.Set("geometries", value); }
        /// <summary>
        /// info: Info;
        /// </summary>
        public Info Info { get => JSRef!.Get<Info>("info"); set => JSRef!.Set("info", value); }
        /// <summary>
        /// nodes: Nodes;
        /// </summary>
        public Nodes Nodes { get => JSRef!.Get<Nodes>("nodes"); set => JSRef!.Set("nodes", value); }
        /// <summary>
        /// pipelines: Pipelines;
        /// </summary>
        public Pipelines Pipelines { get => JSRef!.Get<Pipelines>("pipelines"); set => JSRef!.Set("pipelines", value); }
        /// <summary>
        /// renderer: Renderer;
        /// </summary>
        public Renderer Renderer { get => JSRef!.Get<Renderer>("renderer"); set => JSRef!.Set("renderer", value); }
        #endregion

        #region Methods

        #endregion
    }
}
