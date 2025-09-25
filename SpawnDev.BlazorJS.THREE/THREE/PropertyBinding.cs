
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PropertyBinding : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public PropertyBinding(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(rootNode: Object3D | Skeleton, path: string, parsedPath?: object | null);
        /// </summary>
        public PropertyBinding(Union<Object3D, Skeleton> rootNode, string path, object parsedPath) : base(JS.New("THREE.PropertyBinding", rootNode, path, parsedPath)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// node: object | null;
        /// </summary>
        public object Node { get => JSRef!.Get<object>("node"); set => JSRef!.Set("node", value); }
        /// <summary>
        /// parsedPath: object;
        /// </summary>
        public object ParsedPath { get => JSRef!.Get<object>("parsedPath"); set => JSRef!.Set("parsedPath", value); }
        /// <summary>
        /// path: string;
        /// </summary>
        public string Path { get => JSRef!.Get<string>("path"); set => JSRef!.Set("path", value); }
        /// <summary>
        /// rootNode: Object3D | Skeleton;
        /// </summary>
        public Union<Object3D, Skeleton> RootNode { get => JSRef!.Get<Union<Object3D, Skeleton>>("rootNode"); set => JSRef!.Set("rootNode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// unbind(): void;
        /// </summary>
        public void Unbind()
        {
            JSRef!.CallVoid("unbind");
        }
        /// <summary>
        /// static sanitizeNodeName(name: string): string;
        /// </summary>
        public string SanitizeNodeName(string name)
        {
            return JSRef!.Call<string>("sanitizeNodeName", name);
        }
        /// <summary>
        /// static parseTrackName(trackName: string): ParseTrackNameResults;
        /// </summary>
        public ParseTrackNameResults ParseTrackName(string trackName)
        {
            return JSRef!.Call<ParseTrackNameResults>("parseTrackName", trackName);
        }
        /// <summary>
        /// static findNode(root: object, nodeName: string | number): object | null;
        /// </summary>
        public object FindNode(object root, Union<string, float> nodeName)
        {
            return JSRef!.Call<object>("findNode", root, nodeName);
        }
        /// <summary>
        /// static create(root: object, path: string, parsedPath?: object | null): PropertyBinding | Composite;
        /// </summary>
        public Union<PropertyBinding, Composite> Create(object root, string path, object parsedPath)
        {
            return JSRef!.Call<Union<PropertyBinding, Composite>>("create", root, path, parsedPath);
        }
        /// <summary>
        /// bind(): void;
        /// </summary>
        public void Bind()
        {
            JSRef!.CallVoid("bind");
        }
        #endregion
    }
}
