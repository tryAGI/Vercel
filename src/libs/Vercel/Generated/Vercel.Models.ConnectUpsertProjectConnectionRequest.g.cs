
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Environments enabled for a connector project connection.
    /// </summary>
    public sealed partial class ConnectUpsertProjectConnectionRequest
    {
        /// <summary>
        /// One or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUpsertProjectConnectionRequest" /> class.
        /// </summary>
        /// <param name="environments">
        /// One or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectUpsertProjectConnectionRequest(
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>> environments)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUpsertProjectConnectionRequest" /> class.
        /// </summary>
        public ConnectUpsertProjectConnectionRequest()
        {
        }

    }
}