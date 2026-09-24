#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared2c7fdfa9ff104258 : global::System.IEquatable<AutoSDKShared2c7fdfa9ff104258>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>? Shared5e357f8eaffbe48b { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>? Shared5e357f8eaffbe48b { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared5e357f8eaffbe48b))]
#endif
        public bool IsShared5e357f8eaffbe48b => Shared5e357f8eaffbe48b != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared5e357f8eaffbe48b(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>? value)
        {
            value = Shared5e357f8eaffbe48b;
            return IsShared5e357f8eaffbe48b;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab> PickShared5e357f8eaffbe48b() => IsShared5e357f8eaffbe48b
            ? Shared5e357f8eaffbe48b!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared5e357f8eaffbe48b' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>? Shared96c321691ef0b597 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>? Shared96c321691ef0b597 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared96c321691ef0b597))]
#endif
        public bool IsShared96c321691ef0b597 => Shared96c321691ef0b597 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared96c321691ef0b597(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>? value)
        {
            value = Shared96c321691ef0b597;
            return IsShared96c321691ef0b597;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468> PickShared96c321691ef0b597() => IsShared96c321691ef0b597
            ? Shared96c321691ef0b597!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared96c321691ef0b597' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2c7fdfa9ff104258(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>? shared5e357f8eaffbe48b,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>? shared96c321691ef0b597
            )
        {
            Shared5e357f8eaffbe48b = shared5e357f8eaffbe48b;
            Shared96c321691ef0b597 = shared96c321691ef0b597;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared96c321691ef0b597 as object ??
            Shared5e357f8eaffbe48b as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared5e357f8eaffbe48b?.ToString() ??
            Shared96c321691ef0b597?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared5e357f8eaffbe48b && !IsShared96c321691ef0b597 || !IsShared5e357f8eaffbe48b && IsShared96c321691ef0b597;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>, TResult>? shared5e357f8eaffbe48b = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>, TResult>? shared96c321691ef0b597 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5e357f8eaffbe48b && shared5e357f8eaffbe48b != null)
            {
                return shared5e357f8eaffbe48b(Shared5e357f8eaffbe48b!);
            }
            else if (IsShared96c321691ef0b597 && shared96c321691ef0b597 != null)
            {
                return shared96c321691ef0b597(Shared96c321691ef0b597!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>>? shared5e357f8eaffbe48b = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>>? shared96c321691ef0b597 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5e357f8eaffbe48b)
            {
                shared5e357f8eaffbe48b?.Invoke(Shared5e357f8eaffbe48b!);
            }
            else if (IsShared96c321691ef0b597)
            {
                shared96c321691ef0b597?.Invoke(Shared96c321691ef0b597!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>>? shared5e357f8eaffbe48b = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>>? shared96c321691ef0b597 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5e357f8eaffbe48b)
            {
                shared5e357f8eaffbe48b?.Invoke(Shared5e357f8eaffbe48b!);
            }
            else if (IsShared96c321691ef0b597)
            {
                shared96c321691ef0b597?.Invoke(Shared96c321691ef0b597!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared5e357f8eaffbe48b,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>),
                Shared96c321691ef0b597,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>),
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
        public bool Equals(AutoSDKShared2c7fdfa9ff104258 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc22c8f7d5e0fe6ab>?>.Default.Equals(Shared5e357f8eaffbe48b, other.Shared5e357f8eaffbe48b) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc8eb1e7f2cbde468>?>.Default.Equals(Shared96c321691ef0b597, other.Shared96c321691ef0b597)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared2c7fdfa9ff104258 obj1, AutoSDKShared2c7fdfa9ff104258 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared2c7fdfa9ff104258>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared2c7fdfa9ff104258 obj1, AutoSDKShared2c7fdfa9ff104258 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared2c7fdfa9ff104258 o && Equals(o);
        }
    }
}
