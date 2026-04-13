
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant107UpdateDiff
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
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffOldTargetItem>? OldTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTarget")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffNewTargetItem>? NewTarget { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffOldProject>? OldProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjects")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffNewProject>? NewProjects { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant107UpdateDiff" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant107UpdateDiff(
            string id,
            bool changedValue,
            string? key,
            string? newKey,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffOldTargetItem>? oldTarget,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffNewTargetItem>? newTarget,
            string? oldType,
            string? newType,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffOldProject>? oldProjects,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant107UpdateDiffNewProject>? newProjects)
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
            this.ChangedValue = changedValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant107UpdateDiff" /> class.
        /// </summary>
        public UserEventPayloadVariant107UpdateDiff()
        {
        }
    }
}