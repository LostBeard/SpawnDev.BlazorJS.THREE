
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// alphaTestNode: Node | null;
        /// </summary>
        Node? AlphaTestNode { get; set; }
        /// <summary>
        /// aoNode: Node | null;
        /// </summary>
        Node? AoNode { get; set; }
        /// <summary>
        /// backdropAlphaNode: Node | null;
        /// </summary>
        Node? BackdropAlphaNode { get; set; }
        /// <summary>
        /// backdropNode: Node | null;
        /// </summary>
        Node? BackdropNode { get; set; }
        /// <summary>
        /// castShadowNode: Node | null;
        /// </summary>
        Node? CastShadowNode { get; set; }
        /// <summary>
        /// castShadowPositionNode: Node | null;
        /// </summary>
        Node? CastShadowPositionNode { get; set; }
        /// <summary>
        /// colorNode: Node | null;
        /// </summary>
        Node? ColorNode { get; set; }
        /// <summary>
        /// depthNode: Node | null;
        /// </summary>
        Node? DepthNode { get; set; }
        /// <summary>
        /// envNode: Node | null;
        /// </summary>
        Node? EnvNode { get; set; }
        /// <summary>
        /// fog: boolean;
        /// </summary>
        bool? Fog { get; set; }
        /// <summary>
        /// fragmentNode: Node | null;
        /// </summary>
        Node? FragmentNode { get; set; }
        /// <summary>
        /// geometryNode: (() => Node) | null;
        /// </summary>
        Callback? GeometryNode { get; set; }
        /// <summary>
        /// hardwareClipping: boolean;
        /// </summary>
        bool? HardwareClipping { get; set; }
        /// <summary>
        /// lights: boolean;
        /// </summary>
        bool? Lights { get; set; }
        /// <summary>
        /// lightsNode: LightsNode | null;
        /// </summary>
        LightsNode? LightsNode { get; set; }
        /// <summary>
        /// maskNode: Node | null;
        /// </summary>
        Node? MaskNode { get; set; }
        /// <summary>
        /// mrtNode: MRTNode | null;
        /// </summary>
        MRTNode? MrtNode { get; set; }
        /// <summary>
        /// normalNode: Node | null;
        /// </summary>
        Node? NormalNode { get; set; }
        /// <summary>
        /// opacityNode: Node | null;
        /// </summary>
        Node? OpacityNode { get; set; }
        /// <summary>
        /// outputNode: Node | null;
        /// </summary>
        Node? OutputNode { get; set; }
        /// <summary>
        /// positionNode: Node | null;
        /// </summary>
        Node? PositionNode { get; set; }
        /// <summary>
        /// receivedShadowNode: (() => Node) | null;
        /// </summary>
        Callback? ReceivedShadowNode { get; set; }
        /// <summary>
        /// receivedShadowPositionNode: Node | null;
        /// </summary>
        Node? ReceivedShadowPositionNode { get; set; }
        /// <summary>
        /// vertexNode: Node | null;
        /// </summary>
        Node? VertexNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
