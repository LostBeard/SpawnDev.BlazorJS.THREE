
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WGSLNodeFunction : NodeFunction
    {
        #region Constructors
        /// <inheritdoc/>
        public WGSLNodeFunction(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(source: string);
        /// </summary>
        public WGSLNodeFunction(string source) : base(JS.New("THREE.WGSLNodeFunction", source)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// getCode(name?: string): string;
        /// </summary>
        public string GetCode(string name)
        {
            return JSRef!.Call<string>("getCode", name);
        }
        #endregion
    }
}
