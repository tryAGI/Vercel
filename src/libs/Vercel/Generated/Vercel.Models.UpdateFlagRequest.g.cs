
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequest
    {
        /// <summary>
        /// The user who created this patch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional message for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The variants of the flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestVariant>? Variants { get; set; }

        /// <summary>
        /// The configuration for the flag in different environments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateFlagRequestEnvironments2>? Environments { get; set; }

        /// <summary>
        /// A random seed to prevent split points in different flags from having the same targets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// A description of the flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagRequestStateJsonConverter))]
        public global::Vercel.UpdateFlagRequestState? State { get; set; }

        /// <summary>
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequest" /> class.
        /// </summary>
        /// <param name="createdBy">
        /// The user who created this patch
        /// </param>
        /// <param name="message">
        /// Additional message for this version
        /// </param>
        /// <param name="variants">
        /// The variants of the flag
        /// </param>
        /// <param name="environments">
        /// The configuration for the flag in different environments
        /// </param>
        /// <param name="seed">
        /// A random seed to prevent split points in different flags from having the same targets
        /// </param>
        /// <param name="description">
        /// A description of the flag
        /// </param>
        /// <param name="state"></param>
        /// <param name="permanent">
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequest(
            string? createdBy,
            string? message,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestVariant>? variants,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateFlagRequestEnvironments2>? environments,
            double? seed,
            string? description,
            global::Vercel.UpdateFlagRequestState? state,
            bool? permanent)
        {
            this.CreatedBy = createdBy;
            this.Message = message;
            this.Variants = variants;
            this.Environments = environments;
            this.Seed = seed;
            this.Description = description;
            this.State = state;
            this.Permanent = permanent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequest" /> class.
        /// </summary>
        public UpdateFlagRequest()
        {
        }
    }
}