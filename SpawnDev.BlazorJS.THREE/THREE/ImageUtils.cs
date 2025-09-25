
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class ImageUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public ImageUtils(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static sRGBToLinear(image: HTMLImageElement | HTMLCanvasElement | ImageBitmap): HTMLCanvasElement;
        /// </summary>
        public HTMLCanvasElement SRGBToLinear(Union<HTMLImageElement, HTMLCanvasElement, ImageBitmap> image)
        {
            return JSRef!.Call<HTMLCanvasElement>("sRGBToLinear", image);
        }
        /// <summary>
        /// static sRGBToLinear(image: ImageData): {
        ///         data: ImageData["data"];
        ///         width: ImageData["width"];
        ///         height: ImageData["height"];
        ///     };
        /// </summary>
        public object SRGBToLinear(ImageData image)
        {
            return JSRef!.Call<object>("sRGBToLinear", image);
        }
        /// <summary>
        /// static getDataURL(
        ///         image: HTMLImageElement | HTMLCanvasElement | CanvasImageSource | ImageBitmap | ImageData,
        ///         type?: string,
        ///     ): string;
        /// </summary>
        public string GetDataURL(Union<HTMLImageElement, HTMLCanvasElement, CanvasImageSource, ImageBitmap, ImageData> image, string type)
        {
            return JSRef!.Call<string>("getDataURL", image, type);
        }
        #endregion
    }
}
