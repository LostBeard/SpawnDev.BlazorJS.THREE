
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LOD : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public LOD(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public LOD() : base(JS.New("THREE.LOD")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// autoUpdate: boolean;
        /// </summary>
        public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        /// <summary>
        /// readonly isLOD: true;
        /// </summary>
        public bool IsLOD { get => JSRef!.Get<bool>("isLOD"); }
        /// <summary>
        /// levels: Array<{
                ///         /** The Object3D to display at this level. */
                ///         object: Object3D;
                ///         /** The distance at which to display this level of detail. Expects a `Float`. */
                ///         distance: number;
                ///         /** Threshold used to avoid flickering at LOD boundaries, as a fraction of distance. Expects a `Float`. */
                ///         hysteresis: number;
                ///     }>;
        /// </summary>
        public Array<object> Levels { get => JSRef!.Get<Array<object>>("levels"); set => JSRef!.Set("levels", value); }
        /// <summary>
        /// override readonly type: string | "LOD";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// update(camera: Camera): void;
        /// </summary>
        public void Update(Camera camera)
        {
            JSRef!.CallVoid("update", camera);
        }
        /// <summary>
        /// toJSON(meta?: JSONMeta): LODJSON;
        /// </summary>
        public LODJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<LODJSON>("toJSON", meta);
        }
        /// <summary>
        /// removeLevel(distance: number): boolean;
        /// </summary>
        public bool RemoveLevel(float distance)
        {
            return JSRef!.Call<bool>("removeLevel", distance);
        }
        /// <summary>
        /// getObjectForDistance(distance: number): Object3D | null;
        /// </summary>
        public Object3D GetObjectForDistance(float distance)
        {
            return JSRef!.Call<Object3D>("getObjectForDistance", distance);
        }
        /// <summary>
        /// getCurrentLevel(): number;
        /// </summary>
        public float GetCurrentLevel()
        {
            return JSRef!.Call<float>("getCurrentLevel");
        }
        /// <summary>
        /// addLevel(object: Object3D, distance?: number, hysteresis?: number): this;
        /// </summary>
        public LOD AddLevel(Object3D obj, float distance, float hysteresis)
        {
            return JSRef!.Call<LOD>("addLevel", obj, distance, hysteresis);
        }
        #endregion
    }
}
