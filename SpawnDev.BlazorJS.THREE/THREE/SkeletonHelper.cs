
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SkeletonHelper : LineSegments
    {
        #region Constructors
        /// <inheritdoc/>
        public SkeletonHelper(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(object: SkinnedMesh | Object3D);
        /// </summary>
        public SkeletonHelper(Union<SkinnedMesh, Object3D> obj) : base(JS.New("THREE.SkeletonHelper", obj)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bones: Bone[];
        /// </summary>
        public Array<Bone> Bones { get => JSRef!.Get<Array<Bone>>("bones"); set => JSRef!.Set("bones", value); }
        /// <summary>
        /// readonly isSkeletonHelper = true;
        /// </summary>
        public bool IsSkeletonHelper { get => JSRef!.Get<bool>("isSkeletonHelper"); }
        /// <summary>
        /// override matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// root: SkinnedMesh | Object3D;
        /// </summary>
        public Union<SkinnedMesh, Object3D> Root { get => JSRef!.Get<Union<SkinnedMesh, Object3D>>("root"); set => JSRef!.Set("root", value); }
        /// <summary>
        /// override readonly type: string | "SkeletonHelper";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods
        /// <summary>
        /// setColors(color1: Color, color2: Color): this;
        /// </summary>
        public SkeletonHelper SetColors(Color color1, Color color2)
        {
            return JSRef!.Call<SkeletonHelper>("setColors", color1, color2);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        #endregion
    }
}
