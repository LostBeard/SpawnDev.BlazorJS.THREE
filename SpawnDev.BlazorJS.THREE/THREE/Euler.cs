
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Euler : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Euler(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(x?: number, y?: number, z?: number, order?: EulerOrder);
        /// </summary>
        public Euler(float x, float y, float z, EulerOrder order) : base(JS.New("THREE.Euler", x, y, z, order)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static DEFAULT_ORDER: "XYZ";
        /// </summary>
        public static string DEFAULT_ORDER { get => JS.Get<string>("THREE.Euler.DEFAULT_ORDER"); set => JS.Set("THREE.Euler.DEFAULT_ORDER", value); }
        /// <summary>
        /// readonly isEuler: true;
        /// </summary>
        public bool IsEuler { get => JSRef!.Get<bool>("isEuler"); }
        /// <summary>
        /// order: EulerOrder;
        /// </summary>
        public EulerOrder Order { get => JSRef!.Get<EulerOrder>("order"); set => JSRef!.Set("order", value); }
        /// <summary>
        /// x: number;
        /// </summary>
        public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
        /// <summary>
        /// y: number;
        /// </summary>
        public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
        /// <summary>
        /// z: number;
        /// </summary>
        public float Z { get => JSRef!.Get<float>("z"); set => JSRef!.Set("z", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toArray(array?: Partial<EulerTuple>, offset?: number): EulerTuple;
        /// </summary>
        public EulerTuple ToArray(EulerTuple array, float offset)
        {
            return JSRef!.Call<EulerTuple>("toArray", array, offset);
        }
        /// <summary>
        /// setFromVector3(v: Vector3, order?: EulerOrder): Euler;
        /// </summary>
        public Euler SetFromVector3(Vector3 v, EulerOrder order)
        {
            return JSRef!.Call<Euler>("setFromVector3", v, order);
        }
        /// <summary>
        /// setFromRotationMatrix(m: Matrix4, order?: EulerOrder, update?: boolean): Euler;
        /// </summary>
        public Euler SetFromRotationMatrix(Matrix4 m, EulerOrder order, bool update)
        {
            return JSRef!.Call<Euler>("setFromRotationMatrix", m, order, update);
        }
        /// <summary>
        /// setFromQuaternion(q: Quaternion, order?: EulerOrder, update?: boolean): Euler;
        /// </summary>
        public Euler SetFromQuaternion(Quaternion q, EulerOrder order, bool update)
        {
            return JSRef!.Call<Euler>("setFromQuaternion", q, order, update);
        }
        /// <summary>
        /// set(x: number, y: number, z: number, order?: EulerOrder): Euler;
        /// </summary>
        public Euler Set(float x, float y, float z, EulerOrder order)
        {
            return JSRef!.Call<Euler>("set", x, y, z, order);
        }
        /// <summary>
        /// reorder(newOrder: EulerOrder): Euler;
        /// </summary>
        public Euler Reorder(EulerOrder newOrder)
        {
            return JSRef!.Call<Euler>("reorder", newOrder);
        }
        /// <summary>
        /// fromArray(array: EulerTuple): Euler;
        /// </summary>
        public Euler FromArray(EulerTuple array)
        {
            return JSRef!.Call<Euler>("fromArray", array);
        }
        /// <summary>
        /// equals(euler: Euler): boolean;
        /// </summary>
        public bool Equals(Euler euler)
        {
            return JSRef!.Call<bool>("equals", euler);
        }
        /// <summary>
        /// copy(euler: Euler): this;
        /// </summary>
        public Euler Copy(Euler euler)
        {
            return JSRef!.Call<Euler>("copy", euler);
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public Euler Clone()
        {
            return JSRef!.Call<Euler>("clone");
        }
        #endregion
    }
}
