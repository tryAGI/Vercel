#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared22ce768a40a0f8b8 : global::System.IEquatable<AutoSDKShared22ce768a40a0f8b8>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared56f06376e757011b? Shared56f06376e757011b { get; init; }
#else
        public global::Vercel.AutoSDKShared56f06376e757011b? Shared56f06376e757011b { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared56f06376e757011b))]
#endif
        public bool IsShared56f06376e757011b => Shared56f06376e757011b != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared56f06376e757011b(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared56f06376e757011b? value)
        {
            value = Shared56f06376e757011b;
            return IsShared56f06376e757011b;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared56f06376e757011b PickShared56f06376e757011b() => Shared56f06376e757011b is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared56f06376e757011b' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? Sharedd5d6c9ab94c25f66 { get; init; }
#else
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? Sharedd5d6c9ab94c25f66 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedd5d6c9ab94c25f66))]
#endif
        public bool IsSharedd5d6c9ab94c25f66 => Sharedd5d6c9ab94c25f66 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedd5d6c9ab94c25f66(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? value)
        {
            value = Sharedd5d6c9ab94c25f66;
            return IsSharedd5d6c9ab94c25f66;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66 PickSharedd5d6c9ab94c25f66() => Sharedd5d6c9ab94c25f66 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedd5d6c9ab94c25f66' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared22ce768a40a0f8b8(global::Vercel.AutoSDKShared56f06376e757011b value) => new AutoSDKShared22ce768a40a0f8b8((global::Vercel.AutoSDKShared56f06376e757011b?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared56f06376e757011b?(AutoSDKShared22ce768a40a0f8b8 @this) => @this.Shared56f06376e757011b;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared22ce768a40a0f8b8(global::Vercel.AutoSDKShared56f06376e757011b? value)
        {
            Shared56f06376e757011b = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared22ce768a40a0f8b8 FromShared56f06376e757011b(global::Vercel.AutoSDKShared56f06376e757011b? value) => new AutoSDKShared22ce768a40a0f8b8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared22ce768a40a0f8b8(global::Vercel.AutoSDKSharedd5d6c9ab94c25f66 value) => new AutoSDKShared22ce768a40a0f8b8((global::Vercel.AutoSDKSharedd5d6c9ab94c25f66?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedd5d6c9ab94c25f66?(AutoSDKShared22ce768a40a0f8b8 @this) => @this.Sharedd5d6c9ab94c25f66;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared22ce768a40a0f8b8(global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? value)
        {
            Sharedd5d6c9ab94c25f66 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared22ce768a40a0f8b8 FromSharedd5d6c9ab94c25f66(global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? value) => new AutoSDKShared22ce768a40a0f8b8(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared22ce768a40a0f8b8(
            global::Vercel.AutoSDKShared56f06376e757011b? shared56f06376e757011b,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66? sharedd5d6c9ab94c25f66
            )
        {
            Shared56f06376e757011b = shared56f06376e757011b;
            Sharedd5d6c9ab94c25f66 = sharedd5d6c9ab94c25f66;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedd5d6c9ab94c25f66 as object ??
            Shared56f06376e757011b as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared56f06376e757011b?.ToString() ??
            Sharedd5d6c9ab94c25f66?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared56f06376e757011b && !IsSharedd5d6c9ab94c25f66 || !IsShared56f06376e757011b && IsSharedd5d6c9ab94c25f66;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared56f06376e757011b, TResult>? shared56f06376e757011b = null,
            global::System.Func<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66, TResult>? sharedd5d6c9ab94c25f66 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared56f06376e757011b is { } __value0 && shared56f06376e757011b != null)
            {
                return shared56f06376e757011b(__value0);
            }
            else if (Sharedd5d6c9ab94c25f66 is { } __value1 && sharedd5d6c9ab94c25f66 != null)
            {
                return sharedd5d6c9ab94c25f66(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared56f06376e757011b>? shared56f06376e757011b = null,

            global::System.Action<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? sharedd5d6c9ab94c25f66 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared56f06376e757011b is { } __value0)
            {
                shared56f06376e757011b?.Invoke(__value0);
            }
            else if (Sharedd5d6c9ab94c25f66 is { } __value1)
            {
                sharedd5d6c9ab94c25f66?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared56f06376e757011b>? shared56f06376e757011b = null,
            global::System.Action<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? sharedd5d6c9ab94c25f66 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared56f06376e757011b is { } __value0)
            {
                shared56f06376e757011b?.Invoke(__value0);
            }
            else if (Sharedd5d6c9ab94c25f66 is { } __value1)
            {
                sharedd5d6c9ab94c25f66?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared56f06376e757011b,
                typeof(global::Vercel.AutoSDKShared56f06376e757011b),
                Sharedd5d6c9ab94c25f66,
                typeof(global::Vercel.AutoSDKSharedd5d6c9ab94c25f66),
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
        public bool Equals(AutoSDKShared22ce768a40a0f8b8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared56f06376e757011b?>.Default.Equals(Shared56f06376e757011b, other.Shared56f06376e757011b) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66?>.Default.Equals(Sharedd5d6c9ab94c25f66, other.Sharedd5d6c9ab94c25f66)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared22ce768a40a0f8b8 obj1, AutoSDKShared22ce768a40a0f8b8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared22ce768a40a0f8b8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared22ce768a40a0f8b8 obj1, AutoSDKShared22ce768a40a0f8b8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared22ce768a40a0f8b8 o && Equals(o);
        }
    }
}
