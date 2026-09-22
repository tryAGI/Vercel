
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRollingReleaseBillingStatusResponseVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableSlots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvailableSlots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledProjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant3ReasonJsonConverter))]
        public global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseBillingStatusResponseVariant3" /> class.
        /// </summary>
        /// <param name="availableSlots"></param>
        /// <param name="enabledProjects"></param>
        /// <param name="message"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRollingReleaseBillingStatusResponseVariant3(
            double availableSlots,
            global::System.Collections.Generic.IList<string> enabledProjects,
            string message,
            global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason reason)
        {
            this.AvailableSlots = availableSlots;
            this.EnabledProjects = enabledProjects ?? throw new global::System.ArgumentNullException(nameof(enabledProjects));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseBillingStatusResponseVariant3" /> class.
        /// </summary>
        public GetRollingReleaseBillingStatusResponseVariant3()
        {
        }

    }
}