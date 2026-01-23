namespace SpawnDev.BlazorJS.THREE
{
    public interface AnimationMixerEventMap
    {
        #region Properties
        /// <summary>
        /// finished: { action: AnimationAction; direction: number };
        /// </summary>
        object? Finished { get; set; }
        /// <summary>
        /// loop: { action: AnimationAction; loopDelta: number };
        /// </summary>
        object? Loop { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
