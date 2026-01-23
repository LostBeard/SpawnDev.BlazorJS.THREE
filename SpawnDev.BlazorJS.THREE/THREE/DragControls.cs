using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// DragControls allows to drag objects in your scene.
    /// It enables click-and-drag interaction to move objects in 3D space.
    /// </summary>
    public class DragControls : Controls
    {
        #region Constructors
        /// <inheritdoc/>
        public DragControls(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a new DragControls instance
        /// </summary>
        /// <param name="objects">An array of draggable 3D Objects</param>
        /// <param name="camera">The camera of the rendered scene</param>
        /// <param name="domElement">The HTML element used for event listeners</param>
        public DragControls(Array<Object3D> objects, Camera camera, HTMLElement domElement) 
            : base(JS.New("DragControls", objects, camera, domElement)) { }

        /// <summary>
        /// Creates a new DragControls instance
        /// </summary>
        /// <param name="objects">An array of draggable 3D Objects (as JSObject array)</param>
        /// <param name="camera">The camera of the rendered scene</param>
        /// <param name="domElement">The HTML element used for event listeners</param>
        public DragControls(JSObject[] objects, Camera camera, HTMLElement domElement) 
            : base(JS.New("DragControls", objects, camera, domElement)) { }
        #endregion

        #region Properties
        /// <summary>
        /// Whether the controls are active. Default is true.
        /// </summary>
        public new bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }

        /// <summary>
        /// The internal raycaster used for picking
        /// </summary>
        public Raycaster Raycaster => JSRef!.Get<Raycaster>("raycaster");

        /// <summary>
        /// Whether children of draggable objects can be dragged independently. Default is true.
        /// </summary>
        public bool Recursive { get => JSRef!.Get<bool>("recursive"); set => JSRef!.Set("recursive", value); }

        /// <summary>
        /// This option only works if the DragControls.objects array contains a single draggable group object.
        /// If true, the group is transformed, otherwise the individual objects. Default is false.
        /// </summary>
        public bool TransformGroup { get => JSRef!.Get<bool>("transformGroup"); set => JSRef!.Set("transformGroup", value); }

        /// <summary>
        /// The mode of DragControls. Translate mode will move objects, rotate mode will be added in a future version.
        /// </summary>
        public string Mode { get => JSRef!.Get<string>("mode"); set => JSRef!.Set("mode", value); }
        #endregion

        #region Methods
        /// <summary>
        /// Activates the controls
        /// </summary>
        public void Activate()
        {
            JSRef!.CallVoid("activate");
        }

        /// <summary>
        /// Deactivates the controls
        /// </summary>
        public void Deactivate()
        {
            JSRef!.CallVoid("deactivate");
        }

        /// <summary>
        /// Returns the array of draggable objects
        /// </summary>
        public Object3D[] GetObjects()
        {
            return JSRef!.Call<Object3D[]>("getObjects");
        }

        /// <summary>
        /// Gets the raycaster used for picking
        /// </summary>
        public Raycaster GetRaycaster()
        {
            return JSRef!.Call<Raycaster>("getRaycaster");
        }
        #endregion

        #region Events
        /// <summary>
        /// Adds an event listener for drag events
        /// </summary>
        public void OnDragStart(ActionCallback<Event> callback)
        {
            AddEventListener("dragstart", callback);
        }

        /// <summary>
        /// Adds an event listener for drag events
        /// </summary>
        public void OnDrag(ActionCallback<Event> callback)
        {
            AddEventListener("drag", callback);
        }

        /// <summary>
        /// Adds an event listener for dragend events
        /// </summary>
        public void OnDragEnd(ActionCallback<Event> callback)
        {
            AddEventListener("dragend", callback);
        }

        /// <summary>
        /// Adds an event listener for hover start events
        /// </summary>
        public void OnHoverOn(ActionCallback<Event> callback)
        {
            AddEventListener("hoveron", callback);
        }

        /// <summary>
        /// Adds an event listener for hover end events
        /// </summary>
        public void OnHoverOff(ActionCallback<Event> callback)
        {
            AddEventListener("hoveroff", callback);
        }
        #endregion
    }
}
