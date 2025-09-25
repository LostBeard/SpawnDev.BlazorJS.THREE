
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshPhongNodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// shininessNode: Node | null;
        /// </summary>
        Node? ShininessNode { get; set; }
        /// <summary>
        /// specularNode: Node | null;
        /// </summary>
        Node? SpecularNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
