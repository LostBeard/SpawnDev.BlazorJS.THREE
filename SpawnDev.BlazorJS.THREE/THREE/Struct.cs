
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public interface Struct
    {
        #region Properties
        /// <summary>
        /// isStruct: true;
        /// </summary>
        bool? IsStruct { get; set; }
        /// <summary>
        /// layout: StructTypeNode;
        /// </summary>
        StructTypeNode? Layout { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
