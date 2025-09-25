
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ProgrammableStage : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ProgrammableStage(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         code: string,
        ///         stage: "compute" | "vertex" | "fragment",
        ///         name: string,
        ///         transforms?: null,
        ///         attributes?: NodeAttribute[] | null,
        ///     );
        /// </summary>
        public ProgrammableStage(string code, string stage, string name, object transforms, Array<NodeAttribute> attributes) : base(JS.New("THREE.ProgrammableStage", code, stage, name, transforms, attributes)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// attributes: NodeAttribute[] | null;
        /// </summary>
        public Array<NodeAttribute> Attributes { get => JSRef!.Get<Array<NodeAttribute>>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// code: string;
        /// </summary>
        public string Code { get => JSRef!.Get<string>("code"); set => JSRef!.Set("code", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// stage: "compute" | "vertex" | "fragment";
        /// </summary>
        public string Stage { get => JSRef!.Get<string>("stage"); set => JSRef!.Set("stage", value); }
        /// <summary>
        /// usedTimes: number;
        /// </summary>
        public float UsedTimes { get => JSRef!.Get<float>("usedTimes"); set => JSRef!.Set("usedTimes", value); }
        #endregion

        #region Methods

        #endregion
    }
}
