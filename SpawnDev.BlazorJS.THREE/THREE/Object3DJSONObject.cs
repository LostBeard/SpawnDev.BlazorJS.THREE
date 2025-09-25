
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Object3DJSONObject
    {
        #region Properties
        /// <summary>
        /// animations?: string[];
        /// </summary>
        Array<string>? Animations { get; set; }
        /// <summary>
        /// castShadow?: boolean;
        /// </summary>
        bool? CastShadow { get; set; }
        /// <summary>
        /// children?: string[];
        /// </summary>
        Array<string>? Children { get; set; }
        /// <summary>
        /// frustumCulled?: boolean;
        /// </summary>
        bool? FrustumCulled { get; set; }
        /// <summary>
        /// layers: number;
        /// </summary>
        float? Layers { get; set; }
        /// <summary>
        /// material?: string | string[];
        /// </summary>
        Union<string, Array<string>>? Material { get; set; }
        /// <summary>
        /// matrix: Matrix4Tuple;
        /// </summary>
        Matrix4Tuple? Matrix { get; set; }
        /// <summary>
        /// matrixAutoUpdate?: boolean;
        /// </summary>
        bool? MatrixAutoUpdate { get; set; }
        /// <summary>
        /// name?: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// receiveShadow?: boolean;
        /// </summary>
        bool? ReceiveShadow { get; set; }
        /// <summary>
        /// renderOrder?: number;
        /// </summary>
        float? RenderOrder { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// up: Vector3Tuple;
        /// </summary>
        Vector3Tuple? Up { get; set; }
        /// <summary>
        /// userData?: Record<string, object>;
        /// </summary>
        Record<string, object>? UserData { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        /// <summary>
        /// visible?: boolean;
        /// </summary>
        bool? Visible { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
