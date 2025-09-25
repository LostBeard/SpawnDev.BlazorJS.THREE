
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class OrthographicCamera : Camera
    {
        #region Constructors
        /// <inheritdoc/>
        public OrthographicCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(left?: number, right?: number, top?: number, bottom?: number, near?: number, far?: number);
        /// </summary>
        public OrthographicCamera(float left, float right, float top, float bottom, float near, float far) : base(JS.New("THREE.OrthographicCamera", left, right, top, bottom, near, far)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// bottom: number;
        /// </summary>
        public float Bottom { get => JSRef!.Get<float>("bottom"); set => JSRef!.Set("bottom", value); }
        /// <summary>
        /// far: number;
        /// </summary>
        public float Far { get => JSRef!.Get<float>("far"); set => JSRef!.Set("far", value); }
        /// <summary>
        /// readonly isOrthographicCamera: true;
        /// </summary>
        public bool IsOrthographicCamera { get => JSRef!.Get<bool>("isOrthographicCamera"); }
        /// <summary>
        /// left: number;
        /// </summary>
        public float Left { get => JSRef!.Get<float>("left"); set => JSRef!.Set("left", value); }
        /// <summary>
        /// near: number;
        /// </summary>
        public float Near { get => JSRef!.Get<float>("near"); set => JSRef!.Set("near", value); }
        /// <summary>
        /// right: number;
        /// </summary>
        public float Right { get => JSRef!.Get<float>("right"); set => JSRef!.Set("right", value); }
        /// <summary>
        /// top: number;
        /// </summary>
        public float Top { get => JSRef!.Get<float>("top"); set => JSRef!.Set("top", value); }
        /// <summary>
        /// override readonly type: string | "OrthographicCamera";
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
        /// toJSON(meta?: JSONMeta): OrthographicCameraJSON;
        /// </summary>
        public OrthographicCameraJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<OrthographicCameraJSON>("toJSON", meta);
        }
        /// <summary>
        /// setViewOffset(
        ///         fullWidth: number,
        ///         fullHeight: number,
        ///         offsetX: number,
        ///         offsetY: number,
        ///         width: number,
        ///         height: number,
        ///     ): void;
        /// </summary>
        public void SetViewOffset(float fullWidth, float fullHeight, float offsetX, float offsetY, float width, float height)
        {
            JSRef!.CallVoid("setViewOffset", fullWidth, fullHeight, offsetX, offsetY, width, height);
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
