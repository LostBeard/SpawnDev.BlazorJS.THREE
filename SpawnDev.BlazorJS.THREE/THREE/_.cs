using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
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
public class PointsMaterialParameters : MaterialParameters
{

}
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

}
public class MeshPhysicalMaterialParameters : MaterialParameters
{

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
    public int? Color { get; set; }
}
public class MeshLambertNodeMaterialParameters : MaterialParameters
{

}
public class MaterialParameters
{

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



