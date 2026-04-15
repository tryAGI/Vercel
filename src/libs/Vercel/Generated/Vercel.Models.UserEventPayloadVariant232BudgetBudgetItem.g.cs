
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Represents a budget for tracking and notifying teams on their spending.
    /// </summary>
    public sealed partial class UserEventPayloadVariant232BudgetBudgetItem
    {
        /// <summary>
        /// The budget type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant232BudgetBudgetItemTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant232BudgetBudgetItemType Type { get; set; }

        /// <summary>
        /// Budget amount (USD / dollars)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixedBudget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FixedBudget { get; set; }

        /// <summary>
        /// Array of the last 3 months of spend data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> PreviousSpend { get; set; }

        /// <summary>
        /// Array of 50, 75, 100 to keep track of notifications sent out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> NotifiedAt { get; set; }

        /// <summary>
        /// Webhook id that corresponds to a webhook in Cosmos webhook collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// Keep track if the webhook has been called for the month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookNotified")]
        public bool? WebhookNotified { get; set; }

        /// <summary>
        /// Date time when budget is created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Date time when budget is updated last
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Is the budget currently active for a customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Should all projects be paused if budget is exceeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pauseProjects")]
        public bool? PauseProjects { get; set; }

        /// <summary>
        /// The acive pricing plan the team is billed with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant232BudgetBudgetItemPricingPlanJsonConverter))]
        public global::Vercel.UserEventPayloadVariant232BudgetBudgetItemPricingPlan? PricingPlan { get; set; }

        /// <summary>
        /// Partition key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Sort key that needs to be unique per teamId
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232BudgetBudgetItem" /> class.
        /// </summary>
        /// <param name="fixedBudget">
        /// Budget amount (USD / dollars)
        /// </param>
        /// <param name="previousSpend">
        /// Array of the last 3 months of spend data
        /// </param>
        /// <param name="notifiedAt">
        /// Array of 50, 75, 100 to keep track of notifications sent out
        /// </param>
        /// <param name="createdAt">
        /// Date time when budget is created
        /// </param>
        /// <param name="isActive">
        /// Is the budget currently active for a customer
        /// </param>
        /// <param name="teamId">
        /// Partition key
        /// </param>
        /// <param name="id">
        /// Sort key that needs to be unique per teamId
        /// </param>
        /// <param name="type">
        /// The budget type
        /// </param>
        /// <param name="webhookId">
        /// Webhook id that corresponds to a webhook in Cosmos webhook collection
        /// </param>
        /// <param name="webhookNotified">
        /// Keep track if the webhook has been called for the month
        /// </param>
        /// <param name="updatedAt">
        /// Date time when budget is updated last
        /// </param>
        /// <param name="pauseProjects">
        /// Should all projects be paused if budget is exceeded
        /// </param>
        /// <param name="pricingPlan">
        /// The acive pricing plan the team is billed with
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant232BudgetBudgetItem(
            double fixedBudget,
            global::System.Collections.Generic.IList<double> previousSpend,
            global::System.Collections.Generic.IList<double> notifiedAt,
            double createdAt,
            bool isActive,
            string teamId,
            string id,
            global::Vercel.UserEventPayloadVariant232BudgetBudgetItemType type,
            string? webhookId,
            bool? webhookNotified,
            double? updatedAt,
            bool? pauseProjects,
            global::Vercel.UserEventPayloadVariant232BudgetBudgetItemPricingPlan? pricingPlan)
        {
            this.Type = type;
            this.FixedBudget = fixedBudget;
            this.PreviousSpend = previousSpend ?? throw new global::System.ArgumentNullException(nameof(previousSpend));
            this.NotifiedAt = notifiedAt ?? throw new global::System.ArgumentNullException(nameof(notifiedAt));
            this.WebhookId = webhookId;
            this.WebhookNotified = webhookNotified;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsActive = isActive;
            this.PauseProjects = pauseProjects;
            this.PricingPlan = pricingPlan;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232BudgetBudgetItem" /> class.
        /// </summary>
        public UserEventPayloadVariant232BudgetBudgetItem()
        {
        }
    }
}