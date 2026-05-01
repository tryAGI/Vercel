
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant245GeolocationMostSpecificSubdivisionNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("en")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string En { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant245GeolocationMostSpecificSubdivisionNames" /> class.
        /// </summary>
        /// <param name="en"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant245GeolocationMostSpecificSubdivisionNames(
            string en)
        {
            this.En = en ?? throw new global::System.ArgumentNullException(nameof(en));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant245GeolocationMostSpecificSubdivisionNames" /> class.
        /// </summary>
        public UserEventPayloadVariant245GeolocationMostSpecificSubdivisionNames()
        {
        }
    }
}