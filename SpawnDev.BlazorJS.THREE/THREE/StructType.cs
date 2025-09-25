
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class StructType : JSObject
    {
        #region Constructors
        /// <inheritdoc/>
        public StructType(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(name: string, members: MemberLayout[]);
        /// </summary>
        public StructType(string name, Array<MemberLayout> members) : base(JS.New("THREE.StructType", name, members)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// members: MemberLayout[];
        /// </summary>
        public Array<MemberLayout> Members { get => JSRef!.Get<Array<MemberLayout>>("members"); set => JSRef!.Set("members", value); }
        /// <summary>
        /// name: string;
        /// </summary>
        public string Name { get => JSRef!.Get<string>("name"); set => JSRef!.Set("name", value); }
        /// <summary>
        /// output: boolean;
        /// </summary>
        public bool Output { get => JSRef!.Get<bool>("output"); set => JSRef!.Set("output", value); }
        #endregion

        #region Methods

        #endregion
    }
}
