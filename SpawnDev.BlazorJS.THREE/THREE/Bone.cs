
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class Bone : Object3D
    {
        #region Constructors
        /// <inheritdoc/>
        public Bone(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor();
        /// </summary>
        public Bone() : base(JS.New("THREE.Bone")) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// readonly isBone: true;
        /// </summary>
        public bool IsBone { get => JSRef!.Get<bool>("isBone"); }
        /// <summary>
        /// override readonly type: string | "Bone";
        /// </summary>
        public string Type { get => JSRef!.Get<string>("type"); }
        #endregion

        #region Methods

        #endregion
    }
}
