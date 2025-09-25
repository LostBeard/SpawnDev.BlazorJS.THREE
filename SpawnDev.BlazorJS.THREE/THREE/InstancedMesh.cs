
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class InstancedMesh<TGeometry, TMaterial> : Mesh<TGeometry, TMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedMesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry: TGeometry | undefined, material: TMaterial | undefined, count: number);
        /// </summary>
        public InstancedMesh(TGeometry geometry, TMaterial material, float count) : base(JS.New("THREE.InstancedMesh", geometry, material, count)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// boundingBox: Box3 | null;
        /// </summary>
        public Box3 BoundingBox { get => JSRef!.Get<Box3>("boundingBox"); set => JSRef!.Set("boundingBox", value); }
        /// <summary>
        /// boundingSphere: Sphere | null;
        /// </summary>
        public Sphere BoundingSphere { get => JSRef!.Get<Sphere>("boundingSphere"); set => JSRef!.Set("boundingSphere", value); }
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// instanceColor: InstancedBufferAttribute | null;
        /// </summary>
        public InstancedBufferAttribute InstanceColor { get => JSRef!.Get<InstancedBufferAttribute>("instanceColor"); set => JSRef!.Set("instanceColor", value); }
        /// <summary>
        /// instanceMatrix: InstancedBufferAttribute;
        /// </summary>
        public InstancedBufferAttribute InstanceMatrix { get => JSRef!.Get<InstancedBufferAttribute>("instanceMatrix"); set => JSRef!.Set("instanceMatrix", value); }
        /// <summary>
        /// readonly isInstancedMesh: true;
        /// </summary>
        public bool IsInstancedMesh { get => JSRef!.Get<bool>("isInstancedMesh"); }
        /// <summary>
        /// morphTexture: DataTexture | null;
        /// </summary>
        public DataTexture MorphTexture { get => JSRef!.Get<DataTexture>("morphTexture"); set => JSRef!.Set("morphTexture", value); }
        #endregion

        #region Methods
        /// <summary>
        /// override updateMorphTargets(): void;
        /// </summary>
        public void UpdateMorphTargets()
        {
            JSRef!.CallVoid("updateMorphTargets");
        }
        /// <summary>
        /// toJSON(meta?: JSONMeta): InstancedMeshJSON;
        /// </summary>
        public InstancedMeshJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<InstancedMeshJSON>("toJSON", meta);
        }
        /// <summary>
        /// setMorphAt(index: number, mesh: Mesh): void;
        /// </summary>
        public void SetMorphAt(float index, Mesh mesh)
        {
            JSRef!.CallVoid("setMorphAt", index, mesh);
        }
        /// <summary>
        /// setMatrixAt(index: number, matrix: Matrix4): void;
        /// </summary>
        public void SetMatrixAt(float index, Matrix4 matrix)
        {
            JSRef!.CallVoid("setMatrixAt", index, matrix);
        }
        /// <summary>
        /// setColorAt(index: number, color: Color): void;
        /// </summary>
        public void SetColorAt(float index, Color color)
        {
            JSRef!.CallVoid("setColorAt", index, color);
        }
        /// <summary>
        /// getMorphAt(index: number, mesh: Mesh): void;
        /// </summary>
        public void GetMorphAt(float index, Mesh mesh)
        {
            JSRef!.CallVoid("getMorphAt", index, mesh);
        }
        /// <summary>
        /// getMatrixAt(index: number, matrix: Matrix4): void;
        /// </summary>
        public void GetMatrixAt(float index, Matrix4 matrix)
        {
            JSRef!.CallVoid("getMatrixAt", index, matrix);
        }
        /// <summary>
        /// getColorAt(index: number, color: Color): void;
        /// </summary>
        public void GetColorAt(float index, Color color)
        {
            JSRef!.CallVoid("getColorAt", index, color);
        }
        /// <summary>
        /// dispose(): this;
        /// </summary>
        public void JSDispose()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// computeBoundingSphere(): void;
        /// </summary>
        public void ComputeBoundingSphere()
        {
            JSRef!.CallVoid("computeBoundingSphere");
        }
        /// <summary>
        /// computeBoundingBox(): void;
        /// </summary>
        public void ComputeBoundingBox()
        {
            JSRef!.CallVoid("computeBoundingBox");
        }
        #endregion
    }
}
