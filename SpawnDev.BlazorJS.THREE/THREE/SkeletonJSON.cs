
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface SkeletonJSON
    {
        #region Properties
        /// <summary>
        /// boneInverses: Matrix4Tuple[];
        /// </summary>
        Array<Matrix4Tuple>? BoneInverses { get; set; }
        /// <summary>
        /// bones: string[];
        /// </summary>
        Array<string>? Bones { get; set; }
        /// <summary>
        /// metadata: { version: number; type: string; generator: string };
        /// </summary>
        object? Metadata { get; set; }
        /// <summary>
        /// uuid: string;
        /// </summary>
        string? Uuid { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
