
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class FrustumArray : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public FrustumArray(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public FrustumArray() : base(JS.New("THREE.FrustumArray")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// coordinateSystem: CoordinateSystem;
        /// </summary>
        public CoordinateSystem CoordinateSystem { get => JSRef!.Get<CoordinateSystem>("coordinateSystem"); set => JSRef!.Set("coordinateSystem", value); }
        #endregion

        #region Methods
        /// <summary>
        /// intersectsSprite(sprite: Sprite, cameraArray: ArrayCamera): boolean;
        /// </summary>
        public bool IntersectsSprite(Sprite sprite, ArrayCamera cameraArray)
        {
            return JSRef!.Call<bool>("intersectsSprite", sprite, cameraArray);
        }
        /// <summary>
        /// intersectsSprite(sphere: Sphere, cameraArray: ArrayCamera): boolean;
        /// </summary>
        public bool IntersectsSprite(Sphere sphere, ArrayCamera cameraArray)
        {
            return JSRef!.Call<bool>("intersectsSprite", sphere, cameraArray);
        }
        /// <summary>
        /// intersectsObject(object: Object3D, cameraArray: ArrayCamera): boolean;
        /// </summary>
        public bool IntersectsObject(Object3D obj, ArrayCamera cameraArray)
        {
            return JSRef!.Call<bool>("intersectsObject", obj, cameraArray);
        }
        /// <summary>
        /// intersectsBox(box: Box3, cameraArray: ArrayCamera): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box, ArrayCamera cameraArray)
        {
            return JSRef!.Call<bool>("intersectsBox", box, cameraArray);
        }
        /// <summary>
        /// containsPoint(point: Vector3, cameraArray: ArrayCamera): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point, ArrayCamera cameraArray)
        {
            return JSRef!.Call<bool>("containsPoint", point, cameraArray);
        }
        /// <summary>
        /// clone(): FrustumArray;
        /// </summary>
        public FrustumArray Clone()
        {
            return JSRef!.Call<FrustumArray>("clone");
        }
        #endregion
    }
}
