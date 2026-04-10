
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersionData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainerIds")]
        public global::System.Collections.Generic.IList<string>? MaintainerIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        public global::Vercel.ListFlagVersionsResponseVersionDataExperiment? Experiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Variants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.ListFlagVersionsResponseVersionDataEnvironments2> Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionDataState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionData" /> class.
        /// </summary>
        /// <param name="variants"></param>
        /// <param name="environments"></param>
        /// <param name="seed"></param>
        /// <param name="state"></param>
        /// <param name="description"></param>
        /// <param name="maintainerIds"></param>
        /// <param name="permanent"></param>
        /// <param name="tags"></param>
        /// <param name="experiment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagVersionsResponseVersionData(
            global::System.Collections.Generic.IList<object> variants,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.ListFlagVersionsResponseVersionDataEnvironments2> environments,
            double seed,
            global::Vercel.ListFlagVersionsResponseVersionDataState state,
            string? description,
            global::System.Collections.Generic.IList<string>? maintainerIds,
            bool? permanent,
            global::System.Collections.Generic.IList<string>? tags,
            global::Vercel.ListFlagVersionsResponseVersionDataExperiment? experiment)
        {
            this.Description = description;
            this.MaintainerIds = maintainerIds;
            this.Permanent = permanent;
            this.Tags = tags;
            this.Experiment = experiment;
            this.Variants = variants ?? throw new global::System.ArgumentNullException(nameof(variants));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Seed = seed;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionData" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersionData()
        {
        }
    }
}