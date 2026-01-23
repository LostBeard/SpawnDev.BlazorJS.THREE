namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Parameters for PointsMaterial
    /// </summary>
    public class PointsMaterialParameters
    {
        /// <summary>
        /// Color of the points
        /// </summary>
        public ColorRepresentation? Color { get; set; }
        /// <summary>
        /// Size of the points in pixels
        /// </summary>
        public float? Size { get; set; }
        /// <summary>
        /// Size attenuation based on camera depth
        /// </summary>
        public bool? SizeAttenuation { get; set; }
        /// <summary>
        /// Whether to use vertex colors
        /// </summary>
        public bool? VertexColors { get; set; }
        /// <summary>
        /// Transparency of the material
        /// </summary>
        public bool? Transparent { get; set; }
        /// <summary>
        /// Opacity value (0-1)
        /// </summary>
        public float? Opacity { get; set; }
        /// <summary>
        /// The alpha map
        /// </summary>
        public Texture? AlphaMap { get; set; }
        /// <summary>
        /// The texture map
        /// </summary>
        public Texture? Map { get; set; }
    }
}
