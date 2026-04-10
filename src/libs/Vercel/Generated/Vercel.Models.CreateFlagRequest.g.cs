
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequest
    {
        /// <summary>
        /// A unique (per project) key for the flag, composed of letters, numbers, dashes, and underscores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The kind of flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagRequestKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagRequestKind Kind { get; set; }

        /// <summary>
        /// The variants of the flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestVariant>? Variants { get; set; }

        /// <summary>
        /// The configuration for the flag in different environments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateFlagRequestEnvironments2> Environments { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagRequestStateJsonConverter))]
        public global::Vercel.CreateFlagRequestState? State { get; set; }

        /// <summary>
        /// The user ids of the maintainers of the flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainerIds")]
        public global::System.Collections.Generic.IList<string>? MaintainerIds { get; set; }

        /// <summary>
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        /// Tags for categorizing the flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// A unique (per project) key for the flag, composed of letters, numbers, dashes, and underscores
        /// </param>
        /// <param name="kind">
        /// The kind of flag
        /// </param>
        /// <param name="environments">
        /// The configuration for the flag in different environments
        /// </param>
        /// <param name="variants">
        /// The variants of the flag
        /// </param>
        /// <param name="seed">
        /// A random seed to prevent split points in different flags from having the same targets
        /// </param>
        /// <param name="description">
        /// A description of the flag
        /// </param>
        /// <param name="state"></param>
        /// <param name="maintainerIds">
        /// The user ids of the maintainers of the flag
        /// </param>
        /// <param name="permanent">
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </param>
        /// <param name="tags">
        /// Tags for categorizing the flag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequest(
            string slug,
            global::Vercel.CreateFlagRequestKind kind,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateFlagRequestEnvironments2> environments,
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestVariant>? variants,
            double? seed,
            string? description,
            global::Vercel.CreateFlagRequestState? state,
            global::System.Collections.Generic.IList<string>? maintainerIds,
            bool? permanent,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Kind = kind;
            this.Variants = variants;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Seed = seed;
            this.Description = description;
            this.State = state;
            this.MaintainerIds = maintainerIds;
            this.Permanent = permanent;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequest" /> class.
        /// </summary>
        public CreateFlagRequest()
        {
        }
    }
}