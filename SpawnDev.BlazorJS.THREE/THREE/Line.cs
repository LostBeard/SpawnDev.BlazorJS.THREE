
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Line : Object3D
    {
        /// <inheritdoc/>
        public Line(IJSInProcessObjectReference _ref) : base(_ref) { }
    }
    public class Line<TGeometry, TMaterial> : Line
    {
        #region Constructors
        /// <inheritdoc/>
        public Line(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial);
        /// </summary>
        public Line(TGeometry geometry, TMaterial material) : base(JS.New("THREE.Line", geometry, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// geometry: TGeometry;
        /// </summary>
        public TGeometry Geometry { get => JSRef!.Get<TGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// readonly isLine: true;
        /// </summary>
        public bool IsLine { get => JSRef!.Get<bool>("isLine"); }
        /// <summary>
        /// material: TMaterial;
        /// </summary>
        public TMaterial Material { get => JSRef!.Get<TMaterial>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// morphTargetDictionary?: { [key: string]: number } | undefined;
        /// </summary>
        public object MorphTargetDictionary { get => JSRef!.Get<object>("morphTargetDictionary"); set => JSRef!.Set("morphTargetDictionary", value); }
        /// <summary>
        /// morphTargetInfluences?: number[] | undefined;
        /// </summary>
        public Array<float> MorphTargetInfluences { get => JSRef!.Get<Array<float>>("morphTargetInfluences"); set => JSRef!.Set("morphTargetInfluences", value); }
        /// <summary>
        /// override readonly type: string | "Line";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// updateMorphTargets(): void;
        /// </summary>
        public void UpdateMorphTargets()
        {
            JSRef!.CallVoid("updateMorphTargets");
        }
        /// <summary>
        /// computeLineDistances(): this;
        /// </summary>
        public Line<TGeometry, TMaterial> ComputeLineDistances()
        {
            return JSRef!.Call<Line<TGeometry, TMaterial>>("computeLineDistances");
        }
        #endregion
    }
}
