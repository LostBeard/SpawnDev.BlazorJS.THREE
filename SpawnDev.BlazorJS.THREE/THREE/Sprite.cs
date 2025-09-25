
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Sprite : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Sprite(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(material?: SpriteMaterial);
        /// </summary>
        public Sprite(SpriteMaterial material) : base(JS.New("THREE.Sprite", material)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// override castShadow: false;
        /// </summary>
        public bool CastShadow { get => JSRef!.Get<bool>("castShadow"); set => JSRef!.Set("castShadow", value); }
        /// <summary>
        /// center: Vector2;
        /// </summary>
        public Vector2 Center { get => JSRef!.Get<Vector2>("center"); set => JSRef!.Set("center", value); }
        /// <summary>
        /// count: number;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// geometry: BufferGeometry;
        /// </summary>
        public BufferGeometry Geometry { get => JSRef!.Get<BufferGeometry>("geometry"); set => JSRef!.Set("geometry", value); }
        /// <summary>
        /// readonly isSprite: true;
        /// </summary>
        public bool IsSprite { get => JSRef!.Get<bool>("isSprite"); }
        /// <summary>
        /// material: SpriteMaterial;
        /// </summary>
        public SpriteMaterial Material { get => JSRef!.Get<SpriteMaterial>("material"); set => JSRef!.Set("material", value); }
        /// <summary>
        /// override readonly type: string | "Sprite";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
