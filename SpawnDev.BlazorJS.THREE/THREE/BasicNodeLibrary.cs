
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BasicNodeLibrary : NodeLibrary
    {
        #region Constructors
        /// <inheritdoc/>
        public BasicNodeLibrary(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public BasicNodeLibrary() : base(JS.New("THREE.BasicNodeLibrary")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
