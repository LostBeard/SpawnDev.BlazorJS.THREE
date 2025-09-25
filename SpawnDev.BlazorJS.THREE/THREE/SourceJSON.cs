
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class SourceJSON : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public SourceJSON(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties
        /// <summary>
        /// url: SerializedImage | SerializedImage[];
        /// </summary>
        public Union<SerializedImage, Array<SerializedImage>> Url { get => JSRef!.Get<Union<SerializedImage, Array<SerializedImage>>>("url"); set => JSRef!.Set("url", value); }
        /// <summary>
        /// uuid: string;
        /// </summary>
        public string Uuid { get => JSRef!.Get<string>("uuid"); set => JSRef!.Set("uuid", value); }
        #endregion

        #region Methods

        #endregion
    }
}
