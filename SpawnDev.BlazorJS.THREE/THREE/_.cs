using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.THREE;

public class Record<TKey, TData> : JSObject
{
    public Record(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class ShaderNodeObject<T> : JSObject
{
    /// <inheritdoc/>
    public ShaderNodeObject(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class XRHandJoints : JSObject
{
    /// <inheritdoc/>
    public XRHandJoints(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class ShaderNode : Node
{
    /// <inheritdoc/>
    public ShaderNode(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class Geometry : JSObject
{
    /// <inheritdoc/>
    public Geometry(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class WebXRArrayCamera : JSObject
{
    /// <inheritdoc/>
    public WebXRArrayCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class VolumeNodeMaterialParameters : MaterialParameters
{

}
public class ShadowMaterialParameters : MaterialParameters
{

}
public class ShadowNodeMaterialParameters : MaterialParameters
{

}
public class SpriteNodeMaterialParameters : MaterialParameters
{

}
public class SpriteMaterialParameters : MaterialParameters
{

}
public class ShaderMaterialUniformJSON
{

}
public class ShaderMaterialParameters : MaterialParameters
{

}
// PointsMaterialParameters moved to separate file with proper properties
public class PointsNodeMaterialParameters : MaterialParameters
{

}
public class LineBasicMaterialParameters : MaterialParameters
{

}
public class Line2NodeMaterialParameters : MaterialParameters
{

}
public class LineDashedMaterialParameters : MaterialParameters
{

}
public class LineBasicNodeMaterialParameters : MaterialParameters
{

}
public class MeshPhongMaterialParameters : MaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Color { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Specular { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Shininess { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? Map { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? LightMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? LightMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AoMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? AoMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Emissive { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? EmissiveIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EmissiveMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? BumpMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? BumpScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? NormalMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? NormalMapType { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Vector2? NormalScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? DisplacementMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? DisplacementScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? DisplacementBias { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SpecularMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AlphaMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EnvMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Combine { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Reflectivity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? RefractionRatio { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Wireframe { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? WireframeLinewidth { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? FlatShading { get; set; }
}
public class MeshNormalNodeMaterialParameters : MaterialParameters
{

}
public class MeshPhysicalNodeMaterialParameters : MaterialParameters
{

}
public class MeshSSSNodeMaterialParameters : MaterialParameters
{

}
public class MeshStandardMaterialParameters : MaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Color { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Roughness { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Metalness { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? Map { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? LightMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? LightMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AoMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? AoMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Emissive { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? EmissiveIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EmissiveMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? BumpMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? BumpScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? NormalMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? NormalMapType { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Vector2? NormalScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? DisplacementMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? DisplacementScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? DisplacementBias { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? RoughnessMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? MetalnessMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AlphaMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EnvMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? EnvMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Wireframe { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? WireframeLinewidth { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? FlatShading { get; set; }
}
public class MeshPhysicalMaterialParameters : MeshStandardMaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Clearcoat { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? ClearcoatRoughness { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? ClearcoatMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? ClearcoatRoughnessMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? ClearcoatNormalMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Vector2? ClearcoatNormalScale { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? IOR { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Reflectivity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Sheen { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? SheenRoughness { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Color? SheenColor { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SheenColorMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SheenRoughnessMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Transmission { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? TransmissionMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Thickness { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? ThicknessMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? AttenuationDistance { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Color? AttenuationColor { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? SpecularIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Color? SpecularColor { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SpecularIntensityMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SpecularColorMap { get; set; }
}
public class MeshToonMaterialParameters : MaterialParameters
{

}
public class MeshStandardNodeMaterialParameters : MaterialParameters
{

}
public class MeshToonNodeMaterialParameters : MaterialParameters
{

}
public class MeshPhongNodeMaterialParameters : MaterialParameters
{

}
public class MeshNormalMaterialParameters : MaterialParameters
{

}
public class MeshMatcapNodeMaterialParameters : MaterialParameters
{

}
public class MeshMatcapMaterialParameters : MaterialParameters
{

}
public class NodeMaterialParameters : MaterialParameters
{

}
public class MeshLambertMaterialParameters : MaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Color { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? Map { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? LightMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? LightMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AoMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? AoMapIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Emissive { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? EmissiveIntensity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EmissiveMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? SpecularMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? AlphaMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? EnvMap { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Combine { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Reflectivity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? RefractionRatio { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Wireframe { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? WireframeLinewidth { get; set; }
}
public class MeshDistanceMaterialParameters : MaterialParameters
{

}
public class MeshBasicNodeMaterialParameters : MaterialParameters
{

}
public class MeshDepthMaterialParameters : MaterialParameters
{

}
public class LineDashedNodeMaterialParameters : MaterialParameters
{

}
public class MeshBasicMaterialParameters : MaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Union<int, string>? Color { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Texture? Map { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Reflectivity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? RefractionRatio { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Combine { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Wireframe { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? WireframeLinewidth { get; set; }
}
public class MeshLambertNodeMaterialParameters : MaterialParameters
{

}
public class MaterialParameters
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Name { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Transparent { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public float? Opacity { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Visible { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Side { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? DepthTest { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? DepthWrite { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Blending { get; set; }
}
public interface MaterialJSON
{

}
public class ArrayLike<TData>
{

}
public class TypedArrayConstructor
{

}
public class WeakMap<K, V> : JSObject
{
    public WeakMap(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class RefreshUniform<TData> : Uniform<TData>
{
    public RefreshUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class RefreshUniform : Uniform
{
    public RefreshUniform(IJSInProcessObjectReference _ref) : base(_ref) { }
}
public class Generator<K, V> : JSObject
{
    public Generator(IJSInProcessObjectReference _ref) : base(_ref) { }
}



