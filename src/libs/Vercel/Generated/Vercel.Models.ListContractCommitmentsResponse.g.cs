
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Contract commitment information describing terms within a contract. New in FOCUS v1.3 - tracks commitment terms separate from cost/usage rows. For Vercel: - Pro: $20 monthly spend commitment - Enterprise: MIU allocation per period (usage commitment)
    /// </summary>
    public sealed partial class ListContractCommitmentsResponse
    {
        /// <summary>
        /// Highest-level classification of the contract commitment. 'Spend' for Pro ($20/month), 'Usage' for Enterprise (MIU allocation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListContractCommitmentsResponseContractCommitmentCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListContractCommitmentsResponseContractCommitmentCategory ContractCommitmentCategory { get; set; }

        /// <summary>
        /// Monetary value of the contract commitment (in BillingCurrency). Required when ContractCommitmentCategory is 'Spend'. For Pro: 20 (USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentCost")]
        public double? ContractCommitmentCost { get; set; }

        /// <summary>
        /// Self-contained summary of the contract commitment's terms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentDescription")]
        public string? ContractCommitmentDescription { get; set; }

        /// <summary>
        /// Unique identifier for a single contract term within a contract. Maps to specific commitment period or allocation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractCommitmentId { get; set; }

        /// <summary>
        /// Inclusive start of the commitment term period (ISO 8601 UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentPeriodStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractCommitmentPeriodStart { get; set; }

        /// <summary>
        /// Exclusive end of the commitment term period (ISO 8601 UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentPeriodEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractCommitmentPeriodEnd { get; set; }

        /// <summary>
        /// Amount associated with the commitment (in ContractCommitmentUnit). Required when ContractCommitmentCategory is 'Usage'. For Enterprise: MIU allocation amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentQuantity")]
        public double? ContractCommitmentQuantity { get; set; }

        /// <summary>
        /// Service-provider-assigned name identifying the commitment type. 'Pro' or 'Enterprise' for Vercel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractCommitmentType { get; set; }

        /// <summary>
        /// Measurement unit for ContractCommitmentQuantity. 'MIUs' for Enterprise, 'USD' for Pro spend commitments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractCommitmentUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractCommitmentUnit { get; set; }

        /// <summary>
        /// Service-provider-assigned identifier for a contract. Maps to Orb Subscription ID for Vercel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractId { get; set; }

        /// <summary>
        /// Inclusive start of the overall contract period (ISO 8601 UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractPeriodStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractPeriodStart { get; set; }

        /// <summary>
        /// Exclusive end of the overall contract period (ISO 8601 UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContractPeriodEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractPeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("BillingCurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingCurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContractCommitmentsResponse" /> class.
        /// </summary>
        /// <param name="contractCommitmentCategory">
        /// Highest-level classification of the contract commitment. 'Spend' for Pro ($20/month), 'Usage' for Enterprise (MIU allocation).
        /// </param>
        /// <param name="contractCommitmentId">
        /// Unique identifier for a single contract term within a contract. Maps to specific commitment period or allocation ID.
        /// </param>
        /// <param name="contractCommitmentPeriodStart">
        /// Inclusive start of the commitment term period (ISO 8601 UTC)
        /// </param>
        /// <param name="contractCommitmentPeriodEnd">
        /// Exclusive end of the commitment term period (ISO 8601 UTC)
        /// </param>
        /// <param name="contractCommitmentType">
        /// Service-provider-assigned name identifying the commitment type. 'Pro' or 'Enterprise' for Vercel.
        /// </param>
        /// <param name="contractCommitmentUnit">
        /// Measurement unit for ContractCommitmentQuantity. 'MIUs' for Enterprise, 'USD' for Pro spend commitments.
        /// </param>
        /// <param name="contractId">
        /// Service-provider-assigned identifier for a contract. Maps to Orb Subscription ID for Vercel.
        /// </param>
        /// <param name="contractPeriodStart">
        /// Inclusive start of the overall contract period (ISO 8601 UTC)
        /// </param>
        /// <param name="contractPeriodEnd">
        /// Exclusive end of the overall contract period (ISO 8601 UTC)
        /// </param>
        /// <param name="billingCurrency"></param>
        /// <param name="contractCommitmentCost">
        /// Monetary value of the contract commitment (in BillingCurrency). Required when ContractCommitmentCategory is 'Spend'. For Pro: 20 (USD)
        /// </param>
        /// <param name="contractCommitmentDescription">
        /// Self-contained summary of the contract commitment's terms
        /// </param>
        /// <param name="contractCommitmentQuantity">
        /// Amount associated with the commitment (in ContractCommitmentUnit). Required when ContractCommitmentCategory is 'Usage'. For Enterprise: MIU allocation amount.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContractCommitmentsResponse(
            global::Vercel.ListContractCommitmentsResponseContractCommitmentCategory contractCommitmentCategory,
            string contractCommitmentId,
            string contractCommitmentPeriodStart,
            string contractCommitmentPeriodEnd,
            string contractCommitmentType,
            string contractCommitmentUnit,
            string contractId,
            string contractPeriodStart,
            string contractPeriodEnd,
            string billingCurrency,
            double? contractCommitmentCost,
            string? contractCommitmentDescription,
            double? contractCommitmentQuantity)
        {
            this.ContractCommitmentCategory = contractCommitmentCategory;
            this.ContractCommitmentCost = contractCommitmentCost;
            this.ContractCommitmentDescription = contractCommitmentDescription;
            this.ContractCommitmentId = contractCommitmentId ?? throw new global::System.ArgumentNullException(nameof(contractCommitmentId));
            this.ContractCommitmentPeriodStart = contractCommitmentPeriodStart ?? throw new global::System.ArgumentNullException(nameof(contractCommitmentPeriodStart));
            this.ContractCommitmentPeriodEnd = contractCommitmentPeriodEnd ?? throw new global::System.ArgumentNullException(nameof(contractCommitmentPeriodEnd));
            this.ContractCommitmentQuantity = contractCommitmentQuantity;
            this.ContractCommitmentType = contractCommitmentType ?? throw new global::System.ArgumentNullException(nameof(contractCommitmentType));
            this.ContractCommitmentUnit = contractCommitmentUnit ?? throw new global::System.ArgumentNullException(nameof(contractCommitmentUnit));
            this.ContractId = contractId ?? throw new global::System.ArgumentNullException(nameof(contractId));
            this.ContractPeriodStart = contractPeriodStart ?? throw new global::System.ArgumentNullException(nameof(contractPeriodStart));
            this.ContractPeriodEnd = contractPeriodEnd ?? throw new global::System.ArgumentNullException(nameof(contractPeriodEnd));
            this.BillingCurrency = billingCurrency ?? throw new global::System.ArgumentNullException(nameof(billingCurrency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContractCommitmentsResponse" /> class.
        /// </summary>
        public ListContractCommitmentsResponse()
        {
        }
    }
}