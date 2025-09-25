
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BoxHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public BoxHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(object: Object3D, color?: ColorRepresentation);
        /// </summary>
        public BoxHelper(Object3D obj, ColorRepresentation color) : base(JS.New("THREE.BoxHelper", obj, color)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override readonly type: string | "BoxHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// update(object?: Object3D): void;
        /// </summary>
        public void Update(Object3D obj)
        {
            JSRef!.CallVoid("update", obj);
        }
        /// <summary>
        /// setFromObject(object: Object3D): this;
        /// </summary>
        public BoxHelper SetFromObject(Object3D obj)
        {
            return JSRef!.Call<BoxHelper>("setFromObject", obj);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
