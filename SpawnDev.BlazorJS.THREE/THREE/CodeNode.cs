
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class CodeNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public CodeNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(code?: string, includes?: CodeNodeInclude[], language?: string);
        /// </summary>
        public CodeNode(string code, Array<CodeNodeInclude> includes, string language) : base(JS.New("THREE.CodeNode", code, includes, language)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// code: string;
        /// </summary>
        public string Code { get => JSRef!.Get<string>("code"); set => JSRef!.Set("code", value); }
        /// <summary>
        /// isCodeNode: true;
        /// </summary>
        public bool IsCodeNode { get => JSRef!.Get<bool>("isCodeNode"); set => JSRef!.Set("isCodeNode", value); }
        /// <summary>
        /// language: string;
        /// </summary>
        public string Language { get => JSRef!.Get<string>("language"); set => JSRef!.Set("language", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setIncludes(includes: CodeNodeInclude[]): this;
        /// </summary>
        public CodeNode SetIncludes(Array<CodeNodeInclude> includes)
        {
            return JSRef!.Call<CodeNode>("setIncludes", includes);
        }
        /// <summary>
        /// getIncludes(builder: NodeBuilder): CodeNodeInclude[];
        /// </summary>
        public Array<CodeNodeInclude> GetIncludes(NodeBuilder builder)
        {
            return JSRef!.Call<Array<CodeNodeInclude>>("getIncludes", builder);
        }
        #endregion
    }
}
