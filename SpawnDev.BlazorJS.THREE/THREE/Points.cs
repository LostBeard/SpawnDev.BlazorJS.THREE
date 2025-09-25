
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Points<TGeometry, TMaterial> : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Points(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial);
        /// </summary>
        public Points(TGeometry geometry, TMaterial material) : base(JS.New("THREE.Points", geometry, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// geometry: TGeometry;
        /// </summary>
        public TGeometry Geometry { get => JSRef!.Get<TGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// readonly isPoints: true;
        /// </summary>
        public bool IsPoints { get => JSRef!.Get<bool>("isPoints"); }
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
        /// override readonly type: string | "Points";
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
        #endregion
    }
}
