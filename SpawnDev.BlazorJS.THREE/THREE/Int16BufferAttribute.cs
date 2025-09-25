
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Int16BufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Int16BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         array: Iterable<number> | ArrayLike<number> | ArrayBuffer | number,
        ///         itemSize: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public Int16BufferAttribute(Union<IEnumerable<float>, ArrayLikeFloat, ArrayBuffer, float> array, float itemSize, bool normalized) : base(JS.New("THREE.Int16BufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
