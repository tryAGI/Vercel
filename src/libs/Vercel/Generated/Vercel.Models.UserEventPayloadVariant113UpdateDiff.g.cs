
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant113UpdateDiff
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newKey")]
        public string? NewKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldTarget")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffOldTargetItem>? OldTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTarget")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffNewTargetItem>? NewTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldType")]
        public string? OldType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newType")]
        public string? NewType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldProjects")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffOldProject>? OldProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjects")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffNewProject>? NewProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldCustomEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? OldCustomEnvironmentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newCustomEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? NewCustomEnvironmentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ChangedValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant113UpdateDiff" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="changedValue"></param>
        /// <param name="key"></param>
        /// <param name="newKey"></param>
        /// <param name="oldTarget"></param>
        /// <param name="newTarget"></param>
        /// <param name="oldType"></param>
        /// <param name="newType"></param>
        /// <param name="oldProjects"></param>
        /// <param name="newProjects"></param>
        /// <param name="oldCustomEnvironmentIds"></param>
        /// <param name="newCustomEnvironmentIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant113UpdateDiff(
            string id,
            bool changedValue,
            string? key,
            string? newKey,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffOldTargetItem>? oldTarget,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffNewTargetItem>? newTarget,
            string? oldType,
            string? newType,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffOldProject>? oldProjects,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant113UpdateDiffNewProject>? newProjects,
            global::System.Collections.Generic.IList<string>? oldCustomEnvironmentIds,
            global::System.Collections.Generic.IList<string>? newCustomEnvironmentIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key;
            this.NewKey = newKey;
            this.OldTarget = oldTarget;
            this.NewTarget = newTarget;
            this.OldType = oldType;
            this.NewType = newType;
            this.OldProjects = oldProjects;
            this.NewProjects = newProjects;
            this.OldCustomEnvironmentIds = oldCustomEnvironmentIds;
            this.NewCustomEnvironmentIds = newCustomEnvironmentIds;
            this.ChangedValue = changedValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant113UpdateDiff" /> class.
        /// </summary>
        public UserEventPayloadVariant113UpdateDiff()
        {
        }
    }
}