
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class PerspectiveCamera : Camera
    {
        #region Constructors
        /// <inheritdoc/>
        public PerspectiveCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(fov?: number, aspect?: number, near?: number, far?: number);
        /// </summary>
        public PerspectiveCamera(float fov, float aspect, float near, float far) : base(JS.New("THREE.PerspectiveCamera", fov, aspect, near, far)) { }
        public PerspectiveCamera(float fov, float aspect, float near) : base(JS.New("THREE.PerspectiveCamera", fov, aspect, near)) { }
        public PerspectiveCamera(float fov, float aspect) : base(JS.New("THREE.PerspectiveCamera", fov, aspect)) { }
        public PerspectiveCamera(float fov) : base(JS.New("THREE.PerspectiveCamera", fov)) { }
        public PerspectiveCamera() : base(JS.New("THREE.PerspectiveCamera")) { }

        #endregion

        #region Properties
        /// <summary>
        /// aspect: number;
        /// </summary>
        public float Aspect { get => JSRef!.Get<float>("aspect"); set => JSRef!.Set("aspect", value); }
        /// <summary>
        /// far: number;
        /// </summary>
        public float Far { get => JSRef!.Get<float>("far"); set => JSRef!.Set("far", value); }
        /// <summary>
        /// filmGauge: number;
        /// </summary>
        public float FilmGauge { get => JSRef!.Get<float>("filmGauge"); set => JSRef!.Set("filmGauge", value); }
        /// <summary>
        /// filmOffset: number;
        /// </summary>
        public float FilmOffset { get => JSRef!.Get<float>("filmOffset"); set => JSRef!.Set("filmOffset", value); }
        /// <summary>
        /// focus: number;
        /// </summary>
        public float Focus { get => JSRef!.Get<float>("focus"); set => JSRef!.Set("focus", value); }
        /// <summary>
        /// fov: number;
        /// </summary>
        public float Fov { get => JSRef!.Get<float>("fov"); set => JSRef!.Set("fov", value); }
        /// <summary>
        /// readonly isPerspectiveCamera: true;
        /// </summary>
        public bool IsPerspectiveCamera { get => JSRef!.Get<bool>("isPerspectiveCamera"); }
        /// <summary>
        /// near: number;
        /// </summary>
        public float Near { get => JSRef!.Get<float>("near"); set => JSRef!.Set("near", value); }
        /// <summary>
        /// override readonly type: string | "PerspectiveCamera";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// view: null | {
                ///         enabled: boolean;
                ///         fullWidth: number;
                ///         fullHeight: number;
                ///         offsetX: number;
                ///         offsetY: number;
                ///         width: number;
                ///         height: number;
                ///     };
        /// </summary>
        public object View { get => JSRef!.Get<object>("view"); set => JSRef!.Set("view", value); }
        /// <summary>
        /// zoom: number;
        /// </summary>
        public float Zoom { get => JSRef!.Get<float>("zoom"); set => JSRef!.Set("zoom", value); }
        #endregion

        #region Methods
        /// <summary>
        /// updateProjectionMatrix(): void;
        /// </summary>
        public void UpdateProjectionMatrix()
        {
            JSRef!.CallVoid("updateProjectionMatrix");
        }
        /// <summary>
        /// toJSON(meta?: JSONMeta): PerspectiveCameraJSON;
        /// </summary>
        public PerspectiveCameraJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<PerspectiveCameraJSON>("toJSON", meta);
        }
        /// <summary>
        /// setViewOffset(fullWidth: number, fullHeight: number, x: number, y: number, width: number, height: number): void;
        /// </summary>
        public void SetViewOffset(float fullWidth, float fullHeight, float x, float y, float width, float height)
        {
            JSRef!.CallVoid("setViewOffset", fullWidth, fullHeight, x, y, width, height);
        }
        /// <summary>
        /// setLens(focalLength: number, frameHeight?: number): void;
        /// </summary>
        public void SetLens(float focalLength, float frameHeight)
        {
            JSRef!.CallVoid("setLens", focalLength, frameHeight);
        }
        /// <summary>
        /// setFocalLength(focalLength: number): void;
        /// </summary>
        public void SetFocalLength(float focalLength)
        {
            JSRef!.CallVoid("setFocalLength", focalLength);
        }
        /// <summary>
        /// getViewSize(distance: number, target: Vector2): Vector2;
        /// </summary>
        public Vector2 GetViewSize(float distance, Vector2 target)
        {
            return JSRef!.Call<Vector2>("getViewSize", distance, target);
        }
        /// <summary>
        /// getViewBounds(distance: number, minTarget: Vector2, maxTarget: Vector2): void;
        /// </summary>
        public void GetViewBounds(float distance, Vector2 minTarget, Vector2 maxTarget)
        {
            JSRef!.CallVoid("getViewBounds", distance, minTarget, maxTarget);
        }
        /// <summary>
        /// getFocalLength(): number;
        /// </summary>
        public float GetFocalLength()
        {
            return JSRef!.Call<float>("getFocalLength");
        }
        /// <summary>
        /// getFilmWidth(): number;
        /// </summary>
        public float GetFilmWidth()
        {
            return JSRef!.Call<float>("getFilmWidth");
        }
        /// <summary>
        /// getFilmHeight(): number;
        /// </summary>
        public float GetFilmHeight()
        {
            return JSRef!.Call<float>("getFilmHeight");
        }
        /// <summary>
        /// getEffectiveFOV(): number;
        /// </summary>
        public float GetEffectiveFOV()
        {
            return JSRef!.Call<float>("getEffectiveFOV");
        }
        /// <summary>
        /// clearViewOffset(): void;
        /// </summary>
        public void ClearViewOffset()
        {
            JSRef!.CallVoid("clearViewOffset");
        }
        #endregion
    }
}
