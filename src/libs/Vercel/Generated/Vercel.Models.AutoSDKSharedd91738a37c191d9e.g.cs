#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedd91738a37c191d9e : global::System.IEquatable<AutoSDKSharedd91738a37c191d9e>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>? Sharedbb8e91b17b7d885c { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>? Sharedbb8e91b17b7d885c { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedbb8e91b17b7d885c))]
#endif
        public bool IsSharedbb8e91b17b7d885c => Sharedbb8e91b17b7d885c != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedbb8e91b17b7d885c(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>? value)
        {
            value = Sharedbb8e91b17b7d885c;
            return IsSharedbb8e91b17b7d885c;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8> PickSharedbb8e91b17b7d885c() => Sharedbb8e91b17b7d885c is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedbb8e91b17b7d885c' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>? Sharedc7ea0f9c95e22568 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>? Sharedc7ea0f9c95e22568 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedc7ea0f9c95e22568))]
#endif
        public bool IsSharedc7ea0f9c95e22568 => Sharedc7ea0f9c95e22568 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedc7ea0f9c95e22568(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>? value)
        {
            value = Sharedc7ea0f9c95e22568;
            return IsSharedc7ea0f9c95e22568;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc> PickSharedc7ea0f9c95e22568() => Sharedc7ea0f9c95e22568 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedc7ea0f9c95e22568' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedd91738a37c191d9e(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>? sharedbb8e91b17b7d885c,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>? sharedc7ea0f9c95e22568
            )
        {
            Sharedbb8e91b17b7d885c = sharedbb8e91b17b7d885c;
            Sharedc7ea0f9c95e22568 = sharedc7ea0f9c95e22568;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedc7ea0f9c95e22568 as object ??
            Sharedbb8e91b17b7d885c as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedbb8e91b17b7d885c?.ToString() ??
            Sharedc7ea0f9c95e22568?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedbb8e91b17b7d885c && !IsSharedc7ea0f9c95e22568 || !IsSharedbb8e91b17b7d885c && IsSharedc7ea0f9c95e22568;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>, TResult>? sharedbb8e91b17b7d885c = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>, TResult>? sharedc7ea0f9c95e22568 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedbb8e91b17b7d885c is { } __value0 && sharedbb8e91b17b7d885c != null)
            {
                return sharedbb8e91b17b7d885c(__value0);
            }
            else if (Sharedc7ea0f9c95e22568 is { } __value1 && sharedc7ea0f9c95e22568 != null)
            {
                return sharedc7ea0f9c95e22568(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>>? sharedbb8e91b17b7d885c = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>>? sharedc7ea0f9c95e22568 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedbb8e91b17b7d885c is { } __value0)
            {
                sharedbb8e91b17b7d885c?.Invoke(__value0);
            }
            else if (Sharedc7ea0f9c95e22568 is { } __value1)
            {
                sharedc7ea0f9c95e22568?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>>? sharedbb8e91b17b7d885c = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>>? sharedc7ea0f9c95e22568 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedbb8e91b17b7d885c is { } __value0)
            {
                sharedbb8e91b17b7d885c?.Invoke(__value0);
            }
            else if (Sharedc7ea0f9c95e22568 is { } __value1)
            {
                sharedc7ea0f9c95e22568?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedbb8e91b17b7d885c,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>),
                Sharedc7ea0f9c95e22568,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>),
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
        public bool Equals(AutoSDKSharedd91738a37c191d9e other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>?>.Default.Equals(Sharedbb8e91b17b7d885c, other.Sharedbb8e91b17b7d885c) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>?>.Default.Equals(Sharedc7ea0f9c95e22568, other.Sharedc7ea0f9c95e22568)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedd91738a37c191d9e obj1, AutoSDKSharedd91738a37c191d9e obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedd91738a37c191d9e>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedd91738a37c191d9e obj1, AutoSDKSharedd91738a37c191d9e obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedd91738a37c191d9e o && Equals(o);
        }
    }
}
