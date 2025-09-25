
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class EventNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public EventNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(eventType: EventNodeType, callback: (frame: NodeFrame) => void);
        /// </summary>
        public EventNode(EventNodeType eventType, Callback callback, NodeFrame frame) : base(JS.New("THREE.EventNode", eventType, callback, frame)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// callback: (frame: NodeFrame) => void;
        /// </summary>
        public ActionCallback<NodeFrame> Callback { get => JSRef!.Get<ActionCallback<NodeFrame>>("callback"); set => JSRef!.Set("callback", value); }
        /// <summary>
        /// eventType: EventNodeType;
        /// </summary>
        public EventNodeType EventType { get => JSRef!.Get<EventNodeType>("eventType"); set => JSRef!.Set("eventType", value); }
        /// <summary>
        /// static MATERIAL: "material";
        /// </summary>
        public static string MATERIAL { get => JS.Get<string>("THREE.EventNode.MATERIAL"); set => JS.Set("THREE.EventNode.MATERIAL", value); }
        /// <summary>
        /// static OBJECT: "object";
        /// </summary>
        public static string OBJECT { get => JS.Get<string>("THREE.EventNode.OBJECT"); set => JS.Set("THREE.EventNode.OBJECT", value); }
        #endregion

        #region Methods

        #endregion
    }
}
