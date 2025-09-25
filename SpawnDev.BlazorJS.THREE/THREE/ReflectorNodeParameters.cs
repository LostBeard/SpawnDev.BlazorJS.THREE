
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface ReflectorNodeParameters
    {
        #region Properties
        /// <summary>
        /// bounces?: boolean | undefined;
        /// </summary>
        bool? Bounces { get; set; }
        /// <summary>
        /// depth?: boolean | undefined;
        /// </summary>
        bool? Depth { get; set; }
        /// <summary>
        /// generateMipmaps?: boolean | undefined;
        /// </summary>
        bool? GenerateMipmaps { get; set; }
        /// <summary>
        /// resolution?: number | undefined;
        /// </summary>
        float? Resolution { get; set; }
        /// <summary>
        /// resolutionScale?: number | undefined;
        /// </summary>
        float? ResolutionScale { get; set; }
        /// <summary>
        /// samples?: number | undefined;
        /// </summary>
        float? Samples { get; set; }
        /// <summary>
        /// target?: Object3D | undefined;
        /// </summary>
        Object3D? Target { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
