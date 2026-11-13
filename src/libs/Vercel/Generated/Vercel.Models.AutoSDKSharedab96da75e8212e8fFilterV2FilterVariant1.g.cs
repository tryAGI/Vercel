
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Deployment? Deployment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Log? Log { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Project? Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1" /> class.
        /// </summary>
        /// <param name="deployment"></param>
        /// <param name="log"></param>
        /// <param name="project"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1(
            global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Deployment? deployment,
            global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Log? log,
            global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Project? project,
            global::Vercel.AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1Type type)
        {
            this.Deployment = deployment;
            this.Log = log;
            this.Project = project;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1" /> class.
        /// </summary>
        public AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1()
        {
        }

    }
}