
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1AccessJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1Access Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1" /> class.
        /// </summary>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1(
            global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy managedBy,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1Access access)
        {
            this.Access = access;
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1()
        {
        }

    }
}