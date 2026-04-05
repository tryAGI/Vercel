
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBypassIpResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Vercel.AddBypassIpResponseVariant2ResultItem>? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant2" /> class.
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddBypassIpResponseVariant2(
            bool ok,
            global::System.Collections.Generic.IList<global::Vercel.AddBypassIpResponseVariant2ResultItem>? result)
        {
            this.Ok = ok;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant2" /> class.
        /// </summary>
        public AddBypassIpResponseVariant2()
        {
        }
    }
}