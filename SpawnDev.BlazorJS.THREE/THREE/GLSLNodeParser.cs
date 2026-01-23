using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    public class GLSLNodeParser : NodeParser
    {
        #region Constructors
        /// <inheritdoc/>
        public GLSLNodeParser(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// parseFunction(source: string): GLSLNodeFunction;
        /// </summary>
        public GLSLNodeFunction ParseFunction(string source)
        {
            return JSRef!.Call<GLSLNodeFunction>("parseFunction", source);
        }
        #endregion
    }
}
