
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableResponseFailedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateSharedEnvVariableResponseFailedItemError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponseFailedItem" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableResponseFailedItem(
            global::Vercel.UpdateSharedEnvVariableResponseFailedItemError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponseFailedItem" /> class.
        /// </summary>
        public UpdateSharedEnvVariableResponseFailedItem()
        {
        }
    }
}