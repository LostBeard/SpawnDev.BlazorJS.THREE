using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// A special version of Mesh with support for instanced rendering. Use InstancedMesh if you have to render a large number of objects with the same geometry and material but with different world transformations.<br/>
    /// https://threejs.org/docs/index.html#api/en/objects/InstancedMesh
    /// </summary>
    public class InstancedMesh<TGeometry, TMaterial> : Mesh<TGeometry, TMaterial>
    {
        #region Constructors
        /// <inheritdoc/>
        public InstancedMesh(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Create a new InstancedMesh.
        /// </summary>
        /// <param name="geometry">The Geometry</param>
        /// <param name="material">The Material</param>
        /// <param name="count">The number of instances</param>
        public InstancedMesh(TGeometry geometry, TMaterial material, int count) : base(JS.New("THREE.InstancedMesh", geometry, material, count)) { }

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
        /// The number of instances.
        /// </summary>
        public int Count { get => JSRef!.Get<int>("count"); set => JSRef!.Set("count", value); }
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
        /// Sets the given Local-Space Morph Target Influences of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="mesh">The mesh</param>
        public void SetMorphAt(int index, Mesh mesh)
        {
            JSRef!.CallVoid("setMorphAt", index, mesh);
        }
        /// <summary>
        /// Sets the given Local-Space Matrix of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="matrix">The 4x4 instance matrix</param>
        public void SetMatrixAt(int index, Matrix4 matrix)
        {
            JSRef!.CallVoid("setMatrixAt", index, matrix);
        }
        /// <summary>
        /// Sets the given color of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="color">The color</param>
        public void SetColorAt(int index, Color color)
        {
            JSRef!.CallVoid("setColorAt", index, color);
        }
        /// <summary>
        /// Gets the Local-Space Morph Target Influences of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="mesh">The mesh</param>
        public void GetMorphAt(int index, Mesh mesh)
        {
            JSRef!.CallVoid("getMorphAt", index, mesh);
        }
        /// <summary>
        /// Gets the Local-Space Matrix of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="matrix">The 4x4 instance matrix</param>
        public void GetMatrixAt(int index, Matrix4 matrix)
        {
            JSRef!.CallVoid("getMatrixAt", index, matrix);
        }
        /// <summary>
        /// Gets the color of a defined instance.
        /// </summary>
        /// <param name="index">The index of the instance</param>
        /// <param name="color">The color</param>
        public void GetColorAt(int index, Color color)
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
