
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Skeleton : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public Skeleton(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(bones?: Bone[], boneInverses?: Matrix4[]);
        /// </summary>
        public Skeleton(Array<Bone> bones, Array<Matrix4> boneInverses) : base(JS.New("THREE.Skeleton", bones, boneInverses)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// boneInverses: Matrix4[];
        /// </summary>
        public Array<Matrix4> BoneInverses { get => JSRef!.Get<Array<Matrix4>>("boneInverses"); set => JSRef!.Set("boneInverses", value); }
        /// <summary>
        /// boneMatrices: Float32Array;
        /// </summary>
        public Float32Array BoneMatrices { get => JSRef!.Get<Float32Array>("boneMatrices"); set => JSRef!.Set("boneMatrices", value); }
        /// <summary>
        /// bones: Bone[];
        /// </summary>
        public Array<Bone> Bones { get => JSRef!.Get<Array<Bone>>("bones"); set => JSRef!.Set("bones", value); }
        /// <summary>
        /// boneTexture: null | DataTexture;
        /// </summary>
        public DataTexture BoneTexture { get => JSRef!.Get<DataTexture>("boneTexture"); set => JSRef!.Set("boneTexture", value); }
        /// <summary>
        /// frame: number;
        /// </summary>
        public float Frame { get => JSRef!.Get<float>("frame"); set => JSRef!.Set("frame", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(): void;
        /// </summary>
        public void Update()
        {
            JSRef!.CallVoid("update");
        }
        /// <summary>
        /// toJSON(): SkeletonJSON;
        /// </summary>
        public SkeletonJSON ToJSON()
        {
            return JSRef!.Call<SkeletonJSON>("toJSON");
        }
        /// <summary>
        /// pose(): void;
        /// </summary>
        public void Pose()
        {
            JSRef!.CallVoid("pose");
        }
        /// <summary>
        /// init(): void;
        /// </summary>
        public void Init()
        {
            JSRef!.CallVoid("init");
        }
        /// <summary>
        /// getBoneByName(name: string): undefined | Bone;
        /// </summary>
        public Bone GetBoneByName(string name)
        {
            return JSRef!.Call<Bone>("getBoneByName", name);
        }
        /// <summary>
        /// fromJSON(json: SkeletonJSON, bones: Record<string, Bone>): void;
        /// </summary>
        public void FromJSON(SkeletonJSON json, Record<string, Bone> bones)
        {
            JSRef!.CallVoid("fromJSON", json, bones);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// computeBoneTexture(): this;
        /// </summary>
        public Skeleton ComputeBoneTexture()
        {
            return JSRef!.Call<Skeleton>("computeBoneTexture");
        }
        /// <summary>
        /// clone(): Skeleton;
        /// </summary>
        public Skeleton Clone()
        {
            return JSRef!.Call<Skeleton>("clone");
        }
        /// <summary>
        /// calculateInverses(): void;
        /// </summary>
        public void CalculateInverses()
        {
            JSRef!.CallVoid("calculateInverses");
        }
        #endregion
    }
}
