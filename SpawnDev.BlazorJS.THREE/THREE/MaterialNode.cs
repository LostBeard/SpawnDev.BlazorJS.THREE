
using System.Text;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.THREE
{
    public class MaterialNode : Node
    {
        #region Constructors
        /// <inheritdoc/>
        public MaterialNode(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// constructor(scope?: MaterialNodeScope);
        /// </summary>
        public MaterialNode(MaterialNodeScope scope) : base(JS.New("THREE.MaterialNode", scope)) { }
        
        #endregion

        #region Properties
        /// <summary>
        /// static ALPHA_TEST: "alphaTest";
        /// </summary>
        public static string ALPHA_TEST { get => JS.Get<string>("THREE.MaterialNode.ALPHA_TEST"); set => JS.Set("THREE.MaterialNode.ALPHA_TEST", value); }
        /// <summary>
        /// static ANISOTROPY: "anisotropy";
        /// </summary>
        public static string ANISOTROPY { get => JS.Get<string>("THREE.MaterialNode.ANISOTROPY"); set => JS.Set("THREE.MaterialNode.ANISOTROPY", value); }
        /// <summary>
        /// static AO: "ao";
        /// </summary>
        public static string AO { get => JS.Get<string>("THREE.MaterialNode.AO"); set => JS.Set("THREE.MaterialNode.AO", value); }
        /// <summary>
        /// static ATTENUATION_COLOR: "attenuationColor";
        /// </summary>
        public static string ATTENUATION_COLOR { get => JS.Get<string>("THREE.MaterialNode.ATTENUATION_COLOR"); set => JS.Set("THREE.MaterialNode.ATTENUATION_COLOR", value); }
        /// <summary>
        /// static ATTENUATION_DISTANCE: "attenuationDistance";
        /// </summary>
        public static string ATTENUATION_DISTANCE { get => JS.Get<string>("THREE.MaterialNode.ATTENUATION_DISTANCE"); set => JS.Set("THREE.MaterialNode.ATTENUATION_DISTANCE", value); }
        /// <summary>
        /// static CLEARCOAT: "clearcoat";
        /// </summary>
        public static string CLEARCOAT { get => JS.Get<string>("THREE.MaterialNode.CLEARCOAT"); set => JS.Set("THREE.MaterialNode.CLEARCOAT", value); }
        /// <summary>
        /// static CLEARCOAT_NORMAL: "clearcoatNormal";
        /// </summary>
        public static string CLEARCOAT_NORMAL { get => JS.Get<string>("THREE.MaterialNode.CLEARCOAT_NORMAL"); set => JS.Set("THREE.MaterialNode.CLEARCOAT_NORMAL", value); }
        /// <summary>
        /// static CLEARCOAT_ROUGHNESS: "clearcoatRoughness";
        /// </summary>
        public static string CLEARCOAT_ROUGHNESS { get => JS.Get<string>("THREE.MaterialNode.CLEARCOAT_ROUGHNESS"); set => JS.Set("THREE.MaterialNode.CLEARCOAT_ROUGHNESS", value); }
        /// <summary>
        /// static COLOR: "color";
        /// </summary>
        public static string COLOR { get => JS.Get<string>("THREE.MaterialNode.COLOR"); set => JS.Set("THREE.MaterialNode.COLOR", value); }
        /// <summary>
        /// static DISPERSION: "dispersion";
        /// </summary>
        public static string DISPERSION { get => JS.Get<string>("THREE.MaterialNode.DISPERSION"); set => JS.Set("THREE.MaterialNode.DISPERSION", value); }
        /// <summary>
        /// static EMISSIVE: "emissive";
        /// </summary>
        public static string EMISSIVE { get => JS.Get<string>("THREE.MaterialNode.EMISSIVE"); set => JS.Set("THREE.MaterialNode.EMISSIVE", value); }
        /// <summary>
        /// static IOR: "ior";
        /// </summary>
        public static string IOR { get => JS.Get<string>("THREE.MaterialNode.IOR"); set => JS.Set("THREE.MaterialNode.IOR", value); }
        /// <summary>
        /// static IRIDESCENCE: "iridescence";
        /// </summary>
        public static string IRIDESCENCE { get => JS.Get<string>("THREE.MaterialNode.IRIDESCENCE"); set => JS.Set("THREE.MaterialNode.IRIDESCENCE", value); }
        /// <summary>
        /// static IRIDESCENCE_IOR: "iridescenceIOR";
        /// </summary>
        public static string IRIDESCENCE_IOR { get => JS.Get<string>("THREE.MaterialNode.IRIDESCENCE_IOR"); set => JS.Set("THREE.MaterialNode.IRIDESCENCE_IOR", value); }
        /// <summary>
        /// static IRIDESCENCE_THICKNESS: "iridescenceThickness";
        /// </summary>
        public static string IRIDESCENCE_THICKNESS { get => JS.Get<string>("THREE.MaterialNode.IRIDESCENCE_THICKNESS"); set => JS.Set("THREE.MaterialNode.IRIDESCENCE_THICKNESS", value); }
        /// <summary>
        /// static LIGHT_MAP: "light";
        /// </summary>
        public static string LIGHT_MAP { get => JS.Get<string>("THREE.MaterialNode.LIGHT_MAP"); set => JS.Set("THREE.MaterialNode.LIGHT_MAP", value); }
        /// <summary>
        /// static LINE_DASH_OFFSET: "dashOffset";
        /// </summary>
        public static string LINE_DASH_OFFSET { get => JS.Get<string>("THREE.MaterialNode.LINE_DASH_OFFSET"); set => JS.Set("THREE.MaterialNode.LINE_DASH_OFFSET", value); }
        /// <summary>
        /// static LINE_DASH_SIZE: "dashSize";
        /// </summary>
        public static string LINE_DASH_SIZE { get => JS.Get<string>("THREE.MaterialNode.LINE_DASH_SIZE"); set => JS.Set("THREE.MaterialNode.LINE_DASH_SIZE", value); }
        /// <summary>
        /// static LINE_GAP_SIZE: "gapSize";
        /// </summary>
        public static string LINE_GAP_SIZE { get => JS.Get<string>("THREE.MaterialNode.LINE_GAP_SIZE"); set => JS.Set("THREE.MaterialNode.LINE_GAP_SIZE", value); }
        /// <summary>
        /// static LINE_SCALE: "scale";
        /// </summary>
        public static string LINE_SCALE { get => JS.Get<string>("THREE.MaterialNode.LINE_SCALE"); set => JS.Set("THREE.MaterialNode.LINE_SCALE", value); }
        /// <summary>
        /// static LINE_WIDTH: "linewidth";
        /// </summary>
        public static string LINE_WIDTH { get => JS.Get<string>("THREE.MaterialNode.LINE_WIDTH"); set => JS.Set("THREE.MaterialNode.LINE_WIDTH", value); }
        /// <summary>
        /// static METALNESS: "metalness";
        /// </summary>
        public static string METALNESS { get => JS.Get<string>("THREE.MaterialNode.METALNESS"); set => JS.Set("THREE.MaterialNode.METALNESS", value); }
        /// <summary>
        /// static NORMAL: "normal";
        /// </summary>
        public static string NORMAL { get => JS.Get<string>("THREE.MaterialNode.NORMAL"); set => JS.Set("THREE.MaterialNode.NORMAL", value); }
        /// <summary>
        /// static OPACITY: "opacity";
        /// </summary>
        public static string OPACITY { get => JS.Get<string>("THREE.MaterialNode.OPACITY"); set => JS.Set("THREE.MaterialNode.OPACITY", value); }
        /// <summary>
        /// static POINT_SIZE: "size";
        /// </summary>
        public static string POINT_SIZE { get => JS.Get<string>("THREE.MaterialNode.POINT_SIZE"); set => JS.Set("THREE.MaterialNode.POINT_SIZE", value); }
        /// <summary>
        /// static REFLECTIVITY: "reflectivity";
        /// </summary>
        public static string REFLECTIVITY { get => JS.Get<string>("THREE.MaterialNode.REFLECTIVITY"); set => JS.Set("THREE.MaterialNode.REFLECTIVITY", value); }
        /// <summary>
        /// static REFRACTION_RATIO: "refractionRatio";
        /// </summary>
        public static string REFRACTION_RATIO { get => JS.Get<string>("THREE.MaterialNode.REFRACTION_RATIO"); set => JS.Set("THREE.MaterialNode.REFRACTION_RATIO", value); }
        /// <summary>
        /// static ROTATION: "rotation";
        /// </summary>
        public static string ROTATION { get => JS.Get<string>("THREE.MaterialNode.ROTATION"); set => JS.Set("THREE.MaterialNode.ROTATION", value); }
        /// <summary>
        /// static ROUGHNESS: "roughness";
        /// </summary>
        public static string ROUGHNESS { get => JS.Get<string>("THREE.MaterialNode.ROUGHNESS"); set => JS.Set("THREE.MaterialNode.ROUGHNESS", value); }
        /// <summary>
        /// scope: MaterialNodeScope;
        /// </summary>
        public MaterialNodeScope Scope { get => JSRef!.Get<MaterialNodeScope>("scope"); set => JSRef!.Set("scope", value); }
        /// <summary>
        /// static SHEEN: "sheen";
        /// </summary>
        public static string SHEEN { get => JS.Get<string>("THREE.MaterialNode.SHEEN"); set => JS.Set("THREE.MaterialNode.SHEEN", value); }
        /// <summary>
        /// static SHEEN_ROUGHNESS: "sheenRoughness";
        /// </summary>
        public static string SHEEN_ROUGHNESS { get => JS.Get<string>("THREE.MaterialNode.SHEEN_ROUGHNESS"); set => JS.Set("THREE.MaterialNode.SHEEN_ROUGHNESS", value); }
        /// <summary>
        /// static SHININESS: "shininess";
        /// </summary>
        public static string SHININESS { get => JS.Get<string>("THREE.MaterialNode.SHININESS"); set => JS.Set("THREE.MaterialNode.SHININESS", value); }
        /// <summary>
        /// static SPECULAR: "specular";
        /// </summary>
        public static string SPECULAR { get => JS.Get<string>("THREE.MaterialNode.SPECULAR"); set => JS.Set("THREE.MaterialNode.SPECULAR", value); }
        /// <summary>
        /// static SPECULAR_COLOR: "specularColor";
        /// </summary>
        public static string SPECULAR_COLOR { get => JS.Get<string>("THREE.MaterialNode.SPECULAR_COLOR"); set => JS.Set("THREE.MaterialNode.SPECULAR_COLOR", value); }
        /// <summary>
        /// static SPECULAR_INTENSITY: "specularIntensity";
        /// </summary>
        public static string SPECULAR_INTENSITY { get => JS.Get<string>("THREE.MaterialNode.SPECULAR_INTENSITY"); set => JS.Set("THREE.MaterialNode.SPECULAR_INTENSITY", value); }
        /// <summary>
        /// static SPECULAR_STRENGTH: "specularStrength";
        /// </summary>
        public static string SPECULAR_STRENGTH { get => JS.Get<string>("THREE.MaterialNode.SPECULAR_STRENGTH"); set => JS.Set("THREE.MaterialNode.SPECULAR_STRENGTH", value); }
        /// <summary>
        /// static THICKNESS: "thickness";
        /// </summary>
        public static string THICKNESS { get => JS.Get<string>("THREE.MaterialNode.THICKNESS"); set => JS.Set("THREE.MaterialNode.THICKNESS", value); }
        /// <summary>
        /// static TRANSMISSION: "transmission";
        /// </summary>
        public static string TRANSMISSION { get => JS.Get<string>("THREE.MaterialNode.TRANSMISSION"); set => JS.Set("THREE.MaterialNode.TRANSMISSION", value); }
        #endregion

        #region Methods

        #endregion
    }
}
