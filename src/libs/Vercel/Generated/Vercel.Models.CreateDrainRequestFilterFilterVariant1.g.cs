
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequestFilterFilterVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.CreateDrainRequestFilterFilterVariant1Project? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public global::Vercel.CreateDrainRequestFilterFilterVariant1Log? Log { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.CreateDrainRequestFilterFilterVariant1Deployment? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestFilterFilterVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="project"></param>
        /// <param name="log"></param>
        /// <param name="deployment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequestFilterFilterVariant1(
            string type,
            global::Vercel.CreateDrainRequestFilterFilterVariant1Project? project,
            global::Vercel.CreateDrainRequestFilterFilterVariant1Log? log,
            global::Vercel.CreateDrainRequestFilterFilterVariant1Deployment? deployment)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Project = project;
            this.Log = log;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestFilterFilterVariant1" /> class.
        /// </summary>
        public CreateDrainRequestFilterFilterVariant1()
        {
        }
    }
}