
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Source : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Source(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(data: any);
        /// </summary>
        public Source(object data) : base(JS.New("THREE.Source", data)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// data: any;
        /// </summary>
        public object Data { get => JSRef!.Get<object>("data"); set => JSRef!.Set("data", value); }
        /// <summary>
        /// dataReady: boolean;
        /// </summary>
        public bool DataReady { get => JSRef!.Get<bool>("dataReady"); set => JSRef!.Set("dataReady", value); }
        /// <summary>
        /// readonly id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// readonly isSource: true;
        /// </summary>
        public bool IsSource { get => JSRef!.Get<bool>("isSource"); }
        /// <summary>
        /// set needsUpdate(value: boolean);
        /// </summary>
        public bool NeedsUpdate { get => JSRef!.Get<bool>("needsUpdate"); set => JSRef!.Set("needsUpdate", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        /// <summary>
        /// version: number;
        /// </summary>
        public float Version { get => JSRef!.Get<float>("version"); set => JSRef!.Set("version", value); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: string | {}): SourceJSON;
        /// </summary>
        public SourceJSON ToJSON(Union<string, object> meta)
        {
            return JSRef!.Call<SourceJSON>("toJSON", meta);
        }
        /// <summary>
        /// getSize(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetSize(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getSize", target);
        }
        #endregion
    }
}
