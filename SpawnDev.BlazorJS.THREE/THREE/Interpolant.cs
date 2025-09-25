
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Interpolant : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Interpolant(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(parameterPositions: any, sampleValues: any, sampleSize: number, resultBuffer?: any);
        /// </summary>
        public Interpolant(object parameterPositions, object sampleValues, float sampleSize, object resultBuffer) : base(JS.New("THREE.Interpolant", parameterPositions, sampleValues, sampleSize, resultBuffer)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// parameterPositions: any;
        /// </summary>
        public object ParameterPositions { get => JSRef!.Get<object>("parameterPositions"); set => JSRef!.Set("parameterPositions", value); }
        /// <summary>
        /// resultBuffer: any;
        /// </summary>
        public object ResultBuffer { get => JSRef!.Get<object>("resultBuffer"); set => JSRef!.Set("resultBuffer", value); }
        /// <summary>
        /// sampleValues: any;
        /// </summary>
        public object SampleValues { get => JSRef!.Get<object>("sampleValues"); set => JSRef!.Set("sampleValues", value); }
        /// <summary>
        /// valueSize: number;
        /// </summary>
        public float ValueSize { get => JSRef!.Get<float>("valueSize"); set => JSRef!.Set("valueSize", value); }
        #endregion

        #region Methods
        /// <summary>
        /// evaluate(time: number): any;
        /// </summary>
        public object Evaluate(float time)
        {
            return JSRef!.Call<object>("evaluate", time);
        }
        #endregion
    }
}
