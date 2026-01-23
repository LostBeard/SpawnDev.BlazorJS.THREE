using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Float32BufferAttribute : BufferAttribute
    {
        #region Constructors
        /// <inheritdoc/>
        public Float32BufferAttribute(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// Creates a Float32BufferAttribute from an array
        /// </summary>
        public Float32BufferAttribute(float[] array, int itemSize) : base(JS.New("THREE.Float32BufferAttribute", array, itemSize)) { }

        /// <summary>
        /// constructor(
        ///         array: Iterable&lt;number&gt; | ArrayLike&lt;number&gt; | ArrayBuffer | number,
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
