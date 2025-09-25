
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class RenderPipeline : Pipeline
    {
        #region Constructors
        /// <inheritdoc/>
        public RenderPipeline(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(cacheKey: string, vertexProgram: ProgrammableStage, fragmentProgram: ProgrammableStage);
        /// </summary>
        public RenderPipeline(string cacheKey, ProgrammableStage vertexProgram, ProgrammableStage fragmentProgram) : base(JS.New("THREE.RenderPipeline", cacheKey, vertexProgram, fragmentProgram)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// fragmentProgram: ProgrammableStage;
        /// </summary>
        public ProgrammableStage FragmentProgram { get => JSRef!.Get<ProgrammableStage>("fragmentProgram"); set => JSRef!.Set("fragmentProgram", value); }
        /// <summary>
        /// vertexProgram: ProgrammableStage;
        /// </summary>
        public ProgrammableStage VertexProgram { get => JSRef!.Get<ProgrammableStage>("vertexProgram"); set => JSRef!.Set("vertexProgram", value); }
        #endregion

        #region Methods

        #endregion
    }
}
