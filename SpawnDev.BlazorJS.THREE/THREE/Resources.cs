
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Resources : Map<string, object>
    {
        #region Constructors
        /// <inheritdoc/>
        public Resources(IJSInProcessObjectReference _ref) : base(_ref) { }

        #endregion

        #region Properties

        #endregion

        #region Methods
        ///// <summary>
        ///// get<TArgs extends object[]>(key: string, callback?: ((...args: TArgs) => void) | null, ...params: TArgs): object;
        ///// </summary>
        //public object Get<TArgs>(string key, Callback callback, params TArgs args, params TArgs parameters)
        //{
        //    return JSRef!.Call<object>("get", key, callback, args, parameters);
        //}
        #endregion
    }
}
