
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MathNode : TempNode
    {
        #region Constructors
        /// <inheritdoc/>
        public MathNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(method: MathNodeMethod1, aNode: Node);
        /// </summary>
        public MathNode(MathNodeMethod1 method, Node aNode) : base(JS.New("THREE.MathNode", method, aNode)) { }
        
        
        /// <summary>
        /// constructor(method: MathNodeMethod2, aNode: Node, bNode: Node);
        /// </summary>
        public MathNode(MathNodeMethod2 method, Node aNode, Node bNode) : base(JS.New("THREE.MathNode", method, aNode, bNode)) { }
        
        
        /// <summary>
        /// constructor(method: MathNodeMethod3, aNode: Node, bNode: Node, cNode: Node);
        /// </summary>
        public MathNode(MathNodeMethod3 method, Node aNode, Node bNode, Node cNode) : base(JS.New("THREE.MathNode", method, aNode, bNode, cNode)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static ABS: "abs";
        /// </summary>
        public static string ABS { get => JS.Get<string>("THREE.MathNode.ABS"); set => JS.Set("THREE.MathNode.ABS", value); }
        /// <summary>
        /// static ACOS: "acos";
        /// </summary>
        public static string ACOS { get => JS.Get<string>("THREE.MathNode.ACOS"); set => JS.Set("THREE.MathNode.ACOS", value); }
        /// <summary>
        /// static ALL: "all";
        /// </summary>
        public static string ALL { get => JS.Get<string>("THREE.MathNode.ALL"); set => JS.Set("THREE.MathNode.ALL", value); }
        /// <summary>
        /// aNode: Node;
        /// </summary>
        public Node ANode { get => JSRef!.Get<Node>("aNode"); set => JSRef!.Set("aNode", value); }
        /// <summary>
        /// static ANY: "any";
        /// </summary>
        public static string ANY { get => JS.Get<string>("THREE.MathNode.ANY"); set => JS.Set("THREE.MathNode.ANY", value); }
        /// <summary>
        /// static ASIN: "asin";
        /// </summary>
        public static string ASIN { get => JS.Get<string>("THREE.MathNode.ASIN"); set => JS.Set("THREE.MathNode.ASIN", value); }
        /// <summary>
        /// static ATAN: "atan";
        /// </summary>
        public static string ATAN { get => JS.Get<string>("THREE.MathNode.ATAN"); set => JS.Set("THREE.MathNode.ATAN", value); }
        /// <summary>
        /// bNode: Node | null;
        /// </summary>
        public Node BNode { get => JSRef!.Get<Node>("bNode"); set => JSRef!.Set("bNode", value); }
        /// <summary>
        /// static CEIL: "ceil";
        /// </summary>
        public static string CEIL { get => JS.Get<string>("THREE.MathNode.CEIL"); set => JS.Set("THREE.MathNode.CEIL", value); }
        /// <summary>
        /// static CLAMP: "clamp";
        /// </summary>
        public static string CLAMP { get => JS.Get<string>("THREE.MathNode.CLAMP"); set => JS.Set("THREE.MathNode.CLAMP", value); }
        /// <summary>
        /// cNode: Node | null;
        /// </summary>
        public Node CNode { get => JSRef!.Get<Node>("cNode"); set => JSRef!.Set("cNode", value); }
        /// <summary>
        /// static COS: "cos";
        /// </summary>
        public static string COS { get => JS.Get<string>("THREE.MathNode.COS"); set => JS.Set("THREE.MathNode.COS", value); }
        /// <summary>
        /// static CROSS: "cross";
        /// </summary>
        public static string CROSS { get => JS.Get<string>("THREE.MathNode.CROSS"); set => JS.Set("THREE.MathNode.CROSS", value); }
        /// <summary>
        /// static DEGREES: "degrees";
        /// </summary>
        public static string DEGREES { get => JS.Get<string>("THREE.MathNode.DEGREES"); set => JS.Set("THREE.MathNode.DEGREES", value); }
        /// <summary>
        /// static DETERMINANT: "determinant";
        /// </summary>
        public static string DETERMINANT { get => JS.Get<string>("THREE.MathNode.DETERMINANT"); set => JS.Set("THREE.MathNode.DETERMINANT", value); }
        /// <summary>
        /// static DFDX: "dFdx";
        /// </summary>
        public static string DFDX { get => JS.Get<string>("THREE.MathNode.DFDX"); set => JS.Set("THREE.MathNode.DFDX", value); }
        /// <summary>
        /// static DFDY: "dFdy";
        /// </summary>
        public static string DFDY { get => JS.Get<string>("THREE.MathNode.DFDY"); set => JS.Set("THREE.MathNode.DFDY", value); }
        /// <summary>
        /// static DISTANCE: "distance";
        /// </summary>
        public static string DISTANCE { get => JS.Get<string>("THREE.MathNode.DISTANCE"); set => JS.Set("THREE.MathNode.DISTANCE", value); }
        /// <summary>
        /// static DOT: "dot";
        /// </summary>
        public static string DOT { get => JS.Get<string>("THREE.MathNode.DOT"); set => JS.Set("THREE.MathNode.DOT", value); }
        /// <summary>
        /// static EQUALS: "equals";
        /// </summary>
        public static string EQUALS { get => JS.Get<string>("THREE.MathNode.EQUALS"); set => JS.Set("THREE.MathNode.EQUALS", value); }
        /// <summary>
        /// static EXP: "exp";
        /// </summary>
        public static string EXP { get => JS.Get<string>("THREE.MathNode.EXP"); set => JS.Set("THREE.MathNode.EXP", value); }
        /// <summary>
        /// static EXP2: "exp2";
        /// </summary>
        public static string EXP2 { get => JS.Get<string>("THREE.MathNode.EXP2"); set => JS.Set("THREE.MathNode.EXP2", value); }
        /// <summary>
        /// static FACEFORWARD: "faceforward";
        /// </summary>
        public static string FACEFORWARD { get => JS.Get<string>("THREE.MathNode.FACEFORWARD"); set => JS.Set("THREE.MathNode.FACEFORWARD", value); }
        /// <summary>
        /// static FLOOR: "floor";
        /// </summary>
        public static string FLOOR { get => JS.Get<string>("THREE.MathNode.FLOOR"); set => JS.Set("THREE.MathNode.FLOOR", value); }
        /// <summary>
        /// static FRACT: "fract";
        /// </summary>
        public static string FRACT { get => JS.Get<string>("THREE.MathNode.FRACT"); set => JS.Set("THREE.MathNode.FRACT", value); }
        /// <summary>
        /// static FWIDTH: "fwidth";
        /// </summary>
        public static string FWIDTH { get => JS.Get<string>("THREE.MathNode.FWIDTH"); set => JS.Set("THREE.MathNode.FWIDTH", value); }
        /// <summary>
        /// static INVERSE: "inverse";
        /// </summary>
        public static string INVERSE { get => JS.Get<string>("THREE.MathNode.INVERSE"); set => JS.Set("THREE.MathNode.INVERSE", value); }
        /// <summary>
        /// static INVERSE_SQRT: "inversesqrt";
        /// </summary>
        public static string INVERSE_SQRT { get => JS.Get<string>("THREE.MathNode.INVERSE_SQRT"); set => JS.Set("THREE.MathNode.INVERSE_SQRT", value); }
        /// <summary>
        /// readonly isMathNode: true;
        /// </summary>
        public bool IsMathNode { get => JSRef!.Get<bool>("isMathNode"); }
        /// <summary>
        /// static LENGTH: "length";
        /// </summary>
        public static string LENGTH { get => JS.Get<string>("THREE.MathNode.LENGTH"); set => JS.Set("THREE.MathNode.LENGTH", value); }
        /// <summary>
        /// static LOG: "log";
        /// </summary>
        public static string LOG { get => JS.Get<string>("THREE.MathNode.LOG"); set => JS.Set("THREE.MathNode.LOG", value); }
        /// <summary>
        /// static LOG2: "log2";
        /// </summary>
        public static string LOG2 { get => JS.Get<string>("THREE.MathNode.LOG2"); set => JS.Set("THREE.MathNode.LOG2", value); }
        /// <summary>
        /// static MAX: "max";
        /// </summary>
        public static string MAX { get => JS.Get<string>("THREE.MathNode.MAX"); set => JS.Set("THREE.MathNode.MAX", value); }
        /// <summary>
        /// method: MathNodeMethod;
        /// </summary>
        public MathNodeMethod Method { get => JSRef!.Get<MathNodeMethod>("method"); set => JSRef!.Set("method", value); }
        /// <summary>
        /// static MIN: "min";
        /// </summary>
        public static string MIN { get => JS.Get<string>("THREE.MathNode.MIN"); set => JS.Set("THREE.MathNode.MIN", value); }
        /// <summary>
        /// static MIX: "mix";
        /// </summary>
        public static string MIX { get => JS.Get<string>("THREE.MathNode.MIX"); set => JS.Set("THREE.MathNode.MIX", value); }
        /// <summary>
        /// static NEGATE: "negate";
        /// </summary>
        public static string NEGATE { get => JS.Get<string>("THREE.MathNode.NEGATE"); set => JS.Set("THREE.MathNode.NEGATE", value); }
        /// <summary>
        /// static NORMALIZE: "normalize";
        /// </summary>
        public static string NORMALIZE { get => JS.Get<string>("THREE.MathNode.NORMALIZE"); set => JS.Set("THREE.MathNode.NORMALIZE", value); }
        /// <summary>
        /// static ONE_MINUS: "oneMinus";
        /// </summary>
        public static string ONE_MINUS { get => JS.Get<string>("THREE.MathNode.ONE_MINUS"); set => JS.Set("THREE.MathNode.ONE_MINUS", value); }
        /// <summary>
        /// static POW: "pow";
        /// </summary>
        public static string POW { get => JS.Get<string>("THREE.MathNode.POW"); set => JS.Set("THREE.MathNode.POW", value); }
        /// <summary>
        /// static RADIANS: "radians";
        /// </summary>
        public static string RADIANS { get => JS.Get<string>("THREE.MathNode.RADIANS"); set => JS.Set("THREE.MathNode.RADIANS", value); }
        /// <summary>
        /// static RECIPROCAL: "reciprocal";
        /// </summary>
        public static string RECIPROCAL { get => JS.Get<string>("THREE.MathNode.RECIPROCAL"); set => JS.Set("THREE.MathNode.RECIPROCAL", value); }
        /// <summary>
        /// static REFLECT: "reflect";
        /// </summary>
        public static string REFLECT { get => JS.Get<string>("THREE.MathNode.REFLECT"); set => JS.Set("THREE.MathNode.REFLECT", value); }
        /// <summary>
        /// static REFRACT: "refract";
        /// </summary>
        public static string REFRACT { get => JS.Get<string>("THREE.MathNode.REFRACT"); set => JS.Set("THREE.MathNode.REFRACT", value); }
        /// <summary>
        /// static ROUND: "round";
        /// </summary>
        public static string ROUND { get => JS.Get<string>("THREE.MathNode.ROUND"); set => JS.Set("THREE.MathNode.ROUND", value); }
        /// <summary>
        /// static SIGN: "sign";
        /// </summary>
        public static string SIGN { get => JS.Get<string>("THREE.MathNode.SIGN"); set => JS.Set("THREE.MathNode.SIGN", value); }
        /// <summary>
        /// static SIN: "sin";
        /// </summary>
        public static string SIN { get => JS.Get<string>("THREE.MathNode.SIN"); set => JS.Set("THREE.MathNode.SIN", value); }
        /// <summary>
        /// static SMOOTHSTEP: "smoothstep";
        /// </summary>
        public static string SMOOTHSTEP { get => JS.Get<string>("THREE.MathNode.SMOOTHSTEP"); set => JS.Set("THREE.MathNode.SMOOTHSTEP", value); }
        /// <summary>
        /// static SQRT: "sqrt";
        /// </summary>
        public static string SQRT { get => JS.Get<string>("THREE.MathNode.SQRT"); set => JS.Set("THREE.MathNode.SQRT", value); }
        /// <summary>
        /// static STEP: "step";
        /// </summary>
        public static string STEP { get => JS.Get<string>("THREE.MathNode.STEP"); set => JS.Set("THREE.MathNode.STEP", value); }
        /// <summary>
        /// static TAN: "tan";
        /// </summary>
        public static string TAN { get => JS.Get<string>("THREE.MathNode.TAN"); set => JS.Set("THREE.MathNode.TAN", value); }
        /// <summary>
        /// static TRANSFORM_DIRECTION: "transformDirection";
        /// </summary>
        public static string TRANSFORM_DIRECTION { get => JS.Get<string>("THREE.MathNode.TRANSFORM_DIRECTION"); set => JS.Set("THREE.MathNode.TRANSFORM_DIRECTION", value); }
        /// <summary>
        /// static TRANSPOSE: "transpose";
        /// </summary>
        public static string TRANSPOSE { get => JS.Get<string>("THREE.MathNode.TRANSPOSE"); set => JS.Set("THREE.MathNode.TRANSPOSE", value); }
        /// <summary>
        /// static TRUNC: "trunc";
        /// </summary>
        public static string TRUNC { get => JS.Get<string>("THREE.MathNode.TRUNC"); set => JS.Set("THREE.MathNode.TRUNC", value); }
        #endregion

        #region Methods

        #endregion
    }
}
