#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared50f3542265814add : global::System.IEquatable<AutoSDKShared50f3542265814add>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>? Sharedc991458598e3986a { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>? Sharedc991458598e3986a { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedc991458598e3986a))]
#endif
        public bool IsSharedc991458598e3986a => Sharedc991458598e3986a != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedc991458598e3986a(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>? value)
        {
            value = Sharedc991458598e3986a;
            return IsSharedc991458598e3986a;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f> PickSharedc991458598e3986a() => Sharedc991458598e3986a is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedc991458598e3986a' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? Shared8f57dc3c0d3f87ad { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? Shared8f57dc3c0d3f87ad { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared8f57dc3c0d3f87ad))]
#endif
        public bool IsShared8f57dc3c0d3f87ad => Shared8f57dc3c0d3f87ad != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared8f57dc3c0d3f87ad(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? value)
        {
            value = Shared8f57dc3c0d3f87ad;
            return IsShared8f57dc3c0d3f87ad;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636> PickShared8f57dc3c0d3f87ad() => Shared8f57dc3c0d3f87ad is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared8f57dc3c0d3f87ad' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared50f3542265814add(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>? sharedc991458598e3986a,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? shared8f57dc3c0d3f87ad
            )
        {
            Sharedc991458598e3986a = sharedc991458598e3986a;
            Shared8f57dc3c0d3f87ad = shared8f57dc3c0d3f87ad;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared8f57dc3c0d3f87ad as object ??
            Sharedc991458598e3986a as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedc991458598e3986a?.ToString() ??
            Shared8f57dc3c0d3f87ad?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedc991458598e3986a && !IsShared8f57dc3c0d3f87ad || !IsSharedc991458598e3986a && IsShared8f57dc3c0d3f87ad;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>, TResult>? sharedc991458598e3986a = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>, TResult>? shared8f57dc3c0d3f87ad = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc991458598e3986a is { } __value0 && sharedc991458598e3986a != null)
            {
                return sharedc991458598e3986a(__value0);
            }
            else if (Shared8f57dc3c0d3f87ad is { } __value1 && shared8f57dc3c0d3f87ad != null)
            {
                return shared8f57dc3c0d3f87ad(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>>? sharedc991458598e3986a = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>>? shared8f57dc3c0d3f87ad = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc991458598e3986a is { } __value0)
            {
                sharedc991458598e3986a?.Invoke(__value0);
            }
            else if (Shared8f57dc3c0d3f87ad is { } __value1)
            {
                shared8f57dc3c0d3f87ad?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>>? sharedc991458598e3986a = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>>? shared8f57dc3c0d3f87ad = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedc991458598e3986a is { } __value0)
            {
                sharedc991458598e3986a?.Invoke(__value0);
            }
            else if (Shared8f57dc3c0d3f87ad is { } __value1)
            {
                shared8f57dc3c0d3f87ad?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedc991458598e3986a,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>),
                Shared8f57dc3c0d3f87ad,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>),
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
        public bool Equals(AutoSDKShared50f3542265814add other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared92580a598ccc210f>?>.Default.Equals(Sharedc991458598e3986a, other.Sharedc991458598e3986a) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>?>.Default.Equals(Shared8f57dc3c0d3f87ad, other.Shared8f57dc3c0d3f87ad)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared50f3542265814add obj1, AutoSDKShared50f3542265814add obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared50f3542265814add>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared50f3542265814add obj1, AutoSDKShared50f3542265814add obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared50f3542265814add o && Equals(o);
        }
    }
}
