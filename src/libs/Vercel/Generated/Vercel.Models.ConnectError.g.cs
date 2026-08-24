
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Error response returned by a Connect API operation.
    /// </summary>
    public sealed partial class ConnectError
    {
        /// <summary>
        /// Error details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectErrorError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectError(
            global::Vercel.ConnectErrorError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectError" /> class.
        /// </summary>
        public ConnectError()
        {
        }

    }
}