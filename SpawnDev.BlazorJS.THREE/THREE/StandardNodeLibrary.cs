
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StandardNodeLibrary : NodeLibrary
    {
        #region Constructors
        /// <inheritdoc/>
        public StandardNodeLibrary(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public StandardNodeLibrary() : base(JS.New("THREE.StandardNodeLibrary")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
