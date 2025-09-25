
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ExtrudeGeometryOptions
    {
        #region Properties
        /// <summary>
        /// bevelEnabled?: boolean | undefined;
        /// </summary>
        bool? BevelEnabled { get; set; }
        /// <summary>
        /// bevelOffset?: number | undefined;
        /// </summary>
        float? BevelOffset { get; set; }
        /// <summary>
        /// bevelSegments?: number | undefined;
        /// </summary>
        float? BevelSegments { get; set; }
        /// <summary>
        /// bevelSize?: number | undefined;
        /// </summary>
        float? BevelSize { get; set; }
        /// <summary>
        /// bevelThickness?: number | undefined;
        /// </summary>
        float? BevelThickness { get; set; }
        /// <summary>
        /// curveSegments?: number | undefined;
        /// </summary>
        float? CurveSegments { get; set; }
        /// <summary>
        /// depth?: number | undefined;
        /// </summary>
        float? Depth { get; set; }
        /// <summary>
        /// extrudePath?: Curve<Vector3> | undefined;
        /// </summary>
        Curve<Vector3>? ExtrudePath { get; set; }
        /// <summary>
        /// steps?: number | undefined;
        /// </summary>
        float? Steps { get; set; }
        /// <summary>
        /// UVGenerator?: UVGenerator | undefined;
        /// </summary>
        UVGenerator? UVGenerator { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
