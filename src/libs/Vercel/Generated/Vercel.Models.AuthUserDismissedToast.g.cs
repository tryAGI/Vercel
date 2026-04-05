
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A record of when, under a certain scopeId, a toast was dismissed
    /// </summary>
    public sealed partial class AuthUserDismissedToast
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToastDismissal> Dismissals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDismissedToast" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dismissals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserDismissedToast(
            string name,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToastDismissal> dismissals)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dismissals = dismissals ?? throw new global::System.ArgumentNullException(nameof(dismissals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDismissedToast" /> class.
        /// </summary>
        public AuthUserDismissedToast()
        {
        }
    }
}