
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshSSSNodeMaterialNodeProperties : MeshPhysicalNodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// thicknessAmbientNode: InputNode<number>;
        /// </summary>
        InputNode<float>? ThicknessAmbientNode { get; set; }
        /// <summary>
        /// thicknessAttenuationNode: InputNode<number>;
        /// </summary>
        InputNode<float>? ThicknessAttenuationNode { get; set; }
        /// <summary>
        /// thicknessColorNode: Node | null;
        /// </summary>
        Node? ThicknessColorNode { get; set; }
        /// <summary>
        /// thicknessDistortionNode: InputNode<number>;
        /// </summary>
        InputNode<float>? ThicknessDistortionNode { get; set; }
        /// <summary>
        /// thicknessPowerNode: InputNode<number>;
        /// </summary>
        InputNode<float>? ThicknessPowerNode { get; set; }
        /// <summary>
        /// thicknessScaleNode: InputNode<number>;
        /// </summary>
        InputNode<float>? ThicknessScaleNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
