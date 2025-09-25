
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Uniform<TValue> : Uniform
    {
        /// <inheritdoc/>
        public Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        /// <summary>
        /// constructor(name: string, value: TValue);
        /// </summary>
        public Uniform(string name, TValue value) : base(JS.New("THREE.Uniform", name, value)) { }
        /// <summary>
        /// value: TValue;
        /// </summary>
        public TValue Value { get => JSRef!.Get<TValue>("value"); set => JSRef!.Set("value", value); }

        /// <summary>
        /// setValue(value: TValue): void;
        /// </summary>
        public void SetValue(TValue value)
        {
            JSRef!.CallVoid("setValue", value);
        }
        /// <summary>
        /// getValue(): TValue;
        /// </summary>
        public TValue GetValue()
        {
            return JSRef!.Call<TValue>("getValue");
        }
    }
    public class Uniform : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Uniform(IJSInProcessObjectReference _ref) : base(_ref) { }
        #endregion

        #region Properties
        /// <summary>
        /// boundary: number;
        /// </summary>
        public float Boundary { get => JSRef!.Get<float>("boundary"); set => JSRef!.Set("boundary", value); }
        /// <summary>
        /// itemSize: number;
        /// </summary>
        public float ItemSize { get => JSRef!.Get<float>("itemSize"); set => JSRef!.Set("itemSize", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// offset: number;
        /// </summary>
        public float Offset { get => JSRef!.Get<float>("offset"); set => JSRef!.Set("offset", value); }
        #endregion
    }
}
