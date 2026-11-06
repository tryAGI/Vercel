
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberRole), TypeInfoPropertyName = "InvitedTeamMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberTeamPermission), TypeInfoPropertyName = "InvitedTeamMemberTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberTeamRole), TypeInfoPropertyName = "InvitedTeamMemberTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Team))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimited))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.TeamLimitedLimitedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedLimitedByItem), TypeInfoPropertyName = "TeamLimitedLimitedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlConnectionSyncState), TypeInfoPropertyName = "TeamLimitedSamlConnectionSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlDirectory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlDirectorySyncState), TypeInfoPropertyName = "TeamLimitedSamlDirectorySyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared39b84c098d962a66Entitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66Entitlement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin), TypeInfoPropertyName = "AutoSDKShared39b84c098d962a66JoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role), TypeInfoPropertyName = "AutoSDKShared39b84c098d962a66Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission), TypeInfoPropertyName = "AutoSDKShared39b84c098d962a66TeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared39b84c098d962a66TeamRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole), TypeInfoPropertyName = "AutoSDKShared39b84c098d962a66TeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.InviteUserToTeamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItemRole), TypeInfoPropertyName = "InviteUserToTeamRequestItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.InviteUserToTeamRequestItemProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItemProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole), TypeInfoPropertyName = "InviteUserToTeamRequestItemProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamRequestJoinedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin), TypeInfoPropertyName = "RequestAccessToTeamRequestJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.JoinTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission), TypeInfoPropertyName = "UpdateTeamMemberRequestTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestProjectRole), TypeInfoPropertyName = "UpdateTeamMemberRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestJoinedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateTeamRequestAttribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateTeamRequestAttributionUtm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PostTeamDsyncRolesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.DeleteTeamRequestReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteTeamRequestReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateMicrofrontendsGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamMembersRole), TypeInfoPropertyName = "GetTeamMembersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseBitbucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseGitlab))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseJoinedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin), TypeInfoPropertyName = "RequestAccessToTeamResponseJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseBitbucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseGitlab))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin), TypeInfoPropertyName = "GetTeamAccessRequestResponseJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.JoinTeamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RemoveTeamMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>), TypeInfoPropertyName = "OneOfTeamTeamLimited2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateTeamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PostTeamDsyncRolesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteTeamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteTeamInviteCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateMicrofrontendsGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateMicrofrontendsGroupResponseUpdatedMicrofrontendsGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberRole?), TypeInfoPropertyName = "NullableInvitedTeamMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberTeamPermission?), TypeInfoPropertyName = "NullableInvitedTeamMemberTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvitedTeamMemberTeamRole?), TypeInfoPropertyName = "NullableInvitedTeamMemberTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedLimitedByItem?), TypeInfoPropertyName = "NullableTeamLimitedLimitedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlConnectionSyncState?), TypeInfoPropertyName = "NullableTeamLimitedSamlConnectionSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TeamLimitedSamlDirectorySyncState?), TypeInfoPropertyName = "NullableTeamLimitedSamlDirectorySyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin?), TypeInfoPropertyName = "NullableAutoSDKShared39b84c098d962a66JoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role?), TypeInfoPropertyName = "NullableAutoSDKShared39b84c098d962a66Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission?), TypeInfoPropertyName = "NullableAutoSDKShared39b84c098d962a66TeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole?), TypeInfoPropertyName = "NullableAutoSDKShared39b84c098d962a66TeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItemRole?), TypeInfoPropertyName = "NullableInviteUserToTeamRequestItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole?), TypeInfoPropertyName = "NullableInviteUserToTeamRequestItemProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin?), TypeInfoPropertyName = "NullableRequestAccessToTeamRequestJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission?), TypeInfoPropertyName = "NullableUpdateTeamMemberRequestTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateTeamMemberRequestProjectRole?), TypeInfoPropertyName = "NullableUpdateTeamMemberRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamMembersRole?), TypeInfoPropertyName = "NullableGetTeamMembersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin?), TypeInfoPropertyName = "NullableRequestAccessToTeamResponseJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin?), TypeInfoPropertyName = "NullableGetTeamAccessRequestResponseJoinedFromOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>?), TypeInfoPropertyName = "NullableOneOfTeamTeamLimited2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.InvitedTeamMemberTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.InvitedTeamMemberTeamRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.TeamLimitedLimitedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared39b84c098d962a66Entitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared39b84c098d962a66TeamRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.InviteUserToTeamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.InviteUserToTeamRequestItemProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateTeamMemberRequestTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateTeamMemberRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.DeleteTeamRequestReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>>))]
    internal sealed partial class TeamsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TeamsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TeamsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::Vercel.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.Team, global::Vercel.TeamLimited>());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vercel.InvitedTeamMemberRole)

                    || typeToConvert == typeof(global::Vercel.InvitedTeamMemberRole?)

                    || typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamPermission)

                    || typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamPermission?)

                    || typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamRole)

                    || typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamRole?)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedLimitedByItem)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedLimitedByItem?)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedSamlConnectionSyncState)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedSamlConnectionSyncState?)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedSamlDirectorySyncState)

                    || typeToConvert == typeof(global::Vercel.TeamLimitedSamlDirectorySyncState?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole?)

                    || typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemRole)

                    || typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemRole?)

                    || typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole)

                    || typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole?)

                    || typeToConvert == typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin)

                    || typeToConvert == typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin?)

                    || typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission)

                    || typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission?)

                    || typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestProjectRole)

                    || typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestProjectRole?)

                    || typeToConvert == typeof(global::Vercel.GetTeamMembersRole)

                    || typeToConvert == typeof(global::Vercel.GetTeamMembersRole?)

                    || typeToConvert == typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin)

                    || typeToConvert == typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin?)

                    || typeToConvert == typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin)

                    || typeToConvert == typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberRole))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberRole?))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamPermission))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberTeamPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamPermission?))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberTeamPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamRole))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberTeamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvitedTeamMemberTeamRole?))
                {
                    return new global::Vercel.JsonConverters.InvitedTeamMemberTeamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedLimitedByItem))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedLimitedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedLimitedByItem?))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedLimitedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedSamlConnectionSyncState))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedSamlConnectionSyncStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedSamlConnectionSyncState?))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedSamlConnectionSyncStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedSamlDirectorySyncState))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedSamlDirectorySyncStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TeamLimitedSamlDirectorySyncState?))
                {
                    return new global::Vercel.JsonConverters.TeamLimitedSamlDirectorySyncStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66JoinedFromOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66JoinedFromOrigin?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66JoinedFromOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66Role?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66TeamPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamPermission?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66TeamPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66TeamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared39b84c098d962a66TeamRole?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared39b84c098d962a66TeamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemRole))
                {
                    return new global::Vercel.JsonConverters.InviteUserToTeamRequestItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemRole?))
                {
                    return new global::Vercel.JsonConverters.InviteUserToTeamRequestItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole))
                {
                    return new global::Vercel.JsonConverters.InviteUserToTeamRequestItemProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InviteUserToTeamRequestItemProjectRole?))
                {
                    return new global::Vercel.JsonConverters.InviteUserToTeamRequestItemProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin))
                {
                    return new global::Vercel.JsonConverters.RequestAccessToTeamRequestJoinedFromOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin?))
                {
                    return new global::Vercel.JsonConverters.RequestAccessToTeamRequestJoinedFromOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission))
                {
                    return new global::Vercel.JsonConverters.UpdateTeamMemberRequestTeamPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestTeamPermission?))
                {
                    return new global::Vercel.JsonConverters.UpdateTeamMemberRequestTeamPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestProjectRole))
                {
                    return new global::Vercel.JsonConverters.UpdateTeamMemberRequestProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateTeamMemberRequestProjectRole?))
                {
                    return new global::Vercel.JsonConverters.UpdateTeamMemberRequestProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetTeamMembersRole))
                {
                    return new global::Vercel.JsonConverters.GetTeamMembersRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetTeamMembersRole?))
                {
                    return new global::Vercel.JsonConverters.GetTeamMembersRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin))
                {
                    return new global::Vercel.JsonConverters.RequestAccessToTeamResponseJoinedFromOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RequestAccessToTeamResponseJoinedFromOrigin?))
                {
                    return new global::Vercel.JsonConverters.RequestAccessToTeamResponseJoinedFromOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin))
                {
                    return new global::Vercel.JsonConverters.GetTeamAccessRequestResponseJoinedFromOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin?))
                {
                    return new global::Vercel.JsonConverters.GetTeamAccessRequestResponseJoinedFromOriginNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TeamsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}