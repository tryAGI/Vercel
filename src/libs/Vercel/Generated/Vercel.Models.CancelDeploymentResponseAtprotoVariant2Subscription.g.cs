
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseAtprotoVariant2Subscription
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Collections { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dids")]
        public global::System.Collections.Generic.IList<string>? Dids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kinds")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseAtprotoVariant2SubscriptionKind>? Kinds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAtprotoVariant2Subscription" /> class.
        /// </summary>
        /// <param name="collections"></param>
        /// <param name="path"></param>
        /// <param name="dids"></param>
        /// <param name="kinds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseAtprotoVariant2Subscription(
            global::System.Collections.Generic.IList<string> collections,
            string path,
            global::System.Collections.Generic.IList<string>? dids,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseAtprotoVariant2SubscriptionKind>? kinds)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.Dids = dids;
            this.Kinds = kinds;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAtprotoVariant2Subscription" /> class.
        /// </summary>
        public CancelDeploymentResponseAtprotoVariant2Subscription()
        {
        }

    }
}