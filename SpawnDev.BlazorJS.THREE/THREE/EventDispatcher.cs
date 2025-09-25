
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class EventDispatcher : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public EventDispatcher(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public EventDispatcher() : base(JS.New("THREE.EventDispatcher")) { }
        
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// removeEventListener<T extends Extract<keyof TEventMap, string>>(
        ///         type: T,
        ///         listener: EventListener<TEventMap[T], T, this>,
        ///     ): void;
        /// </summary>
        public void RemoveEventListener<T>(T type, Callback listener)
        {
            JSRef!.CallVoid("removeEventListener", type, listener);
        }
        /// <summary>
        /// hasEventListener<T extends Extract<keyof TEventMap, string>>(
        ///         type: T,
        ///         listener: EventListener<TEventMap[T], T, this>,
        ///     ): boolean;
        /// </summary>
        public bool HasEventListener<T>(T type, Callback listener)
        {
            return JSRef!.Call<bool>("hasEventListener", type, listener);
        }
        /// <summary>
        /// dispatchEvent<T extends Extract<keyof TEventMap, string>>(event: BaseEvent<T> & TEventMap[T]): void;
        /// </summary>
        public void DispatchEvent<T>(object ev)
        {
            JSRef!.CallVoid("dispatchEvent", ev);
        }
        /// <summary>
        /// addEventListener<T extends Extract<keyof TEventMap, string>>(
        ///         type: T,
        ///         listener: EventListener<TEventMap[T], T, this>,
        ///     ): void;
        /// </summary>
        public void AddEventListener<T>(T type, Callback listener)
        {
            JSRef!.CallVoid("addEventListener", type, listener);
        }
        #endregion
    }
}
