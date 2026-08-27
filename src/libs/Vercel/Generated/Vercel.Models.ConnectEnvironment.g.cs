#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// A built-in Vercel environment or a stable custom environment ID.
    /// </summary>
    public readonly partial struct ConnectEnvironment : global::System.IEquatable<ConnectEnvironment>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectEnvironmentEnum? Enum { get; init; }
#else
        public global::Vercel.ConnectEnvironmentEnum? Enum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectEnvironmentEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectEnvironmentEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ConnectEnvironmentVariant2 { get; init; }
#else
        public string? ConnectEnvironmentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConnectEnvironmentVariant2))]
#endif
        public bool IsConnectEnvironmentVariant2 => ConnectEnvironmentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnectEnvironmentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ConnectEnvironmentVariant2;
            return IsConnectEnvironmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickConnectEnvironmentVariant2() => IsConnectEnvironmentVariant2
            ? ConnectEnvironmentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectEnvironmentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectEnvironment(global::Vercel.ConnectEnvironmentEnum value) => new ConnectEnvironment((global::Vercel.ConnectEnvironmentEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectEnvironmentEnum?(ConnectEnvironment @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public ConnectEnvironment(global::Vercel.ConnectEnvironmentEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectEnvironment FromEnum(global::Vercel.ConnectEnvironmentEnum? value) => new ConnectEnvironment(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectEnvironment(string value) => new ConnectEnvironment((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ConnectEnvironment @this) => @this.ConnectEnvironmentVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConnectEnvironment(string? value)
        {
            ConnectEnvironmentVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectEnvironment FromConnectEnvironmentVariant2(string? value) => new ConnectEnvironment(value);

        /// <summary>
        ///
        /// </summary>
        public ConnectEnvironment(
            global::Vercel.ConnectEnvironmentEnum? @enum,
            string? connectEnvironmentVariant2
            )
        {
            Enum = @enum;
            ConnectEnvironmentVariant2 = connectEnvironmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConnectEnvironmentVariant2 as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            ConnectEnvironmentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsConnectEnvironmentVariant2 || !IsEnum && IsConnectEnvironmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.ConnectEnvironmentEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? connectEnvironmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsConnectEnvironmentVariant2 && connectEnvironmentVariant2 != null)
            {
                return connectEnvironmentVariant2(ConnectEnvironmentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.ConnectEnvironmentEnum?>? @enum = null,

            global::System.Action<string>? connectEnvironmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsConnectEnvironmentVariant2)
            {
                connectEnvironmentVariant2?.Invoke(ConnectEnvironmentVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.ConnectEnvironmentEnum?>? @enum = null,
            global::System.Action<string>? connectEnvironmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsConnectEnvironmentVariant2)
            {
                connectEnvironmentVariant2?.Invoke(ConnectEnvironmentVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::Vercel.ConnectEnvironmentEnum),
                ConnectEnvironmentVariant2,
                typeof(string),
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
        public bool Equals(ConnectEnvironment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectEnvironmentEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ConnectEnvironmentVariant2, other.ConnectEnvironmentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConnectEnvironment obj1, ConnectEnvironment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConnectEnvironment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConnectEnvironment obj1, ConnectEnvironment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConnectEnvironment o && Equals(o);
        }
    }
}
