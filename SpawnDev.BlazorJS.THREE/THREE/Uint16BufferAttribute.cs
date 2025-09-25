
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Uint16BufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Uint16BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         array: Iterable<number> | ArrayLike<number> | ArrayBuffer | number,
        ///         itemSize: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public Uint16BufferAttribute(Union<IEnumerable<float>, ArrayLikeFloat, ArrayBuffer, float> array, float itemSize, bool normalized) : base(JS.New("THREE.Uint16BufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
