
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Cylindrical : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Cylindrical(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(radius?: number, theta?: number, y?: number);
        /// </summary>
        public Cylindrical(float radius, float theta, float y) : base(JS.New("THREE.Cylindrical", radius, theta, y)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// radius: number;
        /// </summary>
        public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        /// <summary>
        /// theta: number;
        /// </summary>
        public float Theta { get => JSRef!.Get<float>("theta"); set => JSRef!.Set("theta", value); }
        /// <summary>
        /// y: number;
        /// </summary>
        public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
        #endregion

        #region Methods
        /// <summary>
        /// setFromVector3(vec3: Vector3): this;
        /// </summary>
        public Cylindrical SetFromVector3(Vector3 vec3)
        {
            return JSRef!.Call<Cylindrical>("setFromVector3", vec3);
        }
        /// <summary>
        /// setFromCartesianCoords(x: number, y: number, z: number): this;
        /// </summary>
        public Cylindrical SetFromCartesianCoords(float x, float y, float z)
        {
            return JSRef!.Call<Cylindrical>("setFromCartesianCoords", x, y, z);
        }
        /// <summary>
        /// set(radius: number, theta: number, y: number): this;
        /// </summary>
        public Cylindrical Set(float radius, float theta, float y)
        {
            return JSRef!.Call<Cylindrical>("set", radius, theta, y);
        }
        /// <summary>
        /// copy(other: Cylindrical): this;
        /// </summary>
        public Cylindrical Copy(Cylindrical other)
        {
            return JSRef!.Call<Cylindrical>("copy", other);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Cylindrical Clone()
        {
            return JSRef!.Call<Cylindrical>("clone");
        }
        #endregion
    }
}
