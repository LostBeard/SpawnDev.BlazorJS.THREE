
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Controls : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public Controls(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(object: Object3D, domElement?: HTMLElement | null);
        /// </summary>
        public Controls(Object3D obj, HTMLElement domElement) : base(JS.New("THREE.Controls", obj, domElement)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// domElement: HTMLElement | null;
        /// </summary>
        public HTMLElement DomElement { get => JSRef!.Get<HTMLElement>("domElement"); set => JSRef!.Set("domElement", value); }
        /// <summary>
        /// enabled: boolean;
        /// </summary>
        public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
        /// <summary>
        /// object: Object3D;
        /// </summary>
        public Object3D Object { get => JSRef!.Get<Object3D>("object"); set => JSRef!.Set("object", value); }
        #endregion

        #region Methods
        /// <summary>
        /// update(delta: number): void;
        /// </summary>
        public void Update(float delta)
        {
            JSRef!.CallVoid("update", delta);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// disconnect(): void;
        /// </summary>
        public void Disconnect()
        {
            JSRef!.CallVoid("disconnect");
        }
        /// <summary>
        /// connect(element: HTMLElement): void;
        /// </summary>
        public void Connect(HTMLElement element)
        {
            JSRef!.CallVoid("connect", element);
        }
        #endregion
    }
}
