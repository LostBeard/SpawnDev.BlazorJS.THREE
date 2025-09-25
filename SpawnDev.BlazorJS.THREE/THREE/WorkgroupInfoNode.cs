
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class WorkgroupInfoNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public WorkgroupInfoNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope: string, bufferType: string, bufferCount?: number);
        /// </summary>
        public WorkgroupInfoNode(string scope, string bufferType, float bufferCount) : base(JS.New("THREE.WorkgroupInfoNode", scope, bufferType, bufferCount)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bufferCount: number;
        /// </summary>
        public float BufferCount { get => JSRef!.Get<float>("bufferCount"); set => JSRef!.Set("bufferCount", value); }
        /// <summary>
        /// bufferType: string;
        /// </summary>
        public string BufferType { get => JSRef!.Get<string>("bufferType"); set => JSRef!.Set("bufferType", value); }
        /// <summary>
        /// elementType: string;
        /// </summary>
        public string ElementType { get => JSRef!.Get<string>("elementType"); set => JSRef!.Set("elementType", value); }
        /// <summary>
        /// readonly isWorkgroupInfoNode: true;
        /// </summary>
        public bool IsWorkgroupInfoNode { get => JSRef!.Get<bool>("isWorkgroupInfoNode"); }
        /// <summary>
        /// scope: string;
        /// </summary>
        public string Scope { get => JSRef!.Get<string>("scope"); set => JSRef!.Set("scope", value); }
        #endregion

        #region Methods

        #endregion
    }
}
