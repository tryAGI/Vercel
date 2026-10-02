
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failIfNoMatch")]
        public bool? FailIfNoMatch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Filters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3JobJsonConverter))]
        public global::Vercel.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job Job { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3KindJsonConverter))]
        public global::Vercel.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="task"></param>
        /// <param name="failIfNoMatch"></param>
        /// <param name="job"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3(
            global::System.Collections.Generic.IList<string> filters,
            string task,
            bool? failIfNoMatch,
            global::Vercel.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job job,
            global::Vercel.AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Kind kind)
        {
            this.FailIfNoMatch = failIfNoMatch;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Job = job;
            this.Kind = kind;
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3" /> class.
        /// </summary>
        public AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3()
        {
        }

    }
}