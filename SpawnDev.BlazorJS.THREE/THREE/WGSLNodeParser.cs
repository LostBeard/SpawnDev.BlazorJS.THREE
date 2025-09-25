
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WGSLNodeParser : NodeParser
    {
        #region Constructors
        /// <inheritdoc/>
        public WGSLNodeParser(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// parseFunction(source: string): WGSLNodeFunction;
        /// </summary>
        public WGSLNodeFunction ParseFunction(string source)
        {
            return JSRef!.Call<WGSLNodeFunction>("parseFunction", source);
        }
        #endregion
    }
}
