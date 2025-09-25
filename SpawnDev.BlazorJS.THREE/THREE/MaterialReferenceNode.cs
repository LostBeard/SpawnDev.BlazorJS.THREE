
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MaterialReferenceNode : ReferenceNode<Material>
    {
        #region Constructors
        /// <inheritdoc/>
        public MaterialReferenceNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(property: string, inputType: string, material?: Material | null);
        /// </summary>
        public MaterialReferenceNode(string property, string inputType, Material material) : base(JS.New("THREE.MaterialReferenceNode", property, inputType, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isMaterialReferenceNode: true;
        /// </summary>
        public bool IsMaterialReferenceNode { get => JSRef!.Get<bool>("isMaterialReferenceNode"); }
        #endregion

        #region Methods

        #endregion
    }
}
