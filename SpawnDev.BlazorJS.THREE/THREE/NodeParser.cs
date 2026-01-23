using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeParser : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeParser(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// abstract parseFunction(source: string): NodeFunction;
        /// </summary>
        public NodeFunction ParseFunction(string source)
        {
            return JSRef!.Call<NodeFunction>("parseFunction", source);
        }
        #endregion
    }
}
