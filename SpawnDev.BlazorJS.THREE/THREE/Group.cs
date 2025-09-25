
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Group : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Group(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Group() : base(JS.New("THREE.Group")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isGroup: true;
        /// </summary>
        public bool IsGroup { get => JSRef!.Get<bool>("isGroup"); }
        #endregion

        #region Methods

        #endregion
    }
}
