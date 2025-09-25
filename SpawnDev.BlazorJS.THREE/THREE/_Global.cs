// https://webidl.spec.whatwg.org/#BufferSource
// typedef (ArrayBufferView or ArrayBuffer) BufferSource;
global using BufferSource = SpawnDev.BlazorJS.Union
    <
    SpawnDev.BlazorJS.JSObjects.ArrayBuffer,
    SpawnDev.BlazorJS.JSObjects.TypedArray,
    SpawnDev.BlazorJS.JSObjects.DataView,
    byte[]
    >;

global using CanvasImageSource = SpawnDev.BlazorJS.Union<
    SpawnDev.BlazorJS.JSObjects.HTMLImageElement,
    SpawnDev.BlazorJS.JSObjects.SVGImageElement,
    SpawnDev.BlazorJS.JSObjects.HTMLVideoElement,
    SpawnDev.BlazorJS.JSObjects.HTMLCanvasElement,
    SpawnDev.BlazorJS.JSObjects.ImageBitmap,
    SpawnDev.BlazorJS.JSObjects.OffscreenCanvas,
    SpawnDev.BlazorJS.JSObjects.VideoFrame
>;
global using TexImageSource = SpawnDev.BlazorJS.Union<SpawnDev.BlazorJS.JSObjects.OffscreenCanvas, object>;
global using ArrayBufferView = SpawnDev.BlazorJS.Union<byte[], SpawnDev.BlazorJS.JSObjects.TypedArray, SpawnDev.BlazorJS.JSObjects.DataView>;
global using ArrayLikeFloat = SpawnDev.BlazorJS.Union<SpawnDev.BlazorJS.JSObjects.Float32Array, float[]>;

global using BuildStageOption = string;
global using BuiltinStage = string;
global using ClippingNodeScope = string;
global using ColorSpace = string;
global using ColorSpaceTransfer = string;
global using Combine = string;
global using CompressedPixelFormat = string;
global using CoordinateSystem = string;
global using CubeTextureMapping = string;
global using CullFace = string;
global using CurveType = string;
global using DepthModes = string;
global using DepthPackingStrategies = string;
global using DepthTexturePixelFormat = string;
global using EulerOrder = string;
global using EventNodeType = string;
global using GLenum = string;
global using GLSLVersion = string;
global using GPUPowerPreference = string;
global using GPUSize64 = string;
global using HalfFloatType = string;
global using InterpolationModes = string;
global using InterpolationSamplingMode = string;
global using InterpolationSamplingType = string;
global using MagnificationTextureFilter = string;
global using Mapping = string;
global using MathNodeMethod = string;
global using MathNodeMethod1 = string;
global using MathNodeMethod2 = string;
global using MathNodeMethod3 = string;
global using MinificationTextureFilter = string;
global using NodeAccess = string;
global using NodeShaderStage = string;
global using NodeType = string;
global using NodeUniformGPU = string;
global using NodeUpdateType = string;
global using NormalMapTypes = string;
global using OperatorNodeOp = string;
global using PannerNode = string;
global using PassNodeScope = string;
global using PixelFormat = string;
global using PixelFormatGPU = string;
global using Precision = string;
global using SceneNodeScope = string;
global using ScreenNodeScope = string;
global using SerializedImage = string;
global using ShadowMapType = string;
global using Side = string;
global using StencilFunc = string;
global using StencilOp = string;
global using SubgroupFunctionNodeMethod0 = string;
global using SubgroupFunctionNodeMethod1 = string;
global using SubgroupFunctionNodeMethod2 = string;
global using SwizzleOption = string;
global using TextureComparisonFunction = string;
global using TextureDataType = string;
global using TimestampQuery = string;
global using ToneMapping = string;
global using TShadowSupport = string;
global using UnsignedByteType = string;
global using Usage = string;
global using ViewportDepthNodeScope = string;
global using WebGLCoordinateSystem = string;
global using Wrapping = string;
global using XREnvironmentBlendMode = string;
global using XRRenderState = string;
global using XRWebGLDepthInformation = string;
global using MaterialNodeScope = string;
global using WorkingOrOutputColorSpace = string;
global using AnimationActionLoopStyles = string;
global using AnimationBlendMode = string;
global using AnyMapping = string;
global using AnyPixelFormat = string;
global using AtomicMethod = string;
global using AttributeGPUType = string;
global using AttributeType = string;
global using BindMode = string;
global using Blending = string;
global using BlendingDstFactor = string;
global using BlendingEquation = string;
global using BlendingSrcFactor = string;
global using IndexNodeScope = string;
global using MaterialData = object;
global using TIntersected = object;
global using NodeBuilderContext = object;
global using XRFrameRequestCallback = SpawnDev.BlazorJS.Callback;
global using ColorRepresentation = int;
global using EulerTuple = (float x, float y, float z);
global using Vector2Tuple = (float x, float y);
global using Vector3Tuple = (float x, float y, float z);
global using Vector4Tuple = (float x, float y, float z, float w);
global using QuaternionTuple = (float x, float y, float z, float w);
global using Matrix4Tuple = (float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, float);
global using Matrix3Tuple = (float, float, float, float, float, float, float, float, float);
global using Matrix2Tuple = (float, float, float, float, float, float);
global using DOMHighResTimeStamp = double;
