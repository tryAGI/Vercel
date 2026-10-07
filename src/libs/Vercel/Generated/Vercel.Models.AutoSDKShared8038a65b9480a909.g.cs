#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared8038a65b9480a909 : global::System.IEquatable<AutoSDKShared8038a65b9480a909>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? Sharedc2e5e8d31dd98e94 { get; init; }
#else
        public global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? Sharedc2e5e8d31dd98e94 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedc2e5e8d31dd98e94))]
#endif
        public bool IsSharedc2e5e8d31dd98e94 => Sharedc2e5e8d31dd98e94 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedc2e5e8d31dd98e94(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? value)
        {
            value = Sharedc2e5e8d31dd98e94;
            return IsSharedc2e5e8d31dd98e94;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedc2e5e8d31dd98e94 PickSharedc2e5e8d31dd98e94() => Sharedc2e5e8d31dd98e94 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedc2e5e8d31dd98e94' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared50df233f8638e1fa? Shared50df233f8638e1fa { get; init; }
#else
        public global::Vercel.AutoSDKShared50df233f8638e1fa? Shared50df233f8638e1fa { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared50df233f8638e1fa))]
#endif
        public bool IsShared50df233f8638e1fa => Shared50df233f8638e1fa != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared50df233f8638e1fa(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared50df233f8638e1fa? value)
        {
            value = Shared50df233f8638e1fa;
            return IsShared50df233f8638e1fa;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared50df233f8638e1fa PickShared50df233f8638e1fa() => Shared50df233f8638e1fa is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared50df233f8638e1fa' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared8038a65b9480a909(global::Vercel.AutoSDKSharedc2e5e8d31dd98e94 value) => new AutoSDKShared8038a65b9480a909((global::Vercel.AutoSDKSharedc2e5e8d31dd98e94?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedc2e5e8d31dd98e94?(AutoSDKShared8038a65b9480a909 @this) => @this.Sharedc2e5e8d31dd98e94;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared8038a65b9480a909(global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? value)
        {
            Sharedc2e5e8d31dd98e94 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared8038a65b9480a909 FromSharedc2e5e8d31dd98e94(global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? value) => new AutoSDKShared8038a65b9480a909(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared8038a65b9480a909(global::Vercel.AutoSDKShared50df233f8638e1fa value) => new AutoSDKShared8038a65b9480a909((global::Vercel.AutoSDKShared50df233f8638e1fa?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared50df233f8638e1fa?(AutoSDKShared8038a65b9480a909 @this) => @this.Shared50df233f8638e1fa;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared8038a65b9480a909(global::Vercel.AutoSDKShared50df233f8638e1fa? value)
        {
            Shared50df233f8638e1fa = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared8038a65b9480a909 FromShared50df233f8638e1fa(global::Vercel.AutoSDKShared50df233f8638e1fa? value) => new AutoSDKShared8038a65b9480a909(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared8038a65b9480a909(
            global::Vercel.AutoSDKSharedc2e5e8d31dd98e94? sharedc2e5e8d31dd98e94,
            global::Vercel.AutoSDKShared50df233f8638e1fa? shared50df233f8638e1fa
            )
        {
            Sharedc2e5e8d31dd98e94 = sharedc2e5e8d31dd98e94;
            Shared50df233f8638e1fa = shared50df233f8638e1fa;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared50df233f8638e1fa as object ??
            Sharedc2e5e8d31dd98e94 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedc2e5e8d31dd98e94?.ToString() ??
            Shared50df233f8638e1fa?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedc2e5e8d31dd98e94 && !IsShared50df233f8638e1fa || !IsSharedc2e5e8d31dd98e94 && IsShared50df233f8638e1fa;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedc2e5e8d31dd98e94, TResult>? sharedc2e5e8d31dd98e94 = null,
            global::System.Func<global::Vercel.AutoSDKShared50df233f8638e1fa, TResult>? shared50df233f8638e1fa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc2e5e8d31dd98e94 is { } __value0 && sharedc2e5e8d31dd98e94 != null)
            {
                return sharedc2e5e8d31dd98e94(__value0);
            }
            else if (Shared50df233f8638e1fa is { } __value1 && shared50df233f8638e1fa != null)
            {
                return shared50df233f8638e1fa(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedc2e5e8d31dd98e94>? sharedc2e5e8d31dd98e94 = null,

            global::System.Action<global::Vercel.AutoSDKShared50df233f8638e1fa>? shared50df233f8638e1fa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc2e5e8d31dd98e94 is { } __value0)
            {
                sharedc2e5e8d31dd98e94?.Invoke(__value0);
            }
            else if (Shared50df233f8638e1fa is { } __value1)
            {
                shared50df233f8638e1fa?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedc2e5e8d31dd98e94>? sharedc2e5e8d31dd98e94 = null,
            global::System.Action<global::Vercel.AutoSDKShared50df233f8638e1fa>? shared50df233f8638e1fa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc2e5e8d31dd98e94 is { } __value0)
            {
                sharedc2e5e8d31dd98e94?.Invoke(__value0);
            }
            else if (Shared50df233f8638e1fa is { } __value1)
            {
                shared50df233f8638e1fa?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedc2e5e8d31dd98e94,
                typeof(global::Vercel.AutoSDKSharedc2e5e8d31dd98e94),
                Shared50df233f8638e1fa,
                typeof(global::Vercel.AutoSDKShared50df233f8638e1fa),
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
        public bool Equals(AutoSDKShared8038a65b9480a909 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedc2e5e8d31dd98e94?>.Default.Equals(Sharedc2e5e8d31dd98e94, other.Sharedc2e5e8d31dd98e94) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared50df233f8638e1fa?>.Default.Equals(Shared50df233f8638e1fa, other.Shared50df233f8638e1fa)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared8038a65b9480a909 obj1, AutoSDKShared8038a65b9480a909 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared8038a65b9480a909>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared8038a65b9480a909 obj1, AutoSDKShared8038a65b9480a909 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared8038a65b9480a909 o && Equals(o);
        }
    }
}
