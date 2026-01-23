namespace SpawnDev.BlazorJS.THREE
{
    public interface MeshPhongNodeMaterialNodeProperties : NodeMaterialNodeProperties
    {
        #region Properties
        /// <summary>
        /// shininessNode: Node | null;
        /// </summary>
        Node? ShininessNode { get; set; }
        /// <summary>
        /// specularNode: Node | null;
        /// </summary>
        Node? SpecularNode { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
