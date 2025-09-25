
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Int8BufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Int8BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         array: Iterable<number> | ArrayLike<number> | ArrayBuffer | number,
        ///         itemSize: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public Int8BufferAttribute(Union<IEnumerable<float>, ArrayLikeFloat, ArrayBuffer, float> array, float itemSize, bool normalized) : base(JS.New("THREE.Int8BufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
