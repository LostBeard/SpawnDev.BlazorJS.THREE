namespace SpawnDev.BlazorJS.THREE
{
    public interface InstancedMeshJSONObject : MeshJSONObject
    {
        #region Properties
        /// <summary>
        /// count: number;
        /// </summary>
        float? Count { get; set; }
        /// <summary>
        /// instanceColor?: BufferAttributeJSON;
        /// </summary>
        BufferAttributeJSON? InstanceColor { get; set; }
        /// <summary>
        /// instanceMatrix: BufferAttributeJSON;
        /// </summary>
        BufferAttributeJSON? InstanceMatrix { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
