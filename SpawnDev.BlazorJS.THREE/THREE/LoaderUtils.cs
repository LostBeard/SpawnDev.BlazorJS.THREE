
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class LoaderUtils : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public LoaderUtils(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// static resolveURL(url: string, path: string): string;
        /// </summary>
        public string ResolveURL(string url, string path)
        {
            return JSRef!.Call<string>("resolveURL", url, path);
        }
        /// <summary>
        /// static extractUrlBase(url: string): string;
        /// </summary>
        public string ExtractUrlBase(string url)
        {
            return JSRef!.Call<string>("extractUrlBase", url);
        }
        #endregion
    }
}
