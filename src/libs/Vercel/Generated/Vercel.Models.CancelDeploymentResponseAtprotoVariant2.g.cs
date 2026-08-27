
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseAtprotoVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseAtprotoVariant2Subscription Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAtprotoVariant2" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="subscription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseAtprotoVariant2(
            bool enabled,
            global::Vercel.CancelDeploymentResponseAtprotoVariant2Subscription subscription)
        {
            this.Enabled = enabled;
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAtprotoVariant2" /> class.
        /// </summary>
        public CancelDeploymentResponseAtprotoVariant2()
        {
        }

    }
}