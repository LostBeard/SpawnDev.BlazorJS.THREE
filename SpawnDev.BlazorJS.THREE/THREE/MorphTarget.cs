using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MorphTarget
    {
        #region Properties
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// vertices: Vector3[];
        /// </summary>
        Array<Vector3>? Vertices { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
