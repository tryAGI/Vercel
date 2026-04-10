
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A credit balance for a particular token type
    /// </summary>
    public sealed partial class SubmitPrepaymentBalancesRequestBalance
    {
        /// <summary>
        /// Partner's resource ID, exclude if credits are tied to the installation and not an individual resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// A human-readable description of the credits the user currently has, e.g. "2,000 Tokens"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit")]
        public string? Credit { get; set; }

        /// <summary>
        /// The name of the credits, for display purposes, e.g. "Tokens"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameLabel")]
        public string? NameLabel { get; set; }

        /// <summary>
        /// The dollar value of the credit balance, in USD and provided in cents, which is used to trigger automatic purchase thresholds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currencyValueInCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrencyValueInCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPrepaymentBalancesRequestBalance" /> class.
        /// </summary>
        /// <param name="currencyValueInCents">
        /// The dollar value of the credit balance, in USD and provided in cents, which is used to trigger automatic purchase thresholds.
        /// </param>
        /// <param name="resourceId">
        /// Partner's resource ID, exclude if credits are tied to the installation and not an individual resource.
        /// </param>
        /// <param name="credit">
        /// A human-readable description of the credits the user currently has, e.g. "2,000 Tokens"
        /// </param>
        /// <param name="nameLabel">
        /// The name of the credits, for display purposes, e.g. "Tokens"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitPrepaymentBalancesRequestBalance(
            double currencyValueInCents,
            string? resourceId,
            string? credit,
            string? nameLabel)
        {
            this.ResourceId = resourceId;
            this.Credit = credit;
            this.NameLabel = nameLabel;
            this.CurrencyValueInCents = currencyValueInCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPrepaymentBalancesRequestBalance" /> class.
        /// </summary>
        public SubmitPrepaymentBalancesRequestBalance()
        {
        }
    }
}