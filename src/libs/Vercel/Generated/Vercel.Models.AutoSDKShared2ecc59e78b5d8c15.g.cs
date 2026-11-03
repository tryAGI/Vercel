#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared2ecc59e78b5d8c15 : global::System.IEquatable<AutoSDKShared2ecc59e78b5d8c15>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>? Sharedf4f3352d54ef7c38 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>? Sharedf4f3352d54ef7c38 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedf4f3352d54ef7c38))]
#endif
        public bool IsSharedf4f3352d54ef7c38 => Sharedf4f3352d54ef7c38 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedf4f3352d54ef7c38(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>? value)
        {
            value = Sharedf4f3352d54ef7c38;
            return IsSharedf4f3352d54ef7c38;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b> PickSharedf4f3352d54ef7c38() => Sharedf4f3352d54ef7c38 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedf4f3352d54ef7c38' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? Sharedc981f03b58fcb734 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? Sharedc981f03b58fcb734 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedc981f03b58fcb734))]
#endif
        public bool IsSharedc981f03b58fcb734 => Sharedc981f03b58fcb734 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedc981f03b58fcb734(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? value)
        {
            value = Sharedc981f03b58fcb734;
            return IsSharedc981f03b58fcb734;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66> PickSharedc981f03b58fcb734() => Sharedc981f03b58fcb734 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedc981f03b58fcb734' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2ecc59e78b5d8c15(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>? sharedf4f3352d54ef7c38,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>? sharedc981f03b58fcb734
            )
        {
            Sharedf4f3352d54ef7c38 = sharedf4f3352d54ef7c38;
            Sharedc981f03b58fcb734 = sharedc981f03b58fcb734;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedc981f03b58fcb734 as object ??
            Sharedf4f3352d54ef7c38 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedf4f3352d54ef7c38?.ToString() ??
            Sharedc981f03b58fcb734?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedf4f3352d54ef7c38 && !IsSharedc981f03b58fcb734 || !IsSharedf4f3352d54ef7c38 && IsSharedc981f03b58fcb734;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>, TResult>? sharedf4f3352d54ef7c38 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>, TResult>? sharedc981f03b58fcb734 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedf4f3352d54ef7c38 is { } __value0 && sharedf4f3352d54ef7c38 != null)
            {
                return sharedf4f3352d54ef7c38(__value0);
            }
            else if (Sharedc981f03b58fcb734 is { } __value1 && sharedc981f03b58fcb734 != null)
            {
                return sharedc981f03b58fcb734(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>>? sharedf4f3352d54ef7c38 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>>? sharedc981f03b58fcb734 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedf4f3352d54ef7c38 is { } __value0)
            {
                sharedf4f3352d54ef7c38?.Invoke(__value0);
            }
            else if (Sharedc981f03b58fcb734 is { } __value1)
            {
                sharedc981f03b58fcb734?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>>? sharedf4f3352d54ef7c38 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>>? sharedc981f03b58fcb734 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedf4f3352d54ef7c38 is { } __value0)
            {
                sharedf4f3352d54ef7c38?.Invoke(__value0);
            }
            else if (Sharedc981f03b58fcb734 is { } __value1)
            {
                sharedc981f03b58fcb734?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedf4f3352d54ef7c38,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>),
                Sharedc981f03b58fcb734,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>),
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
        public bool Equals(AutoSDKShared2ecc59e78b5d8c15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared56f06376e757011b>?>.Default.Equals(Sharedf4f3352d54ef7c38, other.Sharedf4f3352d54ef7c38) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66>?>.Default.Equals(Sharedc981f03b58fcb734, other.Sharedc981f03b58fcb734)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared2ecc59e78b5d8c15 obj1, AutoSDKShared2ecc59e78b5d8c15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared2ecc59e78b5d8c15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared2ecc59e78b5d8c15 obj1, AutoSDKShared2ecc59e78b5d8c15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared2ecc59e78b5d8c15 o && Equals(o);
        }
    }
}
