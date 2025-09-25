
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Plane : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Plane(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(normal?: Vector3, constant?: number);
        /// </summary>
        public Plane(Vector3 normal, float constant) : base(JS.New("THREE.Plane", normal, constant)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// constant: number;
        /// </summary>
        public float Constant { get => JSRef!.Get<float>("constant"); set => JSRef!.Set("constant", value); }
        /// <summary>
        /// readonly isPlane: true;
        /// </summary>
        public bool IsPlane { get => JSRef!.Get<bool>("isPlane"); }
        /// <summary>
        /// normal: Vector3;
        /// </summary>
        public Vector3 Normal { get => JSRef!.Get<Vector3>("normal"); set => JSRef!.Set("normal", value); }
        #endregion

        #region Methods
        /// <summary>
        /// translate(offset: Vector3): Plane;
        /// </summary>
        public Plane Translate(Vector3 offset)
        {
            return JSRef!.Call<Plane>("translate", offset);
        }
        /// <summary>
        /// setFromNormalAndCoplanarPoint(normal: Vector3, point: Vector3): Plane;
        /// </summary>
        public Plane SetFromNormalAndCoplanarPoint(Vector3 normal, Vector3 point)
        {
            return JSRef!.Call<Plane>("setFromNormalAndCoplanarPoint", normal, point);
        }
        /// <summary>
        /// setFromCoplanarPoints(a: Vector3, b: Vector3, c: Vector3): Plane;
        /// </summary>
        public Plane SetFromCoplanarPoints(Vector3 a, Vector3 b, Vector3 c)
        {
            return JSRef!.Call<Plane>("setFromCoplanarPoints", a, b, c);
        }
        /// <summary>
        /// setComponents(x: number, y: number, z: number, w: number): Plane;
        /// </summary>
        public Plane SetComponents(float x, float y, float z, float w)
        {
            return JSRef!.Call<Plane>("setComponents", x, y, z, w);
        }
        /// <summary>
        /// set(normal: Vector3, constant: number): Plane;
        /// </summary>
        public Plane Set(Vector3 normal, float constant)
        {
            return JSRef!.Call<Plane>("set", normal, constant);
        }
        /// <summary>
        /// projectPoint(point: Vector3, target: Vector3): Vector3;
        /// </summary>
        public Vector3 ProjectPoint(Vector3 point, Vector3 target)
        {
            return JSRef!.Call<Vector3>("projectPoint", point, target);
        }
        /// <summary>
        /// normalize(): Plane;
        /// </summary>
        public Plane Normalize()
        {
            return JSRef!.Call<Plane>("normalize");
        }
        /// <summary>
        /// negate(): Plane;
        /// </summary>
        public Plane Negate()
        {
            return JSRef!.Call<Plane>("negate");
        }
        /// <summary>
        /// isIntersectionLine(l: any): any;
        /// </summary>
        public object IsIntersectionLine(object l)
        {
            return JSRef!.Call<object>("isIntersectionLine", l);
        }
        /// <summary>
        /// intersectsSphere(sphere: Sphere): boolean;
        /// </summary>
        public bool IntersectsSphere(Sphere sphere)
        {
            return JSRef!.Call<bool>("intersectsSphere", sphere);
        }
        /// <summary>
        /// intersectsLine(line: Line3): boolean;
        /// </summary>
        public bool IntersectsLine(Line3 line)
        {
            return JSRef!.Call<bool>("intersectsLine", line);
        }
        /// <summary>
        /// intersectsBox(box: Box3): boolean;
        /// </summary>
        public bool IntersectsBox(Box3 box)
        {
            return JSRef!.Call<bool>("intersectsBox", box);
        }
        /// <summary>
        /// intersectLine(line: Line3, target: Vector3): Vector3 | null;
        /// </summary>
        public Vector3 IntersectLine(Line3 line, Vector3 target)
        {
            return JSRef!.Call<Vector3>("intersectLine", line, target);
        }
        /// <summary>
        /// equals(plane: Plane): boolean;
        /// </summary>
        public bool Equals(Plane plane)
        {
            return JSRef!.Call<bool>("equals", plane);
        }
        /// <summary>
        /// distanceToSphere(sphere: Sphere): number;
        /// </summary>
        public float DistanceToSphere(Sphere sphere)
        {
            return JSRef!.Call<float>("distanceToSphere", sphere);
        }
        /// <summary>
        /// distanceToPoint(point: Vector3): number;
        /// </summary>
        public float DistanceToPoint(Vector3 point)
        {
            return JSRef!.Call<float>("distanceToPoint", point);
        }
        /// <summary>
        /// copy(plane: Plane): this;
        /// </summary>
        public Plane Copy(Plane plane)
        {
            return JSRef!.Call<Plane>("copy", plane);
        }
        /// <summary>
        /// coplanarPoint(target: Vector3): Vector3;
        /// </summary>
        public Vector3 CoplanarPoint(Vector3 target)
        {
            return JSRef!.Call<Vector3>("coplanarPoint", target);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Plane Clone()
        {
            return JSRef!.Call<Plane>("clone");
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4, optionalNormalMatrix?: Matrix3): Plane;
        /// </summary>
        public Plane ApplyMatrix4(Matrix4 matrix, Matrix3 optionalNormalMatrix)
        {
            return JSRef!.Call<Plane>("applyMatrix4", matrix, optionalNormalMatrix);
        }
        #endregion
    }
}
