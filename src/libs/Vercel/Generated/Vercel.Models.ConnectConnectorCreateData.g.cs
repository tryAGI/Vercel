#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Provider configuration. With type, provide the complete configuration for that type. With service and connectionMethod, provide only credentials and preferences; Connect supplies the type, endpoints, templates, and defaults. Other connector types accept an arbitrary object.
    /// </summary>
    public readonly partial struct ConnectConnectorCreateData : global::System.IEquatable<ConnectConnectorCreateData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeOauth? TypeOauth { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeOauth? TypeOauth { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeOauth))]
#endif
        public bool IsTypeOauth => TypeOauth != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeOauth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeOauth? value)
        {
            value = TypeOauth;
            return IsTypeOauth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeOauth PickTypeOauth() => IsTypeOauth
            ? TypeOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeOauth' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeApiKey? TypeApiKey { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeApiKey? TypeApiKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeApiKey))]
#endif
        public bool IsTypeApiKey => TypeApiKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeApiKey? value)
        {
            value = TypeApiKey;
            return IsTypeApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeApiKey PickTypeApiKey() => IsTypeApiKey
            ? TypeApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeGithub? TypeGithub { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeGithub? TypeGithub { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeGithub))]
#endif
        public bool IsTypeGithub => TypeGithub != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeGithub(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeGithub? value)
        {
            value = TypeGithub;
            return IsTypeGithub;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeGithub PickTypeGithub() => IsTypeGithub
            ? TypeGithub!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeGithub' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeLinear? TypeLinear { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeLinear? TypeLinear { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeLinear))]
#endif
        public bool IsTypeLinear => TypeLinear != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeLinear(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeLinear? value)
        {
            value = TypeLinear;
            return IsTypeLinear;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeLinear PickTypeLinear() => IsTypeLinear
            ? TypeLinear!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeLinear' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeLinq? TypeLinq { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeLinq? TypeLinq { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeLinq))]
#endif
        public bool IsTypeLinq => TypeLinq != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeLinq(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeLinq? value)
        {
            value = TypeLinq;
            return IsTypeLinq;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeLinq PickTypeLinq() => IsTypeLinq
            ? TypeLinq!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeLinq' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeSalesforce? TypeSalesforce { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeSalesforce? TypeSalesforce { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeSalesforce))]
#endif
        public bool IsTypeSalesforce => TypeSalesforce != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeSalesforce(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeSalesforce? value)
        {
            value = TypeSalesforce;
            return IsTypeSalesforce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeSalesforce PickTypeSalesforce() => IsTypeSalesforce
            ? TypeSalesforce!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSalesforce' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeSendblue? TypeSendblue { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeSendblue? TypeSendblue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeSendblue))]
#endif
        public bool IsTypeSendblue => TypeSendblue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeSendblue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeSendblue? value)
        {
            value = TypeSendblue;
            return IsTypeSendblue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeSendblue PickTypeSendblue() => IsTypeSendblue
            ? TypeSendblue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSendblue' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeSlack? TypeSlack { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeSlack? TypeSlack { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeSlack))]
#endif
        public bool IsTypeSlack => TypeSlack != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeSlack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeSlack? value)
        {
            value = TypeSlack;
            return IsTypeSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeSlack PickTypeSlack() => IsTypeSlack
            ? TypeSlack!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSlack' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflake? TypeSnowflake { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflake? TypeSnowflake { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeSnowflake))]
#endif
        public bool IsTypeSnowflake => TypeSnowflake != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeSnowflake(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeSnowflake? value)
        {
            value = TypeSnowflake;
            return IsTypeSnowflake;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflake PickTypeSnowflake() => IsTypeSnowflake
            ? TypeSnowflake!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSnowflake' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? TypeSnowflakeWif { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? TypeSnowflakeWif { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeSnowflakeWif))]
#endif
        public bool IsTypeSnowflakeWif => TypeSnowflakeWif != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeSnowflakeWif(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? value)
        {
            value = TypeSnowflakeWif;
            return IsTypeSnowflakeWif;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif PickTypeSnowflakeWif() => IsTypeSnowflakeWif
            ? TypeSnowflakeWif!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSnowflakeWif' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorCreateDataTypePhoton? TypePhoton { get; init; }
#else
        public global::Vercel.ConnectConnectorCreateDataTypePhoton? TypePhoton { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypePhoton))]
#endif
        public bool IsTypePhoton => TypePhoton != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypePhoton(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectConnectorCreateDataTypePhoton? value)
        {
            value = TypePhoton;
            return IsTypePhoton;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorCreateDataTypePhoton PickTypePhoton() => IsTypePhoton
            ? TypePhoton!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypePhoton' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? TypeOther { get; init; }
#else
        public object? TypeOther { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeOther))]
#endif
        public bool IsTypeOther => TypeOther != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeOther(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = TypeOther;
            return IsTypeOther;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickTypeOther() => IsTypeOther
            ? TypeOther!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeOther' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeOauth value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeOauth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeOauth?(ConnectConnectorCreateData @this) => @this.TypeOauth;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeOauth? value)
        {
            TypeOauth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeOauth(global::Vercel.ConnectConnectorCreateDataTypeOauth? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeApiKey value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeApiKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeApiKey?(ConnectConnectorCreateData @this) => @this.TypeApiKey;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeApiKey? value)
        {
            TypeApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeApiKey(global::Vercel.ConnectConnectorCreateDataTypeApiKey? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeGithub value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeGithub?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeGithub?(ConnectConnectorCreateData @this) => @this.TypeGithub;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeGithub? value)
        {
            TypeGithub = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeGithub(global::Vercel.ConnectConnectorCreateDataTypeGithub? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeLinear value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeLinear?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeLinear?(ConnectConnectorCreateData @this) => @this.TypeLinear;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeLinear? value)
        {
            TypeLinear = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeLinear(global::Vercel.ConnectConnectorCreateDataTypeLinear? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeLinq value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeLinq?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeLinq?(ConnectConnectorCreateData @this) => @this.TypeLinq;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeLinq? value)
        {
            TypeLinq = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeLinq(global::Vercel.ConnectConnectorCreateDataTypeLinq? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSalesforce value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeSalesforce?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeSalesforce?(ConnectConnectorCreateData @this) => @this.TypeSalesforce;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSalesforce? value)
        {
            TypeSalesforce = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeSalesforce(global::Vercel.ConnectConnectorCreateDataTypeSalesforce? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSendblue value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeSendblue?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeSendblue?(ConnectConnectorCreateData @this) => @this.TypeSendblue;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSendblue? value)
        {
            TypeSendblue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeSendblue(global::Vercel.ConnectConnectorCreateDataTypeSendblue? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSlack value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeSlack?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeSlack?(ConnectConnectorCreateData @this) => @this.TypeSlack;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSlack? value)
        {
            TypeSlack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeSlack(global::Vercel.ConnectConnectorCreateDataTypeSlack? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSnowflake value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeSnowflake?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeSnowflake?(ConnectConnectorCreateData @this) => @this.TypeSnowflake;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSnowflake? value)
        {
            TypeSnowflake = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeSnowflake(global::Vercel.ConnectConnectorCreateDataTypeSnowflake? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif?(ConnectConnectorCreateData @this) => @this.TypeSnowflakeWif;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? value)
        {
            TypeSnowflakeWif = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypeSnowflakeWif(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypePhoton value) => new ConnectConnectorCreateData((global::Vercel.ConnectConnectorCreateDataTypePhoton?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorCreateDataTypePhoton?(ConnectConnectorCreateData @this) => @this.TypePhoton;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(global::Vercel.ConnectConnectorCreateDataTypePhoton? value)
        {
            TypePhoton = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorCreateData FromTypePhoton(global::Vercel.ConnectConnectorCreateDataTypePhoton? value) => new ConnectConnectorCreateData(value);

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorCreateData(
            global::Vercel.ConnectConnectorCreateDataTypeOauth? typeOauth,
            global::Vercel.ConnectConnectorCreateDataTypeApiKey? typeApiKey,
            global::Vercel.ConnectConnectorCreateDataTypeGithub? typeGithub,
            global::Vercel.ConnectConnectorCreateDataTypeLinear? typeLinear,
            global::Vercel.ConnectConnectorCreateDataTypeLinq? typeLinq,
            global::Vercel.ConnectConnectorCreateDataTypeSalesforce? typeSalesforce,
            global::Vercel.ConnectConnectorCreateDataTypeSendblue? typeSendblue,
            global::Vercel.ConnectConnectorCreateDataTypeSlack? typeSlack,
            global::Vercel.ConnectConnectorCreateDataTypeSnowflake? typeSnowflake,
            global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? typeSnowflakeWif,
            global::Vercel.ConnectConnectorCreateDataTypePhoton? typePhoton,
            object? typeOther
            )
        {
            TypeOauth = typeOauth;
            TypeApiKey = typeApiKey;
            TypeGithub = typeGithub;
            TypeLinear = typeLinear;
            TypeLinq = typeLinq;
            TypeSalesforce = typeSalesforce;
            TypeSendblue = typeSendblue;
            TypeSlack = typeSlack;
            TypeSnowflake = typeSnowflake;
            TypeSnowflakeWif = typeSnowflakeWif;
            TypePhoton = typePhoton;
            TypeOther = typeOther;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TypeOther as object ??
            TypePhoton as object ??
            TypeSnowflakeWif as object ??
            TypeSnowflake as object ??
            TypeSlack as object ??
            TypeSendblue as object ??
            TypeSalesforce as object ??
            TypeLinq as object ??
            TypeLinear as object ??
            TypeGithub as object ??
            TypeApiKey as object ??
            TypeOauth as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TypeOauth?.ToString() ??
            TypeApiKey?.ToString() ??
            TypeGithub?.ToString() ??
            TypeLinear?.ToString() ??
            TypeLinq?.ToString() ??
            TypeSalesforce?.ToString() ??
            TypeSendblue?.ToString() ??
            TypeSlack?.ToString() ??
            TypeSnowflake?.ToString() ??
            TypeSnowflakeWif?.ToString() ??
            TypePhoton?.ToString() ??
            TypeOther?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTypeOauth || IsTypeApiKey || IsTypeGithub || IsTypeLinear || IsTypeLinq || IsTypeSalesforce || IsTypeSendblue || IsTypeSlack || IsTypeSnowflake || IsTypeSnowflakeWif || IsTypePhoton || IsTypeOther;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeOauth, TResult>? typeOauth = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeApiKey, TResult>? typeApiKey = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeGithub, TResult>? typeGithub = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeLinear, TResult>? typeLinear = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeLinq, TResult>? typeLinq = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeSalesforce, TResult>? typeSalesforce = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeSendblue, TResult>? typeSendblue = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeSlack, TResult>? typeSlack = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeSnowflake, TResult>? typeSnowflake = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif, TResult>? typeSnowflakeWif = null,
            global::System.Func<global::Vercel.ConnectConnectorCreateDataTypePhoton, TResult>? typePhoton = null,
            global::System.Func<object, TResult>? typeOther = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypeOauth && typeOauth != null)
            {
                return typeOauth(TypeOauth!);
            }
            else if (IsTypeApiKey && typeApiKey != null)
            {
                return typeApiKey(TypeApiKey!);
            }
            else if (IsTypeGithub && typeGithub != null)
            {
                return typeGithub(TypeGithub!);
            }
            else if (IsTypeLinear && typeLinear != null)
            {
                return typeLinear(TypeLinear!);
            }
            else if (IsTypeLinq && typeLinq != null)
            {
                return typeLinq(TypeLinq!);
            }
            else if (IsTypeSalesforce && typeSalesforce != null)
            {
                return typeSalesforce(TypeSalesforce!);
            }
            else if (IsTypeSendblue && typeSendblue != null)
            {
                return typeSendblue(TypeSendblue!);
            }
            else if (IsTypeSlack && typeSlack != null)
            {
                return typeSlack(TypeSlack!);
            }
            else if (IsTypeSnowflake && typeSnowflake != null)
            {
                return typeSnowflake(TypeSnowflake!);
            }
            else if (IsTypeSnowflakeWif && typeSnowflakeWif != null)
            {
                return typeSnowflakeWif(TypeSnowflakeWif!);
            }
            else if (IsTypePhoton && typePhoton != null)
            {
                return typePhoton(TypePhoton!);
            }
            else if (IsTypeOther && typeOther != null)
            {
                return typeOther(TypeOther!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeOauth>? typeOauth = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeApiKey>? typeApiKey = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeGithub>? typeGithub = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeLinear>? typeLinear = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeLinq>? typeLinq = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSalesforce>? typeSalesforce = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSendblue>? typeSendblue = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSlack>? typeSlack = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSnowflake>? typeSnowflake = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif>? typeSnowflakeWif = null,

            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypePhoton>? typePhoton = null,

            global::System.Action<object>? typeOther = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypeOauth)
            {
                typeOauth?.Invoke(TypeOauth!);
            }
            else if (IsTypeApiKey)
            {
                typeApiKey?.Invoke(TypeApiKey!);
            }
            else if (IsTypeGithub)
            {
                typeGithub?.Invoke(TypeGithub!);
            }
            else if (IsTypeLinear)
            {
                typeLinear?.Invoke(TypeLinear!);
            }
            else if (IsTypeLinq)
            {
                typeLinq?.Invoke(TypeLinq!);
            }
            else if (IsTypeSalesforce)
            {
                typeSalesforce?.Invoke(TypeSalesforce!);
            }
            else if (IsTypeSendblue)
            {
                typeSendblue?.Invoke(TypeSendblue!);
            }
            else if (IsTypeSlack)
            {
                typeSlack?.Invoke(TypeSlack!);
            }
            else if (IsTypeSnowflake)
            {
                typeSnowflake?.Invoke(TypeSnowflake!);
            }
            else if (IsTypeSnowflakeWif)
            {
                typeSnowflakeWif?.Invoke(TypeSnowflakeWif!);
            }
            else if (IsTypePhoton)
            {
                typePhoton?.Invoke(TypePhoton!);
            }
            else if (IsTypeOther)
            {
                typeOther?.Invoke(TypeOther!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeOauth>? typeOauth = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeApiKey>? typeApiKey = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeGithub>? typeGithub = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeLinear>? typeLinear = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeLinq>? typeLinq = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSalesforce>? typeSalesforce = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSendblue>? typeSendblue = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSlack>? typeSlack = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSnowflake>? typeSnowflake = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif>? typeSnowflakeWif = null,
            global::System.Action<global::Vercel.ConnectConnectorCreateDataTypePhoton>? typePhoton = null,
            global::System.Action<object>? typeOther = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypeOauth)
            {
                typeOauth?.Invoke(TypeOauth!);
            }
            else if (IsTypeApiKey)
            {
                typeApiKey?.Invoke(TypeApiKey!);
            }
            else if (IsTypeGithub)
            {
                typeGithub?.Invoke(TypeGithub!);
            }
            else if (IsTypeLinear)
            {
                typeLinear?.Invoke(TypeLinear!);
            }
            else if (IsTypeLinq)
            {
                typeLinq?.Invoke(TypeLinq!);
            }
            else if (IsTypeSalesforce)
            {
                typeSalesforce?.Invoke(TypeSalesforce!);
            }
            else if (IsTypeSendblue)
            {
                typeSendblue?.Invoke(TypeSendblue!);
            }
            else if (IsTypeSlack)
            {
                typeSlack?.Invoke(TypeSlack!);
            }
            else if (IsTypeSnowflake)
            {
                typeSnowflake?.Invoke(TypeSnowflake!);
            }
            else if (IsTypeSnowflakeWif)
            {
                typeSnowflakeWif?.Invoke(TypeSnowflakeWif!);
            }
            else if (IsTypePhoton)
            {
                typePhoton?.Invoke(TypePhoton!);
            }
            else if (IsTypeOther)
            {
                typeOther?.Invoke(TypeOther!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TypeOauth,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth),
                TypeApiKey,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey),
                TypeGithub,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub),
                TypeLinear,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear),
                TypeLinq,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq),
                TypeSalesforce,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce),
                TypeSendblue,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue),
                TypeSlack,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack),
                TypeSnowflake,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake),
                TypeSnowflakeWif,
                typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif),
                TypePhoton,
                typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton),
                TypeOther,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ConnectConnectorCreateData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeOauth?>.Default.Equals(TypeOauth, other.TypeOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeApiKey?>.Default.Equals(TypeApiKey, other.TypeApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeGithub?>.Default.Equals(TypeGithub, other.TypeGithub) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeLinear?>.Default.Equals(TypeLinear, other.TypeLinear) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeLinq?>.Default.Equals(TypeLinq, other.TypeLinq) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeSalesforce?>.Default.Equals(TypeSalesforce, other.TypeSalesforce) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeSendblue?>.Default.Equals(TypeSendblue, other.TypeSendblue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeSlack?>.Default.Equals(TypeSlack, other.TypeSlack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeSnowflake?>.Default.Equals(TypeSnowflake, other.TypeSnowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif?>.Default.Equals(TypeSnowflakeWif, other.TypeSnowflakeWif) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorCreateDataTypePhoton?>.Default.Equals(TypePhoton, other.TypePhoton) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(TypeOther, other.TypeOther)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConnectConnectorCreateData obj1, ConnectConnectorCreateData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConnectConnectorCreateData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConnectConnectorCreateData obj1, ConnectConnectorCreateData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConnectConnectorCreateData o && Equals(o);
        }
    }
}
