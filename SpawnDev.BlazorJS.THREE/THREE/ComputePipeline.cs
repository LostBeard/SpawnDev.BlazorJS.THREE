
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ComputePipeline : Pipeline
    {
        #region Constructors
        /// <inheritdoc/>
        public ComputePipeline(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(cacheKey: string, computeProgram: ProgrammableStage);
        /// </summary>
        public ComputePipeline(string cacheKey, ProgrammableStage computeProgram) : base(JS.New("THREE.ComputePipeline", cacheKey, computeProgram)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// computeProgram: ProgrammableStage;
        /// </summary>
        public ProgrammableStage ComputeProgram { get => JSRef!.Get<ProgrammableStage>("computeProgram"); set => JSRef!.Set("computeProgram", value); }
        /// <summary>
        /// readonly isComputePipeline: true;
        /// </summary>
        public bool IsComputePipeline { get => JSRef!.Get<bool>("isComputePipeline"); }
        #endregion

        #region Methods

        #endregion
    }
}
