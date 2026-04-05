
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainResponseVariant2ProjectAccessVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant2ProjectAccessVariant1AccessJsonConverter))]
        public global::Vercel.GetDrainResponseVariant2ProjectAccessVariant1Access Access { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant2ProjectAccessVariant1ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainResponseVariant2ProjectAccessVariant1ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant2ProjectAccessVariant1" /> class.
        /// </summary>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainResponseVariant2ProjectAccessVariant1(
            global::Vercel.GetDrainResponseVariant2ProjectAccessVariant1ManagedBy managedBy,
            global::Vercel.GetDrainResponseVariant2ProjectAccessVariant1Access access)
        {
            this.Access = access;
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant2ProjectAccessVariant1" /> class.
        /// </summary>
        public GetDrainResponseVariant2ProjectAccessVariant1()
        {
        }
    }
}