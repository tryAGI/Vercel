
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2Header
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
        public required global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHeader> Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHaVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Header" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="headers"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2Header(
            string source,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHeader> headers,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHaVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2HeaderHaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2HeaderMissingItemVariant2>>? missing)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Has = has;
            this.Missing = missing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Header" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2Header()
        {
        }

    }
}