
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Object3D : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public Object3D(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Object3D() : base(JS.New("THREE.Object3D")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// animations: AnimationClip[];
        /// </summary>
        public Array<AnimationClip> Animations { get => JSRef!.Get<Array<AnimationClip>>("animations"); set => JSRef!.Set("animations", value); }
        /// <summary>
        /// castShadow: boolean;
        /// </summary>
        public bool CastShadow { get => JSRef!.Get<bool>("castShadow"); set => JSRef!.Set("castShadow", value); }
        /// <summary>
        /// children: Object3D[];
        /// </summary>
        public Array<Object3D> Children { get => JSRef!.Get<Array<Object3D>>("children"); set => JSRef!.Set("children", value); }
        /// <summary>
        /// customDepthMaterial?: Material | undefined;
        /// </summary>
        public Material CustomDepthMaterial { get => JSRef!.Get<Material>("customDepthMaterial"); set => JSRef!.Set("customDepthMaterial", value); }
        /// <summary>
        /// customDistanceMaterial?: Material | undefined;
        /// </summary>
        public Material CustomDistanceMaterial { get => JSRef!.Get<Material>("customDistanceMaterial"); set => JSRef!.Set("customDistanceMaterial", value); }
        /// <summary>
        /// static DEFAULT_MATRIX_AUTO_UPDATE: boolean;
        /// </summary>
        public static bool DEFAULT_MATRIX_AUTO_UPDATE { get => JS.Get<bool>("THREE.Object3D.DEFAULT_MATRIX_AUTO_UPDATE"); set => JS.Set("THREE.Object3D.DEFAULT_MATRIX_AUTO_UPDATE", value); }
        /// <summary>
        /// static DEFAULT_MATRIX_WORLD_AUTO_UPDATE: boolean;
        /// </summary>
        public static bool DEFAULT_MATRIX_WORLD_AUTO_UPDATE { get => JS.Get<bool>("THREE.Object3D.DEFAULT_MATRIX_WORLD_AUTO_UPDATE"); set => JS.Set("THREE.Object3D.DEFAULT_MATRIX_WORLD_AUTO_UPDATE", value); }
        /// <summary>
        /// static DEFAULT_UP: Vector3;
        /// </summary>
        public static Vector3 DEFAULT_UP { get => JS.Get<Vector3>("THREE.Object3D.DEFAULT_UP"); set => JS.Set("THREE.Object3D.DEFAULT_UP", value); }
        /// <summary>
        /// frustumCulled: boolean;
        /// </summary>
        public bool FrustumCulled { get => JSRef!.Get<bool>("frustumCulled"); set => JSRef!.Set("frustumCulled", value); }
        /// <summary>
        /// readonly id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); }
        /// <summary>
        /// readonly isObject3D: true;
        /// </summary>
        public bool IsObject3D { get => JSRef!.Get<bool>("isObject3D"); }
        /// <summary>
        /// layers: Layers;
        /// </summary>
        public Layers Layers { get => JSRef!.Get<Layers>("layers"); set => JSRef!.Set("layers", value); }
        /// <summary>
        /// matrix: Matrix4;
        /// </summary>
        public Matrix4 Matrix { get => JSRef!.Get<Matrix4>("matrix"); set => JSRef!.Set("matrix", value); }
        /// <summary>
        /// matrixAutoUpdate: boolean;
        /// </summary>
        public bool MatrixAutoUpdate { get => JSRef!.Get<bool>("matrixAutoUpdate"); set => JSRef!.Set("matrixAutoUpdate", value); }
        /// <summary>
        /// matrixWorld: Matrix4;
        /// </summary>
        public Matrix4 MatrixWorld { get => JSRef!.Get<Matrix4>("matrixWorld"); set => JSRef!.Set("matrixWorld", value); }
        /// <summary>
        /// matrixWorldAutoUpdate: boolean;
        /// </summary>
        public bool MatrixWorldAutoUpdate { get => JSRef!.Get<bool>("matrixWorldAutoUpdate"); set => JSRef!.Set("matrixWorldAutoUpdate", value); }
        /// <summary>
        /// matrixWorldNeedsUpdate: boolean;
        /// </summary>
        public bool MatrixWorldNeedsUpdate { get => JSRef!.Get<bool>("matrixWorldNeedsUpdate"); set => JSRef!.Set("matrixWorldNeedsUpdate", value); }
        /// <summary>
        /// readonly modelViewMatrix: Matrix4;
        /// </summary>
        public Matrix4 ModelViewMatrix { get => JSRef!.Get<Matrix4>("modelViewMatrix"); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// readonly normalMatrix: Matrix3;
        /// </summary>
        public Matrix3 NormalMatrix { get => JSRef!.Get<Matrix3>("normalMatrix"); }
        /// <summary>
        /// parent: Object3D | null;
        /// </summary>
        public Object3D Parent { get => JSRef!.Get<Object3D>("parent"); set => JSRef!.Set("parent", value); }
        /// <summary>
        /// readonly position: Vector3;
        /// </summary>
        public Vector3 Position { get => JSRef!.Get<Vector3>("position"); }
        /// <summary>
        /// readonly quaternion: Quaternion;
        /// </summary>
        public Quaternion Quaternion { get => JSRef!.Get<Quaternion>("quaternion"); }
        /// <summary>
        /// receiveShadow: boolean;
        /// </summary>
        public bool ReceiveShadow { get => JSRef!.Get<bool>("receiveShadow"); set => JSRef!.Set("receiveShadow", value); }
        /// <summary>
        /// renderOrder: number;
        /// </summary>
        public float RenderOrder { get => JSRef!.Get<float>("renderOrder"); set => JSRef!.Set("renderOrder", value); }
        /// <summary>
        /// readonly rotation: Euler;
        /// </summary>
        public Euler Rotation { get => JSRef!.Get<Euler>("rotation"); }
        /// <summary>
        /// readonly scale: Vector3;
        /// </summary>
        public Vector3 Scale { get => JSRef!.Get<Vector3>("scale"); }
        /// <summary>
        /// readonly type: string;
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// up: Vector3;
        /// </summary>
        public Vector3 Up { get => JSRef!.Get<Vector3>("up"); set => JSRef!.Set("up", value); }
        /// <summary>
        /// userData: Record<string, any>;
        /// </summary>
        public Record<string, object> UserData { get => JSRef!.Get<Record<string, object>>("userData"); set => JSRef!.Set("userData", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        /// <summary>
        /// visible: boolean;
        /// </summary>
        public bool Visible { get => JSRef!.Get<bool>("visible"); set => JSRef!.Set("visible", value); }
        #endregion

        #region Methods
        /// <summary>
        /// worldToLocal(vector: Vector3): Vector3;
        /// </summary>
        public Vector3 WorldToLocal(Vector3 vector)
        {
            return JSRef!.Call<Vector3>("worldToLocal", vector);
        }
        /// <summary>
        /// updateWorldMatrix(updateParents: boolean, updateChildren: boolean): void;
        /// </summary>
        public void UpdateWorldMatrix(bool updateParents, bool updateChildren)
        {
            JSRef!.CallVoid("updateWorldMatrix", updateParents, updateChildren);
        }
        /// <summary>
        /// updateMatrixWorld(force?: boolean): void;
        /// </summary>
        public void UpdateMatrixWorld(bool force)
        {
            JSRef!.CallVoid("updateMatrixWorld", force);
        }
        /// <summary>
        /// updateMatrix(): void;
        /// </summary>
        public void UpdateMatrix()
        {
            JSRef!.CallVoid("updateMatrix");
        }
        /// <summary>
        /// traverseVisible(callback: (object: Object3D) => any): void;
        /// </summary>
        public void TraverseVisible(Callback callback, Object3D obj)
        {
            JSRef!.CallVoid("traverseVisible", callback, obj);
        }
        /// <summary>
        /// traverseAncestors(callback: (object: Object3D) => any): void;
        /// </summary>
        public void TraverseAncestors(Callback callback, Object3D obj)
        {
            JSRef!.CallVoid("traverseAncestors", callback, obj);
        }
        /// <summary>
        /// traverse(callback: (object: Object3D) => any): void;
        /// </summary>
        public void Traverse(Callback callback, Object3D obj)
        {
            JSRef!.CallVoid("traverse", callback, obj);
        }
        /// <summary>
        /// translateZ(distance: number): this;
        /// </summary>
        public Object3D TranslateZ(float distance)
        {
            return JSRef!.Call<Object3D>("translateZ", distance);
        }
        /// <summary>
        /// translateY(distance: number): this;
        /// </summary>
        public Object3D TranslateY(float distance)
        {
            return JSRef!.Call<Object3D>("translateY", distance);
        }
        /// <summary>
        /// translateX(distance: number): this;
        /// </summary>
        public Object3D TranslateX(float distance)
        {
            return JSRef!.Call<Object3D>("translateX", distance);
        }
        /// <summary>
        /// translateOnAxis(axis: Vector3, distance: number): this;
        /// </summary>
        public Object3D TranslateOnAxis(Vector3 axis, float distance)
        {
            return JSRef!.Call<Object3D>("translateOnAxis", axis, distance);
        }
        /// <summary>
        /// toJSON(meta?: JSONMeta): Object3DJSON;
        /// </summary>
        public Object3DJSON ToJSON(JSONMeta meta)
        {
            return JSRef!.Call<Object3DJSON>("toJSON", meta);
        }
        /// <summary>
        /// setRotationFromQuaternion(q: Quaternion): void;
        /// </summary>
        public void SetRotationFromQuaternion(Quaternion q)
        {
            JSRef!.CallVoid("setRotationFromQuaternion", q);
        }
        /// <summary>
        /// setRotationFromMatrix(m: Matrix4): void;
        /// </summary>
        public void SetRotationFromMatrix(Matrix4 m)
        {
            JSRef!.CallVoid("setRotationFromMatrix", m);
        }
        /// <summary>
        /// setRotationFromEuler(euler: Euler): void;
        /// </summary>
        public void SetRotationFromEuler(Euler euler)
        {
            JSRef!.CallVoid("setRotationFromEuler", euler);
        }
        /// <summary>
        /// setRotationFromAxisAngle(axis: Vector3, angle: number): void;
        /// </summary>
        public void SetRotationFromAxisAngle(Vector3 axis, float angle)
        {
            JSRef!.CallVoid("setRotationFromAxisAngle", axis, angle);
        }
        /// <summary>
        /// rotateZ(angle: number): this;
        /// </summary>
        public Object3D RotateZ(float angle)
        {
            return JSRef!.Call<Object3D>("rotateZ", angle);
        }
        /// <summary>
        /// rotateY(angle: number): this;
        /// </summary>
        public Object3D RotateY(float angle)
        {
            return JSRef!.Call<Object3D>("rotateY", angle);
        }
        /// <summary>
        /// rotateX(angle: number): this;
        /// </summary>
        public Object3D RotateX(float angle)
        {
            return JSRef!.Call<Object3D>("rotateX", angle);
        }
        /// <summary>
        /// rotateOnWorldAxis(axis: Vector3, angle: number): this;
        /// </summary>
        public Object3D RotateOnWorldAxis(Vector3 axis, float angle)
        {
            return JSRef!.Call<Object3D>("rotateOnWorldAxis", axis, angle);
        }
        /// <summary>
        /// rotateOnAxis(axis: Vector3, angle: number): this;
        /// </summary>
        public Object3D RotateOnAxis(Vector3 axis, float angle)
        {
            return JSRef!.Call<Object3D>("rotateOnAxis", axis, angle);
        }
        /// <summary>
        /// removeFromParent(): this;
        /// </summary>
        public Object3D RemoveFromParent()
        {
            return JSRef!.Call<Object3D>("removeFromParent");
        }
        /// <summary>
        /// remove(...object: Object3D[]): this;
        /// </summary>
        public Object3D Remove(params Object3D[] obj)
        {
            JSRef!.CallApplyVoid("remove", obj);
            return this;
        }
        /// <summary>
        /// raycast(raycaster: Raycaster, intersects: Intersection[]): void;
        /// </summary>
        public void Raycast(Raycaster raycaster, Array<Intersection> intersects)
        {
            JSRef!.CallVoid("raycast", raycaster, intersects);
        }
        /// <summary>
        /// onBeforeShadow(
        ///         renderer: WebGLRenderer,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         shadowCamera: Camera,
        ///         geometry: BufferGeometry,
        ///         depthMaterial: Material,
        ///         group: Group,
        ///     ): void;
        /// </summary>
        public void OnBeforeShadow(WebGLRenderer renderer, Scene scene, Camera camera, Camera shadowCamera, BufferGeometry geometry, Material depthMaterial, Group group)
        {
            JSRef!.CallVoid("onBeforeShadow", renderer, scene, camera, shadowCamera, geometry, depthMaterial, group);
        }
        /// <summary>
        /// onBeforeRender(
        ///         renderer: WebGLRenderer,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         group: Group,
        ///     ): void;
        /// </summary>
        public void OnBeforeRender(WebGLRenderer renderer, Scene scene, Camera camera, BufferGeometry geometry, Material material, Group group)
        {
            JSRef!.CallVoid("onBeforeRender", renderer, scene, camera, geometry, material, group);
        }
        /// <summary>
        /// onAfterShadow(
        ///         renderer: WebGLRenderer,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         shadowCamera: Camera,
        ///         geometry: BufferGeometry,
        ///         depthMaterial: Material,
        ///         group: Group,
        ///     ): void;
        /// </summary>
        public void OnAfterShadow(WebGLRenderer renderer, Scene scene, Camera camera, Camera shadowCamera, BufferGeometry geometry, Material depthMaterial, Group group)
        {
            JSRef!.CallVoid("onAfterShadow", renderer, scene, camera, shadowCamera, geometry, depthMaterial, group);
        }
        /// <summary>
        /// onAfterRender(
        ///         renderer: WebGLRenderer,
        ///         scene: Scene,
        ///         camera: Camera,
        ///         geometry: BufferGeometry,
        ///         material: Material,
        ///         group: Group,
        ///     ): void;
        /// </summary>
        public void OnAfterRender(WebGLRenderer renderer, Scene scene, Camera camera, BufferGeometry geometry, Material material, Group group)
        {
            JSRef!.CallVoid("onAfterRender", renderer, scene, camera, geometry, material, group);
        }
        /// <summary>
        /// lookAt(vector: Vector3): void;
        /// </summary>
        public void LookAt(Vector3 vector)
        {
            JSRef!.CallVoid("lookAt", vector);
        }
        /// <summary>
        /// lookAt(x: number, y: number, z: number): void;
        /// </summary>
        public void LookAt(float x, float y, float z)
        {
            JSRef!.CallVoid("lookAt", x, y, z);
        }
        /// <summary>
        /// localToWorld(vector: Vector3): Vector3;
        /// </summary>
        public Vector3 LocalToWorld(Vector3 vector)
        {
            return JSRef!.Call<Vector3>("localToWorld", vector);
        }
        /// <summary>
        /// getWorldScale(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetWorldScale(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getWorldScale", target);
        }
        /// <summary>
        /// getWorldQuaternion(target: Quaternion): Quaternion;
        /// </summary>
        public Quaternion GetWorldQuaternion(Quaternion target)
        {
            return JSRef!.Call<Quaternion>("getWorldQuaternion", target);
        }
        /// <summary>
        /// getWorldPosition(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetWorldPosition(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getWorldPosition", target);
        }
        /// <summary>
        /// getWorldDirection(target: Vector3): Vector3;
        /// </summary>
        public Vector3 GetWorldDirection(Vector3 target)
        {
            return JSRef!.Call<Vector3>("getWorldDirection", target);
        }
        /// <summary>
        /// getObjectsByProperty(name: string, value: any, optionalTarget?: Object3D[]): Object3D[];
        /// </summary>
        public Array<Object3D> GetObjectsByProperty(string name, object value, Array<Object3D> optionalTarget)
        {
            return JSRef!.Call<Array<Object3D>>("getObjectsByProperty", name, value, optionalTarget);
        }
        /// <summary>
        /// getObjectByProperty(name: string, value: any): Object3D | undefined;
        /// </summary>
        public Object3D GetObjectByProperty(string name, object value)
        {
            return JSRef!.Call<Object3D>("getObjectByProperty", name, value);
        }
        /// <summary>
        /// getObjectByName(name: string): Object3D | undefined;
        /// </summary>
        public Object3D GetObjectByName(string name)
        {
            return JSRef!.Call<Object3D>("getObjectByName", name);
        }
        /// <summary>
        /// getObjectById(id: number): Object3D | undefined;
        /// </summary>
        public Object3D GetObjectById(float id)
        {
            return JSRef!.Call<Object3D>("getObjectById", id);
        }
        /// <summary>
        /// copy(object: Object3D, recursive?: boolean): this;
        /// </summary>
        public Object3D Copy(Object3D obj, bool recursive)
        {
            return JSRef!.Call<Object3D>("copy", obj, recursive);
        }
        /// <summary>
        /// clone(recursive?: boolean): this;
        /// </summary>
        public Object3D Clone(bool recursive)
        {
            return JSRef!.Call<Object3D>("clone", recursive);
        }
        /// <summary>
        /// clear(): this;
        /// </summary>
        public Object3D Clear()
        {
            return JSRef!.Call<Object3D>("clear");
        }
        /// <summary>
        /// attach(object: Object3D): this;
        /// </summary>
        public Object3D Attach(Object3D obj)
        {
            return JSRef!.Call<Object3D>("attach", obj);
        }
        /// <summary>
        /// applyQuaternion(quaternion: Quaternion): this;
        /// </summary>
        public Object3D ApplyQuaternion(Quaternion quaternion)
        {
            return JSRef!.Call<Object3D>("applyQuaternion", quaternion);
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4): void;
        /// </summary>
        public void ApplyMatrix4(Matrix4 matrix)
        {
            JSRef!.CallVoid("applyMatrix4", matrix);
        }
        /// <summary>
        /// add(...object: Object3D[]): this;
        /// </summary>
        public Object3D Add(params Object3D[] obj)
        {
            JSRef!.CallApplyVoid("add", obj);
            return this;
        }
        #endregion
    }
}
