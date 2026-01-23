namespace SpawnDev.BlazorJS.THREE
{
    public interface NodeJSONInputData
    {
        #region Properties
        /// <summary>
        /// inputNodes?: NodeJSONInputNodes | undefined;
        /// </summary>
        NodeJSONInputNodes? InputNodes { get; set; }
        /// <summary>
        /// meta: {
        ///         textures: {
        ///             [key: string]: object;
        ///         };
        ///         nodes: {
        ///             [key: string]: Node;
        ///         };
        ///     };
        /// </summary>
        object? Meta { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
