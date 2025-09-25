
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Spherical : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Spherical(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, phi?: number, theta?: number);
        /// </summary>
        public Spherical(float radius, float phi, float theta) : base(JS.New("THREE.Spherical", radius, phi, theta)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// phi: number;
        /// </summary>
        public float Phi { get => JSRef!.Get<float>("phi"); set => JSRef!.Set("phi", value); }
        /// <summary>
        /// radius: number;
        /// </summary>
        public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        /// <summary>
        /// theta: number;
        /// </summary>
        public float Theta { get => JSRef!.Get<float>("theta"); set => JSRef!.Set("theta", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setFromVector3(v: Vector3): this;
        /// </summary>
        public Spherical SetFromVector3(Vector3 v)
        {
            return JSRef!.Call<Spherical>("setFromVector3", v);
        }
        /// <summary>
        /// setFromCartesianCoords(x: number, y: number, z: number): this;
        /// </summary>
        public Spherical SetFromCartesianCoords(float x, float y, float z)
        {
            return JSRef!.Call<Spherical>("setFromCartesianCoords", x, y, z);
        }
        /// <summary>
        /// set(radius: number, phi: number, theta: number): this;
        /// </summary>
        public Spherical Set(float radius, float phi, float theta)
        {
            return JSRef!.Call<Spherical>("set", radius, phi, theta);
        }
        /// <summary>
        /// makeSafe(): this;
        /// </summary>
        public Spherical MakeSafe()
        {
            return JSRef!.Call<Spherical>("makeSafe");
        }
        /// <summary>
        /// copy(other: Spherical): this;
        /// </summary>
        public Spherical Copy(Spherical other)
        {
            return JSRef!.Call<Spherical>("copy", other);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Spherical Clone()
        {
            return JSRef!.Call<Spherical>("clone");
        }
        #endregion
    }
}
