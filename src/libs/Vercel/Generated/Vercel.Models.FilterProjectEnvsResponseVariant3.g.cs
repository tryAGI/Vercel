
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The list of environment variables for the given project
    /// </summary>
    public sealed partial class FilterProjectEnvsResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.FilterProjectEnvsResponseVariant3Env> Envs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hiddenProductionEnvCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HiddenProductionEnvCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3" /> class.
        /// </summary>
        /// <param name="envs"></param>
        /// <param name="hiddenProductionEnvCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterProjectEnvsResponseVariant3(
            global::System.Collections.Generic.IList<global::Vercel.FilterProjectEnvsResponseVariant3Env> envs,
            double hiddenProductionEnvCount)
        {
            this.Envs = envs ?? throw new global::System.ArgumentNullException(nameof(envs));
            this.HiddenProductionEnvCount = hiddenProductionEnvCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3" /> class.
        /// </summary>
        public FilterProjectEnvsResponseVariant3()
        {
        }
    }
}