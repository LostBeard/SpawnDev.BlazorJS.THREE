
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SkinnedMesh : Mesh
    {
        #region Constructors
        /// <inheritdoc/>
        public SkinnedMesh(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(geometry?: TGeometry, material?: TMaterial, useVertexTexture?: boolean);
        /// </summary>
        public SkinnedMesh(Geometry geometry, Material material, bool useVertexTexture) : base(JS.New("THREE.SkinnedMesh", geometry, material, useVertexTexture)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bindMatrix: Matrix4;
        /// </summary>
        public Matrix4 BindMatrix { get => JSRef!.Get<Matrix4>("bindMatrix"); set => JSRef!.Set("bindMatrix", value); }
        /// <summary>
        /// bindMatrixInverse: Matrix4;
        /// </summary>
        public Matrix4 BindMatrixInverse { get => JSRef!.Get<Matrix4>("bindMatrixInverse"); set => JSRef!.Set("bindMatrixInverse", value); }
        /// <summary>
        /// bindMode: BindMode;
        /// </summary>
        public BindMode BindMode { get => JSRef!.Get<BindMode>("bindMode"); set => JSRef!.Set("bindMode", value); }
        /// <summary>
        /// boundingBox: Box3;
        /// </summary>
        public Box3 BoundingBox { get => JSRef!.Get<Box3>("boundingBox"); set => JSRef!.Set("boundingBox", value); }
        /// <summary>
        /// boundingSphere: Sphere;
        /// </summary>
        public Sphere BoundingSphere { get => JSRef!.Get<Sphere>("boundingSphere"); set => JSRef!.Set("boundingSphere", value); }
        /// <summary>
        /// readonly isSkinnedMesh: true;
        /// </summary>
        public bool IsSkinnedMesh { get => JSRef!.Get<bool>("isSkinnedMesh"); }
        /// <summary>
        /// skeleton: Skeleton;
        /// </summary>
        public Skeleton Skeleton { get => JSRef!.Get<Skeleton>("skeleton"); set => JSRef!.Set("skeleton", value); }
        /// <summary>
        /// override readonly type: string | "SkinnedMesh";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// toJSON(meta?: JSONMeta): SkinnedMeshJSON;
        /// </summary>
        public SkinnedMeshJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<SkinnedMeshJSON>("toJSON", meta);
        }
        /// <summary>
        /// pose(): void;
        /// </summary>
        public void Pose()
        {
            JSRef!.CallVoid("pose");
        }
        /// <summary>
        /// normalizeSkinWeights(): void;
        /// </summary>
        public void NormalizeSkinWeights()
        {
            JSRef!.CallVoid("normalizeSkinWeights");
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
        /// bind(skeleton: Skeleton, bindMatrix?: Matrix4): void;
        /// </summary>
        public void Bind(Skeleton skeleton, Matrix4 bindMatrix)
        {
            JSRef!.CallVoid("bind", skeleton, bindMatrix);
        }
        /// <summary>
        /// applyBoneTransform(index: number, vector: Vector3): Vector3;
        /// </summary>
        public Vector3 ApplyBoneTransform(float index, Vector3 vector)
        {
            return JSRef!.Call<Vector3>("applyBoneTransform", index, vector);
        }
        #endregion
    }
}
