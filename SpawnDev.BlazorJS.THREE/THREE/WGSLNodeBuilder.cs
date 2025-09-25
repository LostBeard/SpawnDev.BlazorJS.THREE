
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WGSLNodeBuilder : NodeBuilder
    {
        #region Constructors
        /// <inheritdoc/>
        public WGSLNodeBuilder(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// builtins: { [key in BuiltinStage]: Map<string, BuiltinType> };
        /// </summary>
        public object Builtins { get => JSRef!.Get<object>("builtins"); set => JSRef!.Set("builtins", value); }
        /// <summary>
        /// uniformGroups: { [key in NodeShaderStage]: NodeUniformsGroup };
        /// </summary>
        public object UniformGroups { get => JSRef!.Get<object>("uniformGroups"); set => JSRef!.Set("uniformGroups", value); }
        #endregion

        #region Methods
        /// <summary>
        /// isUnfilterable(texture: Texture): boolean;
        /// </summary>
        public bool IsUnfilterable(Texture texture)
        {
            return JSRef!.Call<bool>("isUnfilterable", texture);
        }
        /// <summary>
        /// getVertexIndex(): string;
        /// </summary>
        public string GetVertexIndex()
        {
            return JSRef!.Call<string>("getVertexIndex");
        }
        /// <summary>
        /// getVaryings(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetVaryings(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getVaryings", shaderStage);
        }
        /// <summary>
        /// getVars(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetVars(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getVars", shaderStage);
        }
        /// <summary>
        /// getVar(type: string, name: string): string;
        /// </summary>
        public string GetVar(string type, string name)
        {
            return JSRef!.Call<string>("getVar", type, name);
        }
        /// <summary>
        /// getUniforms(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetUniforms(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getUniforms", shaderStage);
        }
        /// <summary>
        /// getStructs(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetStructs(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getStructs", shaderStage);
        }
        /// <summary>
        /// getStructMembers(struct: StructTypeNode): string;
        /// </summary>
        public string GetStructMembers(StructTypeNode structData)
        {
            return JSRef!.Call<string>("getStructMembers", structData);
        }
        /// <summary>
        /// getPropertyName<TValue>(node: NodeVar | NodeUniform<TValue>, shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetPropertyName<TValue>(Union<NodeVar, NodeUniform<TValue>> node, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getPropertyName", node, shaderStage);
        }
        /// <summary>
        /// getOutputStructName(): string;
        /// </summary>
        public string GetOutputStructName()
        {
            return JSRef!.Call<string>("getOutputStructName");
        }
        /// <summary>
        /// getMethod(method: string, output?: string | null): string;
        /// </summary>
        public string GetMethod(string method, string output)
        {
            return JSRef!.Call<string>("getMethod", method, output);
        }
        /// <summary>
        /// getInstanceIndex(): string;
        /// </summary>
        public string GetInstanceIndex()
        {
            return JSRef!.Call<string>("getInstanceIndex");
        }
        /// <summary>
        /// getFunctionOperator(op: string): string | null;
        /// </summary>
        public string GetFunctionOperator(string op)
        {
            return JSRef!.Call<string>("getFunctionOperator", op);
        }
        /// <summary>
        /// getFrontFacing(): string;
        /// </summary>
        public string GetFrontFacing()
        {
            return JSRef!.Call<string>("getFrontFacing");
        }
        /// <summary>
        /// getFragDepth(): string;
        /// </summary>
        public string GetFragDepth()
        {
            return JSRef!.Call<string>("getFragDepth");
        }
        /// <summary>
        /// getFragCoord(): string;
        /// </summary>
        public string GetFragCoord()
        {
            return JSRef!.Call<string>("getFragCoord");
        }
        /// <summary>
        /// getDrawIndex(): null;
        /// </summary>
        public object GetDrawIndex()
        {
            return JSRef!.Call<object>("getDrawIndex");
        }
        /// <summary>
        /// getBuiltins(shaderStage: BuiltinStage): string;
        /// </summary>
        public string GetBuiltins(BuiltinStage shaderStage)
        {
            return JSRef!.Call<string>("getBuiltins", shaderStage);
        }
        /// <summary>
        /// getBuiltin(name: string, property: string, type: string, shaderStage: BuiltinStage): string;
        /// </summary>
        public string GetBuiltin(string name, string property, string type, BuiltinStage shaderStage)
        {
            return JSRef!.Call<string>("getBuiltin", name, property, type, shaderStage);
        }
        /// <summary>
        /// getAttributes(shaderStage: NodeShaderStage): string;
        /// </summary>
        public string GetAttributes(NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("getAttributes", shaderStage);
        }
        /// <summary>
        /// generateTextureStore(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvIndexSnippet: string,
        ///         depthSnippet: string | null,
        ///         valueSnippet: string,
        ///     ): string;
        /// </summary>
        public string GenerateTextureStore(Texture texture, string textureProperty, string uvIndexSnippet, string depthSnippet, string valueSnippet)
        {
            return JSRef!.Call<string>("generateTextureStore", texture, textureProperty, uvIndexSnippet, depthSnippet, valueSnippet);
        }
        /// <summary>
        /// generateTextureLod(texture: Texture, textureProperty: string, uvSnippet: string, levelSnippet: string): string;
        /// </summary>
        public string GenerateTextureLod(Texture texture, string textureProperty, string uvSnippet, string levelSnippet)
        {
            return JSRef!.Call<string>("generateTextureLod", texture, textureProperty, uvSnippet, levelSnippet);
        }
        /// <summary>
        /// generateTextureLoad(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvIndexSnippet: string,
        ///         depthSnippet: string | null,
        ///         shaderStage: NodeShaderStage,
        ///     ): string;
        /// </summary>
        public string GenerateTextureLoad(Texture texture, string textureProperty, string uvIndexSnippet, string depthSnippet, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("generateTextureLoad", texture, textureProperty, uvIndexSnippet, depthSnippet, shaderStage);
        }
        /// <summary>
        /// generateTextureLevel(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvSnippet: string,
        ///         levelSnippet: string,
        ///         depthSnippet: string | null,
        ///         shaderStage: NodeShaderStage,
        ///     ): string;
        /// </summary>
        public string GenerateTextureLevel(Texture texture, string textureProperty, string uvSnippet, string levelSnippet, string depthSnippet, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("generateTextureLevel", texture, textureProperty, uvSnippet, levelSnippet, depthSnippet, shaderStage);
        }
        /// <summary>
        /// generateTextureGrad(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvSnippet: string,
        ///         gradSnippet: string[],
        ///         depthSnippet: string | null,
        ///         shaderStage: NodeShaderStage,
        ///     ): string;
        /// </summary>
        public string GenerateTextureGrad(Texture texture, string textureProperty, string uvSnippet, Array<string> gradSnippet, string depthSnippet, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("generateTextureGrad", texture, textureProperty, uvSnippet, gradSnippet, depthSnippet, shaderStage);
        }
        /// <summary>
        /// generateTextureCompare(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvSnippet: string,
        ///         compareSnippet: String,
        ///         shaderStage: NodeShaderStage,
        ///     ): string;
        /// </summary>
        public string GenerateTextureCompare(Texture texture, string textureProperty, string uvSnippet, string compareSnippet, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("generateTextureCompare", texture, textureProperty, uvSnippet, compareSnippet, shaderStage);
        }
        /// <summary>
        /// generateTexture(
        ///         texture: Texture,
        ///         textureProperty: string,
        ///         uvSnippet: string,
        ///         depthSnippet: string | null,
        ///         shaderStage: NodeShaderStage,
        ///     ): string;
        /// </summary>
        public string GenerateTexture(Texture texture, string textureProperty, string uvSnippet, string depthSnippet, NodeShaderStage shaderStage)
        {
            return JSRef!.Call<string>("generateTexture", texture, textureProperty, uvSnippet, depthSnippet, shaderStage);
        }
        /// <summary>
        /// buildFunctionCode(shaderNode: ShaderNode): string;
        /// </summary>
        public string BuildFunctionCode(ShaderNode shaderNode)
        {
            return JSRef!.Call<string>("buildFunctionCode", shaderNode);
        }
        /// <summary>
        /// buildCode(): void;
        /// </summary>
        public void BuildCode()
        {
            JSRef!.CallVoid("buildCode");
        }
        #endregion
    }
}
