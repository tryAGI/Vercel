
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBypassIpResponseVariant1
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AddBypassIpResponseVariant1ResultItem> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public object? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant1" /> class.
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="result"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddBypassIpResponseVariant1(
            bool ok,
            global::System.Collections.Generic.IList<global::Vercel.AddBypassIpResponseVariant1ResultItem> result,
            object? pagination)
        {
            this.Ok = ok;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpResponseVariant1" /> class.
        /// </summary>
        public AddBypassIpResponseVariant1()
        {
        }
    }
}