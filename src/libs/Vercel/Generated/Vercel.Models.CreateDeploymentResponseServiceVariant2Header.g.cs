
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseServiceVariant2Header
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHeader> Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHaVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHaVariant2>>? Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseServiceVariant2Header" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="headers"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseServiceVariant2Header(
            string source,
            global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHeader> headers,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHaVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2HeaderHaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2HeaderMissingItemVariant2>>? missing)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Has = has;
            this.Missing = missing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseServiceVariant2Header" /> class.
        /// </summary>
        public CreateDeploymentResponseServiceVariant2Header()
        {
        }

    }
}