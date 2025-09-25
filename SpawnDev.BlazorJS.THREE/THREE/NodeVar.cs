
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class NodeVar : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public NodeVar(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, type: string, readOnly?: boolean, count?: number | null);
        /// </summary>
        public NodeVar(string name, string type, bool readOnly, float count) : base(JS.New("THREE.NodeVar", name, type, readOnly, count)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// count: number | null;
        /// </summary>
        public float Count { get => JSRef!.Get<float>("count"); set => JSRef!.Set("count", value); }
        /// <summary>
        /// readonly isNodeVar: true;
        /// </summary>
        public bool IsNodeVar { get => JSRef!.Get<bool>("isNodeVar"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// readOnly: boolean;
        /// </summary>
        public bool ReadOnly { get => JSRef!.Get<bool>("readOnly"); set => JSRef!.Set("readOnly", value); }
        /// <summary>
        /// type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); set => JSRef!.Set("type", value); }
        #endregion

        #region Methods

        #endregion
    }
}
