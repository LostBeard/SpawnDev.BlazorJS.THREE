
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface MemberLayout
    {
        #region Properties
        /// <summary>
        /// atomic: boolean;
        /// </summary>
        bool? Atomic { get; set; }
        /// <summary>
        /// name: string;
        /// </summary>
        string? Name { get; set; }
        /// <summary>
        /// type: string;
        /// </summary>
        string? Type { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
