
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class BufferGeometry : EventDispatcher
    {
        #region Constructors
        /// <inheritdoc/>
        public BufferGeometry(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public BufferGeometry() : base(JS.New("THREE.BufferGeometry")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// attributes: Attributes;
        /// </summary>
        public Attributes Attributes { get => JSRef!.Get<Attributes>("attributes"); set => JSRef!.Set("attributes", value); }
        /// <summary>
        /// boundingBox: Box3 | null;
        /// </summary>
        public Box3 BoundingBox { get => JSRef!.Get<Box3>("boundingBox"); set => JSRef!.Set("boundingBox", value); }
        /// <summary>
        /// boundingSphere: Sphere | null;
        /// </summary>
        public Sphere BoundingSphere { get => JSRef!.Get<Sphere>("boundingSphere"); set => JSRef!.Set("boundingSphere", value); }
        /// <summary>
        /// drawRange: { start: number; count: number };
        /// </summary>
        public object DrawRange { get => JSRef!.Get<object>("drawRange"); set => JSRef!.Set("drawRange", value); }
        /// <summary>
        /// groups: GeometryGroup[];
        /// </summary>
        public Array<GeometryGroup> Groups { get => JSRef!.Get<Array<GeometryGroup>>("groups"); set => JSRef!.Set("groups", value); }
        /// <summary>
        /// id: number;
        /// </summary>
        public float Id { get => JSRef!.Get<float>("id"); set => JSRef!.Set("id", value); }
        /// <summary>
        /// index: BufferAttribute | null;
        /// </summary>
        public BufferAttribute Index { get => JSRef!.Get<BufferAttribute>("index"); set => JSRef!.Set("index", value); }
        /// <summary>
        /// indirect: IndirectStorageBufferAttribute | null;
        /// </summary>
        public IndirectStorageBufferAttribute Indirect { get => JSRef!.Get<IndirectStorageBufferAttribute>("indirect"); set => JSRef!.Set("indirect", value); }
        /// <summary>
        /// readonly isBufferGeometry: true;
        /// </summary>
        public bool IsBufferGeometry { get => JSRef!.Get<bool>("isBufferGeometry"); }
        /// <summary>
        /// morphAttributes: {
                ///         position?: Array<BufferAttribute | InterleavedBufferAttribute> | undefined;
                ///         normal?: Array<BufferAttribute | InterleavedBufferAttribute> | undefined;
                ///         color?: Array<BufferAttribute | InterleavedBufferAttribute> | undefined;
                ///     };
        /// </summary>
        public object MorphAttributes { get => JSRef!.Get<object>("morphAttributes"); set => JSRef!.Set("morphAttributes", value); }
        /// <summary>
        /// morphTargetsRelative: boolean;
        /// </summary>
        public bool MorphTargetsRelative { get => JSRef!.Get<bool>("morphTargetsRelative"); set => JSRef!.Set("morphTargetsRelative", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// readonly type: string | "BufferGeometry";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        /// <summary>
        /// userData: Record<string, any>;
        /// </summary>
        public Record<string, object> UserData { get => JSRef!.Get<Record<string, object>>("userData"); set => JSRef!.Set("userData", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        #endregion

        #region Methods
        /// <summary>
        /// translate(x: number, y: number, z: number): this;
        /// </summary>
        public BufferGeometry Translate(float x, float y, float z)
        {
            return JSRef!.Call<BufferGeometry>("translate", x, y, z);
        }
        /// <summary>
        /// toNonIndexed(): BufferGeometry;
        /// </summary>
        public BufferGeometry ToNonIndexed()
        {
            return JSRef!.Call<BufferGeometry>("toNonIndexed");
        }
        /// <summary>
        /// toJSON(): BufferGeometryJSON;
        /// </summary>
        public BufferGeometryJSON ToJSON()
        {
            return JSRef!.Call<BufferGeometryJSON>("toJSON");
        }
        /// <summary>
        /// setIndirect(indirect: IndirectStorageBufferAttribute | null): this;
        /// </summary>
        public BufferGeometry SetIndirect(IndirectStorageBufferAttribute indirect)
        {
            return JSRef!.Call<BufferGeometry>("setIndirect", indirect);
        }
        /// <summary>
        /// setIndex(index: BufferAttribute | number[] | null): this;
        /// </summary>
        public BufferGeometry SetIndex(Union<BufferAttribute, Array<float>> index)
        {
            return JSRef!.Call<BufferGeometry>("setIndex", index);
        }
        /// <summary>
        /// setFromPoints(points: Vector3[] | Vector2[]): this;
        /// </summary>
        public BufferGeometry SetFromPoints(Union<Array<Vector3>, Array<Vector2>> points)
        {
            return JSRef!.Call<BufferGeometry>("setFromPoints", points);
        }
        /// <summary>
        /// setDrawRange(start: number, count: number): void;
        /// </summary>
        public void SetDrawRange(float start, float count)
        {
            JSRef!.CallVoid("setDrawRange", start, count);
        }
        /// <summary>
        /// setAttribute<K extends keyof Attributes>(name: K, attribute: Attributes[K]): this;
        /// </summary>
        public BufferGeometry SetAttribute<K>(K name, object attribute)
        {
            return JSRef!.Call<BufferGeometry>("setAttribute", name, attribute);
        }
        /// <summary>
        /// scale(x: number, y: number, z: number): this;
        /// </summary>
        public BufferGeometry Scale(float x, float y, float z)
        {
            return JSRef!.Call<BufferGeometry>("scale", x, y, z);
        }
        /// <summary>
        /// rotateZ(angle: number): this;
        /// </summary>
        public BufferGeometry RotateZ(float angle)
        {
            return JSRef!.Call<BufferGeometry>("rotateZ", angle);
        }
        /// <summary>
        /// rotateY(angle: number): this;
        /// </summary>
        public BufferGeometry RotateY(float angle)
        {
            return JSRef!.Call<BufferGeometry>("rotateY", angle);
        }
        /// <summary>
        /// rotateX(angle: number): this;
        /// </summary>
        public BufferGeometry RotateX(float angle)
        {
            return JSRef!.Call<BufferGeometry>("rotateX", angle);
        }
        /// <summary>
        /// normalizeNormals(): void;
        /// </summary>
        public void NormalizeNormals()
        {
            JSRef!.CallVoid("normalizeNormals");
        }
        /// <summary>
        /// lookAt(vector: Vector3): this;
        /// </summary>
        public BufferGeometry LookAt(Vector3 vector)
        {
            return JSRef!.Call<BufferGeometry>("lookAt", vector);
        }
        /// <summary>
        /// hasAttribute(name: keyof Attributes): boolean;
        /// </summary>
        public bool HasAttribute(Attributes name)
        {
            return JSRef!.Call<bool>("hasAttribute", name);
        }
        /// <summary>
        /// getIndirect(): IndirectStorageBufferAttribute | null;
        /// </summary>
        public IndirectStorageBufferAttribute GetIndirect()
        {
            return JSRef!.Call<IndirectStorageBufferAttribute>("getIndirect");
        }
        /// <summary>
        /// getIndex(): BufferAttribute | null;
        /// </summary>
        public BufferAttribute GetIndex()
        {
            return JSRef!.Call<BufferAttribute>("getIndex");
        }
        /// <summary>
        /// getAttribute<K extends keyof Attributes>(name: K): Attributes[K];
        /// </summary>
        public object GetAttribute<K>(K name)
        {
            return JSRef!.Call<object>("getAttribute", name);
        }
        /// <summary>
        /// dispose(): void;
        /// </summary>
        public void DisposeJS()
        {
            JSRef!.CallVoid("dispose");
        }
        /// <summary>
        /// deleteAttribute(name: keyof Attributes): this;
        /// </summary>
        public BufferGeometry DeleteAttribute(Attributes name)
        {
            return JSRef!.Call<BufferGeometry>("deleteAttribute", name);
        }
        /// <summary>
        /// copy(source: BufferGeometry): this;
        /// </summary>
        public BufferGeometry Copy(BufferGeometry source)
        {
            return JSRef!.Call<BufferGeometry>("copy", source);
        }
        /// <summary>
        /// computeVertexNormals(): void;
        /// </summary>
        public void ComputeVertexNormals()
        {
            JSRef!.CallVoid("computeVertexNormals");
        }
        /// <summary>
        /// computeTangents(): void;
        /// </summary>
        public void ComputeTangents()
        {
            JSRef!.CallVoid("computeTangents");
        }
        /// <summary>
        /// computeBoundingSphere(): void;
        /// </summary>
        public void ComputeBoundingSphere()
        {
            JSRef!.CallVoid("computeBoundingSphere");
        }
        /// <summary>
        /// computeBoundingBox(): void;
        /// </summary>
        public void ComputeBoundingBox()
        {
            JSRef!.CallVoid("computeBoundingBox");
        }
        /// <summary>
        /// clone(): this;
        /// </summary>
        public BufferGeometry Clone()
        {
            return JSRef!.Call<BufferGeometry>("clone");
        }
        /// <summary>
        /// clearGroups(): void;
        /// </summary>
        public void ClearGroups()
        {
            JSRef!.CallVoid("clearGroups");
        }
        /// <summary>
        /// center(): this;
        /// </summary>
        public BufferGeometry Center()
        {
            return JSRef!.Call<BufferGeometry>("center");
        }
        /// <summary>
        /// applyQuaternion(quaternion: Quaternion): this;
        /// </summary>
        public BufferGeometry ApplyQuaternion(Quaternion quaternion)
        {
            return JSRef!.Call<BufferGeometry>("applyQuaternion", quaternion);
        }
        /// <summary>
        /// applyMatrix4(matrix: Matrix4): this;
        /// </summary>
        public BufferGeometry ApplyMatrix4(Matrix4 matrix)
        {
            return JSRef!.Call<BufferGeometry>("applyMatrix4", matrix);
        }
        /// <summary>
        /// addGroup(start: number, count: number, materialIndex?: number): void;
        /// </summary>
        public void AddGroup(float start, float count, float materialIndex)
        {
            JSRef!.CallVoid("addGroup", start, count, materialIndex);
        }
        #endregion
    }
}
