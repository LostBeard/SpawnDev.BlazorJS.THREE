
using Microsoft.JSInterop;
using Microsoft.VisualBasic;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;
using System.Text;

namespace SpawnDev.BlazorJS.THREE
{
    public class Intersection<TIntersected> : Intersection
    {

    }
    public class Intersection
    {
        #region Properties
        /// <summary>
        /// barycoord?: Vector3 | null;
        /// </summary>
        Vector3? Barycoord { get; set; }
        /// <summary>
        /// batchId?: number;
        /// </summary>
        float? BatchId { get; set; }
        /// <summary>
        /// distance: number;
        /// </summary>
        float? Distance { get; set; }
        /// <summary>
        /// distanceToRay?: number | undefined;
        /// </summary>
        float? DistanceToRay { get; set; }
        /// <summary>
        /// face?: Face | null | undefined;
        /// </summary>
        Face? Face { get; set; }
        /// <summary>
        /// faceIndex?: number | null | undefined;
        /// </summary>
        float? FaceIndex { get; set; }
        /// <summary>
        /// index?: number | undefined;
        /// </summary>
        float? Index { get; set; }
        /// <summary>
        /// instanceId?: number | undefined;
        /// </summary>
        float? InstanceId { get; set; }
        /// <summary>
        /// normal?: Vector3;
        /// </summary>
        Vector3? Normal { get; set; }
        /// <summary>
        /// object: TIntersected;
        /// </summary>
        TIntersected? Object { get; set; }
        /// <summary>
        /// point: Vector3;
        /// </summary>
        Vector3? Point { get; set; }
        /// <summary>
        /// pointOnLine?: Vector3;
        /// </summary>
        Vector3? PointOnLine { get; set; }
        /// <summary>
        /// uv?: Vector2 | undefined;
        /// </summary>
        Vector2? Uv { get; set; }
        /// <summary>
        /// uv1?: Vector2 | undefined;
        /// </summary>
        Vector2? Uv1 { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
