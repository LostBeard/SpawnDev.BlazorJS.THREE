
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Frustum : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Frustum(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(p0?: Plane, p1?: Plane, p2?: Plane, p3?: Plane, p4?: Plane, p5?: Plane);
        /// </summary>
        public Frustum(Plane p0, Plane p1, Plane p2, Plane p3, Plane p4, Plane p5) : base(JS.New("THREE.Frustum", p0, p1, p2, p3, p4, p5)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// planes: Plane[];
        /// </summary>
        public Array<Plane> Planes { get => JSRef!.Get<Array<Plane>>("planes"); set => JSRef!.Set("planes", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setFromProjectionMatrix(m: Matrix4, coordinateSystem?: CoordinateSystem, reversedDepth?: boolean): this;
        /// </summary>
        public Frustum SetFromProjectionMatrix(Matrix4 m, CoordinateSystem coordinateSystem, bool reversedDepth)
        {
            return JSRef!.Call<Frustum>("setFromProjectionMatrix", m, coordinateSystem, reversedDepth);
        }
        /// <summary>
        /// set(p0: Plane, p1: Plane, p2: Plane, p3: Plane, p4: Plane, p5: Plane): Frustum;
        /// </summary>
        public Frustum Set(Plane p0, Plane p1, Plane p2, Plane p3, Plane p4, Plane p5)
        {
            return JSRef!.Call<Frustum>("set", p0, p1, p2, p3, p4, p5);
        }
        /// <summary>
        /// intersectsSprite(sprite: Sprite): boolean;
        /// </summary>
        public bool IntersectsSprite(Sprite sprite)
        {
            return JSRef!.Call<bool>("intersectsSprite", sprite);
        }
        /// <summary>
        /// intersectsSphere(sphere: Sphere): boolean;
        /// </summary>
        public bool IntersectsSphere(Sphere sphere)
        {
            return JSRef!.Call<bool>("intersectsSphere", sphere);
        }
        /// <summary>
        /// intersectsObject(object: Object3D): boolean;
        /// </summary>
        public bool IntersectsObject(Object3D obj)
        {
            return JSRef!.Call<bool>("intersectsObject", obj);
        }
        /// <summary>
        /// intersectsBox(box: Box3): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// copy(frustum: Frustum): this;
        /// </summary>
        public Frustum Copy(Frustum frustum)
        {
            return JSRef!.Call<Frustum>("copy", frustum);
        }
        /// <summary>
        /// containsPoint(point: Vector3): boolean;
        /// </summary>
        public bool ContainsPoint(Vector3 point)
        {
            return JSRef!.Call<bool>("containsPoint", point);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Frustum Clone()
        {
            return JSRef!.Call<Frustum>("clone");
        }
        #endregion
    }
}
