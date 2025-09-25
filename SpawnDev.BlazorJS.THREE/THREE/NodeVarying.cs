
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeVarying : NodeVar
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeVarying(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         name: string,
        ///         type: string,
        ///         interpolationType?: InterpolationSamplingType | null,
        ///         interpolationSampling?: InterpolationSamplingMode | null,
        ///     );
        /// </summary>
        public NodeVarying(string name, string type, InterpolationSamplingType interpolationType, InterpolationSamplingMode interpolationSampling) : base(JS.New("THREE.NodeVarying", name, type, interpolationType, interpolationSampling)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// interpolationSampling: InterpolationSamplingMode | null;
        /// </summary>
        public InterpolationSamplingMode InterpolationSampling { get => JSRef!.Get<InterpolationSamplingMode>("interpolationSampling"); set => JSRef!.Set("interpolationSampling", value); }
        /// <summary>
        /// interpolationType: InterpolationSamplingType | null;
        /// </summary>
        public InterpolationSamplingType InterpolationType { get => JSRef!.Get<InterpolationSamplingType>("interpolationType"); set => JSRef!.Set("interpolationType", value); }
        /// <summary>
        /// readonly isNodeVarying: true;
        /// </summary>
        public bool IsNodeVarying { get => JSRef!.Get<bool>("isNodeVarying"); }
        /// <summary>
        /// needsInterpolation: boolean;
        /// </summary>
        public bool NeedsInterpolation { get => JSRef!.Get<bool>("needsInterpolation"); set => JSRef!.Set("needsInterpolation", value); }
        #endregion

        #region Methods

        #endregion
    }
}
