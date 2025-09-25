
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Float32BufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Float32BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(
        ///         array: Iterable<number> | ArrayLike<number> | ArrayBuffer | number,
        ///         itemSize: number,
        ///         normalized?: boolean,
        ///     );
        /// </summary>
        public Float32BufferAttribute(Union<IEnumerable<float>, ArrayBuffer, float> array, float itemSize, bool normalized) : base(JS.New("THREE.Float32BufferAttribute", array, itemSize, normalized)) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
