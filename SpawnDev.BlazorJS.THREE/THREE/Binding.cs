
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Binding : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Binding(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name?: string);
        /// </summary>
        public Binding(string name) : base(JS.New("THREE.Binding", name)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// visibility: number;
        /// </summary>
        public float Visibility { get => JSRef!.Get<float>("visibility"); set => JSRef!.Set("visibility", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setVisibility(visibility: number): void;
        /// </summary>
        public void SetVisibility(float visibility)
        {
            JSRef!.CallVoid("setVisibility", visibility);
        }
        /// <summary>
        /// clone(): Binding & this;
        /// </summary>
        public object Clone()
        {
            return JSRef!.Call<object>("clone");
        }
        #endregion
    }
}
