
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SceneData
    {
        #region Properties
        /// <summary>
        /// background?: Color | Texture | CubeTexture | undefined;
        /// </summary>
        Union<Color, Texture, CubeTexture>? Background { get; set; }
        /// <summary>
        /// backgroundNode?: ShaderNodeObject<Node> | undefined;
        /// </summary>
        ShaderNodeObject<Node>? BackgroundNode { get; set; }
        /// <summary>
        /// environment?: Texture | undefined;
        /// </summary>
        Texture? Environment { get; set; }
        /// <summary>
        /// environmentNode?: ShaderNodeObject<Node> | undefined;
        /// </summary>
        ShaderNodeObject<Node>? EnvironmentNode { get; set; }
        /// <summary>
        /// fog?: Fog | FogExp2 | undefined;
        /// </summary>
        Union<Fog, FogExp2>? Fog { get; set; }
        /// <summary>
        /// fogNode?: ShaderNodeObject<Node> | undefined;
        /// </summary>
        ShaderNodeObject<Node>? FogNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
