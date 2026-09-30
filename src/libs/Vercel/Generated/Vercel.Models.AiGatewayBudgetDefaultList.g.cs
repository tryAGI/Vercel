
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayBudgetDefaultList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudgetDefault> Defaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetDefaultList" /> class.
        /// </summary>
        /// <param name="defaults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayBudgetDefaultList(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudgetDefault> defaults)
        {
            this.Defaults = defaults ?? throw new global::System.ArgumentNullException(nameof(defaults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetDefaultList" /> class.
        /// </summary>
        public AiGatewayBudgetDefaultList()
        {
        }

    }
}