
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstancedMeshNode<TGeometry, TMaterial> : InstanceNode
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedMeshNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(instanceMesh: InstancedMesh);
        /// </summary>
        public InstancedMeshNode(InstancedMesh<TGeometry, TMaterial> instanceMesh) : base(JS.New("THREE.InstancedMeshNode", instanceMesh)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
