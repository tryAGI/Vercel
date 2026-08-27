
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectCreatorVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectCreatorVariant3TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant3Integration Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant3" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectCreatorVariant3(
            global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant3Integration integration,
            global::Vercel.GetProjectsResponseVariant2ProjectCreatorVariant3Type type)
        {
            this.Type = type;
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant3" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectCreatorVariant3()
        {
        }

    }
}