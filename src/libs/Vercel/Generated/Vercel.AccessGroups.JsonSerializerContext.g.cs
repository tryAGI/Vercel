
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateAccessGroupRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupRequestProjectRole), TypeInfoPropertyName = "UpdateAccessGroupRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupRequestProjectRole), TypeInfoPropertyName = "CreateAccessGroupRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectRequestRole), TypeInfoPropertyName = "CreateAccessGroupProjectRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectRequestRole), TypeInfoPropertyName = "UpdateAccessGroupProjectRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ReadAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupResponseEntitlement), TypeInfoPropertyName = "ReadAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ReadAccessGroupResponseTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupResponseTeamPermission), TypeInfoPropertyName = "ReadAccessGroupResponseTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupResponseEntitlement), TypeInfoPropertyName = "UpdateAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListAccessGroupMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupMembersResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole), TypeInfoPropertyName = "ListAccessGroupMembersResponseMemberTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupMembersResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListAccessGroupsResponseVariant2>), TypeInfoPropertyName = "OneOfObjectListAccessGroupsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListAccessGroupsResponseVariant2AccessGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupsResponseVariant2AccessGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupsResponseVariant2Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupResponseEntitlement), TypeInfoPropertyName = "CreateAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListAccessGroupProjectsResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponseProjectProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole), TypeInfoPropertyName = "ListAccessGroupProjectsResponseProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectResponseRole), TypeInfoPropertyName = "CreateAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupProjectResponseRole), TypeInfoPropertyName = "ReadAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectResponseRole), TypeInfoPropertyName = "UpdateAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupRequestProjectRole?), TypeInfoPropertyName = "NullableUpdateAccessGroupRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupRequestProjectRole?), TypeInfoPropertyName = "NullableCreateAccessGroupRequestProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectRequestRole?), TypeInfoPropertyName = "NullableCreateAccessGroupProjectRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectRequestRole?), TypeInfoPropertyName = "NullableUpdateAccessGroupProjectRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupResponseEntitlement?), TypeInfoPropertyName = "NullableReadAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupResponseTeamPermission?), TypeInfoPropertyName = "NullableReadAccessGroupResponseTeamPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupResponseEntitlement?), TypeInfoPropertyName = "NullableUpdateAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole?), TypeInfoPropertyName = "NullableListAccessGroupMembersResponseMemberTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListAccessGroupsResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfObjectListAccessGroupsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupResponseEntitlement?), TypeInfoPropertyName = "NullableCreateAccessGroupResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole?), TypeInfoPropertyName = "NullableListAccessGroupProjectsResponseProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAccessGroupProjectResponseRole?), TypeInfoPropertyName = "NullableCreateAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadAccessGroupProjectResponseRole?), TypeInfoPropertyName = "NullableReadAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAccessGroupProjectResponseRole?), TypeInfoPropertyName = "NullableUpdateAccessGroupProjectResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateAccessGroupRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateAccessGroupRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ReadAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ReadAccessGroupResponseTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAccessGroupMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAccessGroupsResponseVariant2AccessGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateAccessGroupResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAccessGroupProjectsResponseProject>))]
    internal sealed partial class AccessGroupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccessGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccessGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.ListAccessGroupsResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.UnixTimestampJsonConverter());
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
                    typeToConvert == typeof(global::Vercel.UpdateAccessGroupRequestProjectRole)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupRequestProjectRole?)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupRequestProjectRole)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupRequestProjectRole?)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectRequestRole)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectRequestRole?)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectRequestRole)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectRequestRole?)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseEntitlement)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseEntitlement?)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseTeamPermission)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseTeamPermission?)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupResponseEntitlement)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupResponseEntitlement?)

                    || typeToConvert == typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole)

                    || typeToConvert == typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole?)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupResponseEntitlement)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupResponseEntitlement?)

                    || typeToConvert == typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole)

                    || typeToConvert == typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole?)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectResponseRole)

                    || typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectResponseRole?)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupProjectResponseRole)

                    || typeToConvert == typeof(global::Vercel.ReadAccessGroupProjectResponseRole?)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectResponseRole)

                    || typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectResponseRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupRequestProjectRole))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupRequestProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupRequestProjectRole?))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupRequestProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupRequestProjectRole))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupRequestProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupRequestProjectRole?))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupRequestProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectRequestRole))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupProjectRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectRequestRole?))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupProjectRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectRequestRole))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupProjectRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectRequestRole?))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupProjectRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseEntitlement))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupResponseEntitlementJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseEntitlement?))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupResponseEntitlementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseTeamPermission))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupResponseTeamPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupResponseTeamPermission?))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupResponseTeamPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupResponseEntitlement))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupResponseEntitlementJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupResponseEntitlement?))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupResponseEntitlementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole))
                {
                    return new global::Vercel.JsonConverters.ListAccessGroupMembersResponseMemberTeamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAccessGroupMembersResponseMemberTeamRole?))
                {
                    return new global::Vercel.JsonConverters.ListAccessGroupMembersResponseMemberTeamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupResponseEntitlement))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupResponseEntitlementJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupResponseEntitlement?))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupResponseEntitlementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole))
                {
                    return new global::Vercel.JsonConverters.ListAccessGroupProjectsResponseProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAccessGroupProjectsResponseProjectRole?))
                {
                    return new global::Vercel.JsonConverters.ListAccessGroupProjectsResponseProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectResponseRole))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupProjectResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateAccessGroupProjectResponseRole?))
                {
                    return new global::Vercel.JsonConverters.CreateAccessGroupProjectResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupProjectResponseRole))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupProjectResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReadAccessGroupProjectResponseRole?))
                {
                    return new global::Vercel.JsonConverters.ReadAccessGroupProjectResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectResponseRole))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupProjectResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateAccessGroupProjectResponseRole?))
                {
                    return new global::Vercel.JsonConverters.UpdateAccessGroupProjectResponseRoleNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new AccessGroupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}