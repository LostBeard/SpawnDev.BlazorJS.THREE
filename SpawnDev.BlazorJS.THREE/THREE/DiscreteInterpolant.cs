
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class DiscreteInterpolant : Interpolant
    {
        #region Constructors
        /// <inheritdoc/>
        public DiscreteInterpolant(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameterPositions: any, samplesValues: any, sampleSize: number, resultBuffer?: any);
        /// </summary>
        public DiscreteInterpolant(object parameterPositions, object samplesValues, float sampleSize, object resultBuffer) : base(JS.New("THREE.DiscreteInterpolant", parameterPositions, samplesValues, sampleSize, resultBuffer)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// interpolate_(i1: number, t0: number, t: number, t1: number): any;
        /// </summary>
        public object Interpolate_(float i1, float t0, float t, float t1)
        {
            return JSRef!.Call<object>("interpolate_", i1, t0, t, t1);
        }
        #endregion
    }
}
