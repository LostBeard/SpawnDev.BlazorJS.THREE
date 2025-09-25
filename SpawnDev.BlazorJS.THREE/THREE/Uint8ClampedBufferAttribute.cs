
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Uint8ClampedBufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Uint8ClampedBufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         array: Iterable<number> | ArrayLike<number> | ArrayBuffer | number,
        ///         itemSize: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public Uint8ClampedBufferAttribute(Union<IEnumerable<float>, ArrayLikeFloat, ArrayBuffer, float> array, float itemSize, bool normalized) : base(JS.New("THREE.Uint8ClampedBufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
