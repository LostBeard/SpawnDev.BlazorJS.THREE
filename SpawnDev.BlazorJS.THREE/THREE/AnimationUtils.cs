
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class AnimationUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public AnimationUtils(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static subclip(
        ///         sourceClip: AnimationClip,
        ///         name: string,
        ///         startFrame: number,
        ///         endFrame: number,
        ///         fps?: number,
        ///     ): AnimationClip;
        /// </summary>
        public AnimationClip Subclip(AnimationClip sourceClip, string name, float startFrame, float endFrame, float fps)
        {
            return JSRef!.Call<AnimationClip>("subclip", sourceClip, name, startFrame, endFrame, fps);
        }
        /// <summary>
        /// static sortedArray(values: Array<number>, stride: number, order: Array<number>): Array<number>;
        /// </summary>
        public Array<float> SortedArray(Array<float> values, float stride, Array<float> order)
        {
            return JSRef!.Call<Array<float>>("sortedArray", values, stride, order);
        }
        /// <summary>
        /// static makeClipAdditive(
        ///         targetClip: AnimationClip,
        ///         referenceFrame?: number,
        ///         referenceClip?: AnimationClip,
        ///         fps?: number,
        ///     ): AnimationClip;
        /// </summary>
        public AnimationClip MakeClipAdditive(AnimationClip targetClip, float referenceFrame, AnimationClip referenceClip, float fps)
        {
            return JSRef!.Call<AnimationClip>("makeClipAdditive", targetClip, referenceFrame, referenceClip, fps);
        }
        /// <summary>
        /// static isTypedArray(object: object): boolean;
        /// </summary>
        public bool IsTypedArray(object obj)
        {
            return JSRef!.Call<bool>("isTypedArray", obj);
        }
        /// <summary>
        /// static getKeyframeOrder(times: Array<number>): Array<number>;
        /// </summary>
        public Array<float> GetKeyframeOrder(Array<float> times)
        {
            return JSRef!.Call<Array<float>>("getKeyframeOrder", times);
        }
        /// <summary>
        /// static flattenJSON(
        ///         jsonKeys: Array<number>,
        ///         times: Array<number>,
        ///         values: Array<number>,
        ///         valuePropertyName: string,
        ///     ): void;
        /// </summary>
        public void FlattenJSON(Array<float> jsonKeys, Array<float> times, Array<float> values, string valuePropertyName)
        {
            JSRef!.CallVoid("flattenJSON", jsonKeys, times, values, valuePropertyName);
        }
        /// <summary>
        /// static convertArray(array: TypedArray | number[], type: TypedArrayConstructor): TypedArray | number[];
        /// </summary>
        public Union<TypedArray, Array<float>> ConvertArray(Union<TypedArray, Array<float>> array, TypedArrayConstructor type)
        {
            return JSRef!.Call<Union<TypedArray, Array<float>>>("convertArray", array, type);
        }
        #endregion
    }
}
