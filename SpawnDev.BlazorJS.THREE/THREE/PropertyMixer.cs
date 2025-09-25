
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PropertyMixer : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public PropertyMixer(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(binding: PropertyBinding, typeName: string, valueSize: number);
        /// </summary>
        public PropertyMixer(PropertyBinding binding, string typeName, float valueSize) : base(JS.New("THREE.PropertyMixer", binding, typeName, valueSize)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// binding: PropertyBinding;
        /// </summary>
        public PropertyBinding Binding { get => JSRef!.Get<PropertyBinding>("binding"); set => JSRef!.Set("binding", value); }
        /// <summary>
        /// cumulativeWeight: number;
        /// </summary>
        public float CumulativeWeight { get => JSRef!.Get<float>("cumulativeWeight"); set => JSRef!.Set("cumulativeWeight", value); }
        /// <summary>
        /// cumulativeWeightAdditive: number;
        /// </summary>
        public float CumulativeWeightAdditive { get => JSRef!.Get<float>("cumulativeWeightAdditive"); set => JSRef!.Set("cumulativeWeightAdditive", value); }
        /// <summary>
        /// referenceCount: number;
        /// </summary>
        public float ReferenceCount { get => JSRef!.Get<float>("referenceCount"); set => JSRef!.Set("referenceCount", value); }
        /// <summary>
        /// useCount: number;
        /// </summary>
        public float UseCount { get => JSRef!.Get<float>("useCount"); set => JSRef!.Set("useCount", value); }
        /// <summary>
        /// valueSize: number;
        /// </summary>
        public float ValueSize { get => JSRef!.Get<float>("valueSize"); set => JSRef!.Set("valueSize", value); }
        #endregion

        #region Methods
        /// <summary>
        /// saveOriginalState(): void;
        /// </summary>
        public void SaveOriginalState()
        {
            JSRef!.CallVoid("saveOriginalState");
        }
        /// <summary>
        /// restoreOriginalState(): void;
        /// </summary>
        public void RestoreOriginalState()
        {
            JSRef!.CallVoid("restoreOriginalState");
        }
        /// <summary>
        /// apply(accuIndex: number): void;
        /// </summary>
        public void Apply(float accuIndex)
        {
            JSRef!.CallVoid("apply", accuIndex);
        }
        /// <summary>
        /// accumulateAdditive(weight: number): void;
        /// </summary>
        public void AccumulateAdditive(float weight)
        {
            JSRef!.CallVoid("accumulateAdditive", weight);
        }
        /// <summary>
        /// accumulate(accuIndex: number, weight: number): void;
        /// </summary>
        public void Accumulate(float accuIndex, float weight)
        {
            JSRef!.CallVoid("accumulate", accuIndex, weight);
        }
        #endregion
    }
}
