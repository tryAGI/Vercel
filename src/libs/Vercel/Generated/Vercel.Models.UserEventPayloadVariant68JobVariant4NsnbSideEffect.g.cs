
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since March 2026 Records a successful NSNB auto-add result so later GitHub PR comments can deterministically explain why this SHA was allowed to deploy.
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant4NsnbSideEffect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant4NsnbSideEffectActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant4NsnbSideEffectAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUserLogin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant4NsnbSideEffect" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="gitUserLogin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68JobVariant4NsnbSideEffect(
            global::Vercel.UserEventPayloadVariant68JobVariant4NsnbSideEffectAction action,
            string gitUserLogin)
        {
            this.Action = action;
            this.GitUserLogin = gitUserLogin ?? throw new global::System.ArgumentNullException(nameof(gitUserLogin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant4NsnbSideEffect" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant4NsnbSideEffect()
        {
        }
    }
}