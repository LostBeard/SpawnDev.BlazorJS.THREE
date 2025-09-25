
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Mesh : Object3D
    {
        /// <inheritdoc/>
        public Mesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// geometry: TGeometry;
        /// </summary>
        public TGeometry Geometry_Get<TGeometry>()  => JSRef!.Get<TGeometry>("geometry");
        /// <summary>
        /// geometry: TGeometry;
        /// </summary>
        public void Geometry_Set(BufferGeometry geometry) => JSRef!.Set("geometry", geometry);
        /// readonly isMesh: true;
        /// </summary>
        public bool IsMesh { get => JSRef!.Get<bool>("isMesh"); }
        /// <summary>
        /// material: TMaterial;
        /// </summary>
        public TMaterial Material_Get<TMaterial>() => JSRef!.Get<TMaterial>("material");
        /// <summary>
        /// material: TMaterial;
        /// </summary>
        public void Material_Set(Material material) => JSRef!.Set("material", material);
        /// <summary>
        /// morphTargetDictionary?: { [key: string]: number } | undefined;
        /// </summary>
        public object MorphTargetDictionary { get => JSRef!.Get<object>("morphTargetDictionary"); set => JSRef!.Set("morphTargetDictionary", value); }
        /// <summary>
        /// morphTargetInfluences?: number[] | undefined;
        /// </summary>
        public Array<float> MorphTargetInfluences { get => JSRef!.Get<Array<float>>("morphTargetInfluences"); set => JSRef!.Set("morphTargetInfluences", value); }
        ///// <summary>
        ///// override readonly type: string | "Mesh";
        ///// </summary>
        //public string Type { get => JSRef!.Get<string>("type"); }
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
        /// toJSON(meta?: JSONMeta): MeshJSON;
        /// </summary>
        public new MeshJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<MeshJSON>("toJSON", meta);
        }
        /// <summary>
        /// getVertexPosition(index: number, target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetVertexPosition(float index, Vector3 target)
        {
            return JSRef!.Call<Vector3>("getVertexPosition", index, target);
        }
        #endregion
    }
    public class Mesh<TGeometry, TMaterial> : Mesh
    {
        #region Constructors
        /// <inheritdoc/>
        public Mesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial);
        /// </summary>
        public Mesh(TGeometry geometry, TMaterial material) : base(JS.New("THREE.Mesh", geometry, material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// geometry: TGeometry;
        /// </summary>
        public TGeometry Geometry { get => JSRef!.Get<TGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// material: TMaterial;
        /// </summary>
        public TMaterial Material { get => JSRef!.Get<TMaterial>("material"); set => JSRef!.Set("material", value); }
        #endregion

        #region Methods
        #endregion
    }
}
