namespace SpawnDev.BlazorJS.THREE
{
    public interface CubeCameraRenderer
    {
        #region Properties
        /// <summary>
        /// coordinateSystem: CoordinateSystem;
        /// </summary>
        CoordinateSystem? CoordinateSystem { get; set; }
        /// <summary>
        /// xr: {
        ///         enabled: boolean;
        ///     };
        /// </summary>
        object? Xr { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
