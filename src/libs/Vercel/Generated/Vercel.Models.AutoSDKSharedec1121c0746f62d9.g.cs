
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedec1121c0746f62d9
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedec1121c0746f62d9HaVariant1, global::Vercel.AutoSDKSharedec1121c0746f62d9HaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedec1121c0746f62d9MissingItemVariant1, global::Vercel.AutoSDKSharedec1121c0746f62d9MissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedec1121c0746f62d9" /> class.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        /// <param name="env"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="permanent"></param>
        /// <param name="statusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedec1121c0746f62d9(
            string destination,
            string source,
            global::System.Collections.Generic.IList<string>? env,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedec1121c0746f62d9HaVariant1, global::Vercel.AutoSDKSharedec1121c0746f62d9HaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedec1121c0746f62d9MissingItemVariant1, global::Vercel.AutoSDKSharedec1121c0746f62d9MissingItemVariant2>>? missing,
            bool? permanent,
            double? statusCode)
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Env = env;
            this.Has = has;
            this.Missing = missing;
            this.Permanent = permanent;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedec1121c0746f62d9" /> class.
        /// </summary>
        public AutoSDKSharedec1121c0746f62d9()
        {
        }

    }
}