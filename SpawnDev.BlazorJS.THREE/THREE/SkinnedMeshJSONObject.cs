namespace SpawnDev.BlazorJS.THREE
{
    public interface SkinnedMeshJSONObject : MeshJSONObject
    {
        #region Properties
        /// <summary>
        /// bindMatrix: Matrix4Tuple;
        /// </summary>
        Matrix4Tuple? BindMatrix { get; set; }
        /// <summary>
        /// bindMode: BindMode;
        /// </summary>
        BindMode? BindMode { get; set; }
        /// <summary>
        /// skeleton?: string;
        /// </summary>
        string? Skeleton { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
