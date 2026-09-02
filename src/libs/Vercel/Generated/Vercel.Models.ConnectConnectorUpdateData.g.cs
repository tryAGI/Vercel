#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Provider configuration fields for the connector type.
    /// </summary>
    public readonly partial struct ConnectConnectorUpdateData : global::System.IEquatable<ConnectConnectorUpdateData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeOauth? TypeOauth { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeOauth? TypeOauth { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeOauth? value)
        {
            value = TypeOauth;
            return IsTypeOauth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeOauth PickTypeOauth() => IsTypeOauth
            ? TypeOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeOauth' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeApiKey? TypeApiKey { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeApiKey? TypeApiKey { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeApiKey? value)
        {
            value = TypeApiKey;
            return IsTypeApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeApiKey PickTypeApiKey() => IsTypeApiKey
            ? TypeApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeGithub? TypeGithub { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeGithub? TypeGithub { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeGithub? value)
        {
            value = TypeGithub;
            return IsTypeGithub;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeGithub PickTypeGithub() => IsTypeGithub
            ? TypeGithub!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeGithub' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeLinear? TypeLinear { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeLinear? TypeLinear { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeLinear? value)
        {
            value = TypeLinear;
            return IsTypeLinear;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeLinear PickTypeLinear() => IsTypeLinear
            ? TypeLinear!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeLinear' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? TypeSalesforce { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? TypeSalesforce { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? value)
        {
            value = TypeSalesforce;
            return IsTypeSalesforce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeSalesforce PickTypeSalesforce() => IsTypeSalesforce
            ? TypeSalesforce!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSalesforce' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeSlack? TypeSlack { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeSlack? TypeSlack { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeSlack? value)
        {
            value = TypeSlack;
            return IsTypeSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeSlack PickTypeSlack() => IsTypeSlack
            ? TypeSlack!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSlack' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? TypeSnowflake { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? TypeSnowflake { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? value)
        {
            value = TypeSnowflake;
            return IsTypeSnowflake;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflake PickTypeSnowflake() => IsTypeSnowflake
            ? TypeSnowflake!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSnowflake' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? TypeSnowflakeWif { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? TypeSnowflakeWif { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? value)
        {
            value = TypeSnowflakeWif;
            return IsTypeSnowflakeWif;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif PickTypeSnowflakeWif() => IsTypeSnowflakeWif
            ? TypeSnowflakeWif!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSnowflakeWif' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeLinq? TypeLinq { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeLinq? TypeLinq { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeLinq? value)
        {
            value = TypeLinq;
            return IsTypeLinq;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeLinq PickTypeLinq() => IsTypeLinq
            ? TypeLinq!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeLinq' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypeSendblue? TypeSendblue { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypeSendblue? TypeSendblue { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypeSendblue? value)
        {
            value = TypeSendblue;
            return IsTypeSendblue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypeSendblue PickTypeSendblue() => IsTypeSendblue
            ? TypeSendblue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeSendblue' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectConnectorUpdateDataTypePhoton? TypePhoton { get; init; }
#else
        public global::Vercel.ConnectConnectorUpdateDataTypePhoton? TypePhoton { get; }
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
            out global::Vercel.ConnectConnectorUpdateDataTypePhoton? value)
        {
            value = TypePhoton;
            return IsTypePhoton;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectConnectorUpdateDataTypePhoton PickTypePhoton() => IsTypePhoton
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
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeOauth value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeOauth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeOauth?(ConnectConnectorUpdateData @this) => @this.TypeOauth;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeOauth? value)
        {
            TypeOauth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeOauth(global::Vercel.ConnectConnectorUpdateDataTypeOauth? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeApiKey value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeApiKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeApiKey?(ConnectConnectorUpdateData @this) => @this.TypeApiKey;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeApiKey? value)
        {
            TypeApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeApiKey(global::Vercel.ConnectConnectorUpdateDataTypeApiKey? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeGithub value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeGithub?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeGithub?(ConnectConnectorUpdateData @this) => @this.TypeGithub;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeGithub? value)
        {
            TypeGithub = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeGithub(global::Vercel.ConnectConnectorUpdateDataTypeGithub? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeLinear value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeLinear?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeLinear?(ConnectConnectorUpdateData @this) => @this.TypeLinear;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeLinear? value)
        {
            TypeLinear = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeLinear(global::Vercel.ConnectConnectorUpdateDataTypeLinear? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeSalesforce?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeSalesforce?(ConnectConnectorUpdateData @this) => @this.TypeSalesforce;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? value)
        {
            TypeSalesforce = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeSalesforce(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSlack value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeSlack?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeSlack?(ConnectConnectorUpdateData @this) => @this.TypeSlack;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSlack? value)
        {
            TypeSlack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeSlack(global::Vercel.ConnectConnectorUpdateDataTypeSlack? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeSnowflake?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeSnowflake?(ConnectConnectorUpdateData @this) => @this.TypeSnowflake;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? value)
        {
            TypeSnowflake = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeSnowflake(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif?(ConnectConnectorUpdateData @this) => @this.TypeSnowflakeWif;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? value)
        {
            TypeSnowflakeWif = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeSnowflakeWif(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeLinq value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeLinq?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeLinq?(ConnectConnectorUpdateData @this) => @this.TypeLinq;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeLinq? value)
        {
            TypeLinq = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeLinq(global::Vercel.ConnectConnectorUpdateDataTypeLinq? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSendblue value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypeSendblue?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypeSendblue?(ConnectConnectorUpdateData @this) => @this.TypeSendblue;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypeSendblue? value)
        {
            TypeSendblue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypeSendblue(global::Vercel.ConnectConnectorUpdateDataTypeSendblue? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypePhoton value) => new ConnectConnectorUpdateData((global::Vercel.ConnectConnectorUpdateDataTypePhoton?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectConnectorUpdateDataTypePhoton?(ConnectConnectorUpdateData @this) => @this.TypePhoton;

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(global::Vercel.ConnectConnectorUpdateDataTypePhoton? value)
        {
            TypePhoton = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectConnectorUpdateData FromTypePhoton(global::Vercel.ConnectConnectorUpdateDataTypePhoton? value) => new ConnectConnectorUpdateData(value);

        /// <summary>
        ///
        /// </summary>
        public ConnectConnectorUpdateData(
            global::Vercel.ConnectConnectorUpdateDataTypeOauth? typeOauth,
            global::Vercel.ConnectConnectorUpdateDataTypeApiKey? typeApiKey,
            global::Vercel.ConnectConnectorUpdateDataTypeGithub? typeGithub,
            global::Vercel.ConnectConnectorUpdateDataTypeLinear? typeLinear,
            global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? typeSalesforce,
            global::Vercel.ConnectConnectorUpdateDataTypeSlack? typeSlack,
            global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? typeSnowflake,
            global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? typeSnowflakeWif,
            global::Vercel.ConnectConnectorUpdateDataTypeLinq? typeLinq,
            global::Vercel.ConnectConnectorUpdateDataTypeSendblue? typeSendblue,
            global::Vercel.ConnectConnectorUpdateDataTypePhoton? typePhoton,
            object? typeOther
            )
        {
            TypeOauth = typeOauth;
            TypeApiKey = typeApiKey;
            TypeGithub = typeGithub;
            TypeLinear = typeLinear;
            TypeSalesforce = typeSalesforce;
            TypeSlack = typeSlack;
            TypeSnowflake = typeSnowflake;
            TypeSnowflakeWif = typeSnowflakeWif;
            TypeLinq = typeLinq;
            TypeSendblue = typeSendblue;
            TypePhoton = typePhoton;
            TypeOther = typeOther;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TypeOther as object ??
            TypePhoton as object ??
            TypeSendblue as object ??
            TypeLinq as object ??
            TypeSnowflakeWif as object ??
            TypeSnowflake as object ??
            TypeSlack as object ??
            TypeSalesforce as object ??
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
            TypeSalesforce?.ToString() ??
            TypeSlack?.ToString() ??
            TypeSnowflake?.ToString() ??
            TypeSnowflakeWif?.ToString() ??
            TypeLinq?.ToString() ??
            TypeSendblue?.ToString() ??
            TypePhoton?.ToString() ??
            TypeOther?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTypeOauth || IsTypeApiKey || IsTypeGithub || IsTypeLinear || IsTypeSalesforce || IsTypeSlack || IsTypeSnowflake || IsTypeSnowflakeWif || IsTypeLinq || IsTypeSendblue || IsTypePhoton || IsTypeOther;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeOauth, TResult>? typeOauth = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeApiKey, TResult>? typeApiKey = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeGithub, TResult>? typeGithub = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeLinear, TResult>? typeLinear = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce, TResult>? typeSalesforce = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeSlack, TResult>? typeSlack = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake, TResult>? typeSnowflake = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif, TResult>? typeSnowflakeWif = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeLinq, TResult>? typeLinq = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypeSendblue, TResult>? typeSendblue = null,
            global::System.Func<global::Vercel.ConnectConnectorUpdateDataTypePhoton, TResult>? typePhoton = null,
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
            else if (IsTypeSalesforce && typeSalesforce != null)
            {
                return typeSalesforce(TypeSalesforce!);
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
            else if (IsTypeLinq && typeLinq != null)
            {
                return typeLinq(TypeLinq!);
            }
            else if (IsTypeSendblue && typeSendblue != null)
            {
                return typeSendblue(TypeSendblue!);
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
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeOauth>? typeOauth = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeApiKey>? typeApiKey = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeGithub>? typeGithub = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeLinear>? typeLinear = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce>? typeSalesforce = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSlack>? typeSlack = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake>? typeSnowflake = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif>? typeSnowflakeWif = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeLinq>? typeLinq = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSendblue>? typeSendblue = null,

            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypePhoton>? typePhoton = null,

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
            else if (IsTypeSalesforce)
            {
                typeSalesforce?.Invoke(TypeSalesforce!);
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
            else if (IsTypeLinq)
            {
                typeLinq?.Invoke(TypeLinq!);
            }
            else if (IsTypeSendblue)
            {
                typeSendblue?.Invoke(TypeSendblue!);
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
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeOauth>? typeOauth = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeApiKey>? typeApiKey = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeGithub>? typeGithub = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeLinear>? typeLinear = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce>? typeSalesforce = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSlack>? typeSlack = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake>? typeSnowflake = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif>? typeSnowflakeWif = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeLinq>? typeLinq = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypeSendblue>? typeSendblue = null,
            global::System.Action<global::Vercel.ConnectConnectorUpdateDataTypePhoton>? typePhoton = null,
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
            else if (IsTypeSalesforce)
            {
                typeSalesforce?.Invoke(TypeSalesforce!);
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
            else if (IsTypeLinq)
            {
                typeLinq?.Invoke(TypeLinq!);
            }
            else if (IsTypeSendblue)
            {
                typeSendblue?.Invoke(TypeSendblue!);
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
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth),
                TypeApiKey,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey),
                TypeGithub,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub),
                TypeLinear,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear),
                TypeSalesforce,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce),
                TypeSlack,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack),
                TypeSnowflake,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake),
                TypeSnowflakeWif,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif),
                TypeLinq,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq),
                TypeSendblue,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue),
                TypePhoton,
                typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton),
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
        public bool Equals(ConnectConnectorUpdateData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeOauth?>.Default.Equals(TypeOauth, other.TypeOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeApiKey?>.Default.Equals(TypeApiKey, other.TypeApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeGithub?>.Default.Equals(TypeGithub, other.TypeGithub) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeLinear?>.Default.Equals(TypeLinear, other.TypeLinear) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce?>.Default.Equals(TypeSalesforce, other.TypeSalesforce) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeSlack?>.Default.Equals(TypeSlack, other.TypeSlack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake?>.Default.Equals(TypeSnowflake, other.TypeSnowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif?>.Default.Equals(TypeSnowflakeWif, other.TypeSnowflakeWif) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeLinq?>.Default.Equals(TypeLinq, other.TypeLinq) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypeSendblue?>.Default.Equals(TypeSendblue, other.TypeSendblue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectConnectorUpdateDataTypePhoton?>.Default.Equals(TypePhoton, other.TypePhoton) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(TypeOther, other.TypeOther)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConnectConnectorUpdateData obj1, ConnectConnectorUpdateData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConnectConnectorUpdateData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConnectConnectorUpdateData obj1, ConnectConnectorUpdateData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConnectConnectorUpdateData o && Equals(o);
        }
    }
}
