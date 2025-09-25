
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PassNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public PassNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: PassNodeScope, scene: Scene, camera: Camera, options?: RenderTargetOptions);
        /// </summary>
        public PassNode(PassNodeScope scope, Scene scene, Camera camera, RenderTargetOptions options) : base(JS.New("THREE.PassNode", scope, scene, camera, options)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// camera: Camera;
        /// </summary>
        public Camera Camera { get => JSRef!.Get<Camera>("camera"); set => JSRef!.Set("camera", value); }
        /// <summary>
        /// static COLOR: "color";
        /// </summary>
        public static string COLOR { get => JS.Get<string>("THREE.PassNode.COLOR"); set => JS.Set("THREE.PassNode.COLOR", value); }
        /// <summary>
        /// static DEPTH: "depth";
        /// </summary>
        public static string DEPTH { get => JS.Get<string>("THREE.PassNode.DEPTH"); set => JS.Set("THREE.PassNode.DEPTH", value); }
        /// <summary>
        /// readonly isPassNode: true;
        /// </summary>
        public bool IsPassNode { get => JSRef!.Get<bool>("isPassNode"); }
        /// <summary>
        /// renderTarget: RenderTarget;
        /// </summary>
        public RenderTarget RenderTarget { get => JSRef!.Get<RenderTarget>("renderTarget"); set => JSRef!.Set("renderTarget", value); }
        /// <summary>
        /// scene: Scene;
        /// </summary>
        public Scene Scene { get => JSRef!.Get<Scene>("scene"); set => JSRef!.Set("scene", value); }
        /// <summary>
        /// scope: PassNodeScope;
        /// </summary>
        public PassNodeScope Scope { get => JSRef!.Get<PassNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toggleTexture(name: string): void;
        /// </summary>
        public void ToggleTexture(string name)
        {
            JSRef!.CallVoid("toggleTexture", name);
        }
        /// <summary>
        /// setViewport(x: number, y: number, width: number, height: number): void;
        /// </summary>
        public void SetViewport(float x, float y, float width, float height)
        {
            JSRef!.CallVoid("setViewport", x, y, width, height);
        }
        /// <summary>
        /// setViewport(x: Vector4): void;
        /// </summary>
        public void SetViewport(Vector4 x)
        {
            JSRef!.CallVoid("setViewport", x);
        }
        /// <summary>
        /// setSize(width: number, height: number): void;
        /// </summary>
        public void SetSize(float width, float height)
        {
            JSRef!.CallVoid("setSize", width, height);
        }
        /// <summary>
        /// setScissor(x: number, y: number, width: number, height: number): void;
        /// </summary>
        public void SetScissor(float x, float y, float width, float height)
        {
            JSRef!.CallVoid("setScissor", x, y, width, height);
        }
        /// <summary>
        /// setScissor(x: Vector4): void;
        /// </summary>
        public void SetScissor(Vector4 x)
        {
            JSRef!.CallVoid("setScissor", x);
        }
        /// <summary>
        /// setResolution(resolution: number): this;
        /// </summary>
        public PassNode SetResolution(float resolution)
        {
            return JSRef!.Call<PassNode>("setResolution", resolution);
        }
        /// <summary>
        /// setPixelRatio(pixelRatio: number): void;
        /// </summary>
        public void SetPixelRatio(float pixelRatio)
        {
            JSRef!.CallVoid("setPixelRatio", pixelRatio);
        }
        /// <summary>
        /// setMRT(mrt: MRTNode | null): this;
        /// </summary>
        public PassNode SetMRT(MRTNode mrt)
        {
            return JSRef!.Call<PassNode>("setMRT", mrt);
        }
        /// <summary>
        /// setLayers(layers: Layers): this;
        /// </summary>
        public PassNode SetLayers(Layers layers)
        {
            return JSRef!.Call<PassNode>("setLayers", layers);
        }
        /// <summary>
        /// getViewZNode(name?: string): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetViewZNode(string name)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getViewZNode", name);
        }
        /// <summary>
        /// getTextureNode(name?: string): ShaderNodeObject<TextureNode>;
        /// </summary>
        public ShaderNodeObject<TextureNode> GetTextureNode(string name)
        {
            return JSRef!.Call<ShaderNodeObject<TextureNode>>("getTextureNode", name);
        }
        /// <summary>
        /// getTexture(name: string): Texture;
        /// </summary>
        public Texture GetTexture(string name)
        {
            return JSRef!.Call<Texture>("getTexture", name);
        }
        /// <summary>
        /// getResolution(): number;
        /// </summary>
        public float GetResolution()
        {
            return JSRef!.Call<float>("getResolution");
        }
        /// <summary>
        /// getPreviousTextureNode(name?: string): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetPreviousTextureNode(string name)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getPreviousTextureNode", name);
        }
        /// <summary>
        /// getPreviousTexture(name: string): Texture;
        /// </summary>
        public Texture GetPreviousTexture(string name)
        {
            return JSRef!.Call<Texture>("getPreviousTexture", name);
        }
        /// <summary>
        /// getMRT(): MRTNode | null;
        /// </summary>
        public MRTNode GetMRT()
        {
            return JSRef!.Call<MRTNode>("getMRT");
        }
        /// <summary>
        /// getLinearDepthNode(name?: string): ShaderNodeObject<Node>;
        /// </summary>
        public ShaderNodeObject<Node> GetLinearDepthNode(string name)
        {
            return JSRef!.Call<ShaderNodeObject<Node>>("getLinearDepthNode", name);
        }
        /// <summary>
        /// getLayers(): Layers;
        /// </summary>
        public Layers GetLayers()
        {
            return JSRef!.Call<Layers>("getLayers");
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// compileAsync(renderer: Renderer): Promise<void>;
        /// </summary>
        public Task CompileAsync(Renderer renderer)
        {
            return JSRef!.CallVoidAsync("compileAsync", renderer);
        }
        #endregion
    }
}
