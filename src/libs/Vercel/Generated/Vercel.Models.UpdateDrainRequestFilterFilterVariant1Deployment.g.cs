
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainRequestFilterFilterVariant1Deployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilterFilterVariant1Deployment" /> class.
        /// </summary>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainRequestFilterFilterVariant1Deployment(
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment>? environments)
        {
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilterFilterVariant1Deployment" /> class.
        /// </summary>
        public UpdateDrainRequestFilterFilterVariant1Deployment()
        {
        }
    }
}