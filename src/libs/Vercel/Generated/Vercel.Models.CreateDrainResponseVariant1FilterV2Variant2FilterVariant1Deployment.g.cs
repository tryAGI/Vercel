
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant1FilterV2Variant2FilterVariant1Deployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1FilterV2Variant2FilterVariant1Deployment" /> class.
        /// </summary>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant1FilterV2Variant2FilterVariant1Deployment(
            global::System.Collections.Generic.IList<global::Vercel.CreateDrainResponseVariant1FilterV2Variant2FilterVariant1DeploymentEnvironment>? environments)
        {
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1FilterV2Variant2FilterVariant1Deployment" /> class.
        /// </summary>
        public CreateDrainResponseVariant1FilterV2Variant2FilterVariant1Deployment()
        {
        }
    }
}