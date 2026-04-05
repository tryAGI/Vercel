
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsByIdOrNameCustomEnvironmentsResponse
    {
        /// <summary>
        /// The maximum number of custom environments allowed either by the team's plan type or a custom override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit AccountLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponse" /> class.
        /// </summary>
        /// <param name="accountLimit">
        /// The maximum number of custom environments allowed either by the team's plan type or a custom override.
        /// </param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsByIdOrNameCustomEnvironmentsResponse(
            global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit accountLimit,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironment> environments)
        {
            this.AccountLimit = accountLimit ?? throw new global::System.ArgumentNullException(nameof(accountLimit));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponse" /> class.
        /// </summary>
        public GetProjectsByIdOrNameCustomEnvironmentsResponse()
        {
        }
    }
}