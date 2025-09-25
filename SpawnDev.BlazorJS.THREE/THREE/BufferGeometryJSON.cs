
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface BufferGeometryJSON
    {
        #region Properties
        /// <summary>
        /// data?: {
                ///         attributes: Record<string, BufferAttributeJSON>;
                /// 
                ///         index?: { type: string; array: number[] };
                /// 
                ///         morphAttributes?: Record<string, BufferAttributeJSON[]>;
                ///         morphTargetsRelative?: boolean;
                /// 
                ///         groups?: GeometryGroup[];
                /// 
                ///         boundingSphere?: { center: Vector3Tuple; radius: number };
                ///     };
        /// </summary>
        object? Data { get; set; }
        /// <summary>
        /// metadata?: { version: number; type: string; generator: string };
        /// </summary>
        object? Metadata { get; set; }
        /// <summary>
        /// name?: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// userData?: Record<string, object>;
        /// </summary>
        Record<string, object>? UserData { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
