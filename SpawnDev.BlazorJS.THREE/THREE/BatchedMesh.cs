
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BatchedMesh : Mesh
    {
        #region Constructors
        /// <inheritdoc/>
        public BatchedMesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(maxInstanceCount: number, maxVertexCount: number, maxIndexCount?: number, material?: Material);
        /// </summary>
        public BatchedMesh(float maxInstanceCount, float maxVertexCount, float maxIndexCount, Material material) : base(JS.New("THREE.BatchedMesh", maxInstanceCount, maxVertexCount, maxIndexCount, material)) { }
        
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
        /// customSort: ((this: this, list: Array<{ start: number; count: number; z: number }>, camera: Camera) => void) | null;
        /// </summary>
        public Callback CustomSort { get => JSRef!.Get<Callback>("customSort"); set => JSRef!.Set("customSort", value); }
        /// <summary>
        /// get instanceCount(): number;
        /// </summary>
        public float InstanceCount { get => JSRef!.Get<float>("instanceCount"); }
        /// <summary>
        /// readonly isBatchedMesh: true;
        /// </summary>
        public bool IsBatchedMesh { get => JSRef!.Get<bool>("isBatchedMesh"); }
        /// <summary>
        /// get maxInstanceCount(): number;
        /// </summary>
        public float MaxInstanceCount { get => JSRef!.Get<float>("maxInstanceCount"); }
        /// <summary>
        /// perObjectFrustumCulled: boolean;
        /// </summary>
        public bool PerObjectFrustumCulled { get => JSRef!.Get<bool>("perObjectFrustumCulled"); set => JSRef!.Set("perObjectFrustumCulled", value); }
        /// <summary>
        /// sortObjects: boolean;
        /// </summary>
        public bool SortObjects { get => JSRef!.Get<bool>("sortObjects"); set => JSRef!.Set("sortObjects", value); }
        /// <summary>
        /// get unusedIndexCount(): number;
        /// </summary>
        public float UnusedIndexCount { get => JSRef!.Get<float>("unusedIndexCount"); }
        /// <summary>
        /// get unusedVertexCount(): number;
        /// </summary>
        public float UnusedVertexCount { get => JSRef!.Get<float>("unusedVertexCount"); }
        #endregion

        #region Methods
        /// <summary>
        /// setVisibleAt(instanceId: number, visible: boolean): this;
        /// </summary>
        public BatchedMesh SetVisibleAt(float instanceId, bool visible)
        {
            return JSRef!.Call<BatchedMesh>("setVisibleAt", instanceId, visible);
        }
        /// <summary>
        /// setMatrixAt(instanceId: number, matrix: Matrix4): this;
        /// </summary>
        public BatchedMesh SetMatrixAt(float instanceId, Matrix4 matrix)
        {
            return JSRef!.Call<BatchedMesh>("setMatrixAt", instanceId, matrix);
        }
        /// <summary>
        /// setInstanceCount(maxInstanceCount: number): void;
        /// </summary>
        public void SetInstanceCount(float maxInstanceCount)
        {
            JSRef!.CallVoid("setInstanceCount", maxInstanceCount);
        }
        /// <summary>
        /// setGeometrySize(maxVertexCount: number, maxIndexCount: number): void;
        /// </summary>
        public void SetGeometrySize(float maxVertexCount, float maxIndexCount)
        {
            JSRef!.CallVoid("setGeometrySize", maxVertexCount, maxIndexCount);
        }
        /// <summary>
        /// setGeometryIdAt(instanceId: number, geometryId: number): this;
        /// </summary>
        public BatchedMesh SetGeometryIdAt(float instanceId, float geometryId)
        {
            return JSRef!.Call<BatchedMesh>("setGeometryIdAt", instanceId, geometryId);
        }
        /// <summary>
        /// setGeometryAt(geometryId: number, geometry: BufferGeometry): number;
        /// </summary>
        public float SetGeometryAt(float geometryId, BufferGeometry geometry)
        {
            return JSRef!.Call<float>("setGeometryAt", geometryId, geometry);
        }
        /// <summary>
        /// setCustomSort(
        ///         sortFunction:
        ///             | ((this: this, list: Array<{ start: number; count: number; z: number }>, camera: Camera) => void)
        ///             | null,
        ///     ): this;
        /// </summary>
        public BatchedMesh SetCustomSort(Callback sortFunction, BatchedMesh thisObj, Array<object> list, Camera camera)
        {
            return JSRef!.Call<BatchedMesh>("setCustomSort", sortFunction, thisObj, list, camera);
        }
        /// <summary>
        /// setColorAt(instanceId: number, color: Color): void;
        /// </summary>
        public void SetColorAt(float instanceId, Color color)
        {
            JSRef!.CallVoid("setColorAt", instanceId, color);
        }
        /// <summary>
        /// optimize(): this;
        /// </summary>
        public BatchedMesh Optimize()
        {
            return JSRef!.Call<BatchedMesh>("optimize");
        }
        /// <summary>
        /// getVisibleAt(instanceId: number): boolean;
        /// </summary>
        public bool GetVisibleAt(float instanceId)
        {
            return JSRef!.Call<bool>("getVisibleAt", instanceId);
        }
        /// <summary>
        /// getMatrixAt(instanceId: number, target: Matrix4): Matrix4;
        /// </summary>
        public Matrix4 GetMatrixAt(float instanceId, Matrix4 target)
        {
            return JSRef!.Call<Matrix4>("getMatrixAt", instanceId, target);
        }
        /// <summary>
        /// getGeometryRangeAt(
        ///         geometryId: number,
        ///         target?: BatchedMeshGeometryRange,
        ///     ): BatchedMeshGeometryRange | null;
        /// </summary>
        public BatchedMeshGeometryRange GetGeometryRangeAt(float geometryId, BatchedMeshGeometryRange target)
        {
            return JSRef!.Call<BatchedMeshGeometryRange>("getGeometryRangeAt", geometryId, target);
        }
        /// <summary>
        /// getGeometryIdAt(instanceId: number): number;
        /// </summary>
        public float GetGeometryIdAt(float instanceId)
        {
            return JSRef!.Call<float>("getGeometryIdAt", instanceId);
        }
        /// <summary>
        /// getColorAt(instanceId: number, target: Color): void;
        /// </summary>
        public void GetColorAt(float instanceId, Color target)
        {
            JSRef!.CallVoid("getColorAt", instanceId, target);
        }
        /// <summary>
        /// getBoundingSphereAt(geometryId: number, target: Sphere): Sphere | null;
        /// </summary>
        public Sphere GetBoundingSphereAt(float geometryId, Sphere target)
        {
            return JSRef!.Call<Sphere>("getBoundingSphereAt", geometryId, target);
        }
        /// <summary>
        /// getBoundingBoxAt(geometryId: number, target: Box3): Box3 | null;
        /// </summary>
        public Box3 GetBoundingBoxAt(float geometryId, Box3 target)
        {
            return JSRef!.Call<Box3>("getBoundingBoxAt", geometryId, target);
        }
        /// <summary>
        /// dispose(): this;
        /// </summary>
        public BatchedMesh Dispose()
        {
            return JSRef!.Call<BatchedMesh>("dispose");
        }
        /// <summary>
        /// deleteInstance(instanceId: number): this;
        /// </summary>
        public BatchedMesh DeleteInstance(float instanceId)
        {
            return JSRef!.Call<BatchedMesh>("deleteInstance", instanceId);
        }
        /// <summary>
        /// deleteGeometry(geometryId: number): this;
        /// </summary>
        public BatchedMesh DeleteGeometry(float geometryId)
        {
            return JSRef!.Call<BatchedMesh>("deleteGeometry", geometryId);
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
        /// <summary>
        /// addInstance(geometryId: number): number;
        /// </summary>
        public float AddInstance(float geometryId)
        {
            return JSRef!.Call<float>("addInstance", geometryId);
        }
        /// <summary>
        /// addGeometry(geometry: BufferGeometry, reservedVertexRange?: number, reservedIndexRange?: number): number;
        /// </summary>
        public float AddGeometry(BufferGeometry geometry, float reservedVertexRange, float reservedIndexRange)
        {
            return JSRef!.Call<float>("addGeometry", geometry, reservedVertexRange, reservedIndexRange);
        }
        #endregion
    }
}
