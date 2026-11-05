#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared2a792fc701a6e66d : global::System.IEquatable<AutoSDKShared2a792fc701a6e66d>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedb38a5d43be350768? Sharedb38a5d43be350768 { get; init; }
#else
        public global::Vercel.AutoSDKSharedb38a5d43be350768? Sharedb38a5d43be350768 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedb38a5d43be350768))]
#endif
        public bool IsSharedb38a5d43be350768 => Sharedb38a5d43be350768 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedb38a5d43be350768(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedb38a5d43be350768? value)
        {
            value = Sharedb38a5d43be350768;
            return IsSharedb38a5d43be350768;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedb38a5d43be350768 PickSharedb38a5d43be350768() => Sharedb38a5d43be350768 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedb38a5d43be350768' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared44c5e53073934a2b? Shared44c5e53073934a2b { get; init; }
#else
        public global::Vercel.AutoSDKShared44c5e53073934a2b? Shared44c5e53073934a2b { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared44c5e53073934a2b))]
#endif
        public bool IsShared44c5e53073934a2b => Shared44c5e53073934a2b != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared44c5e53073934a2b(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared44c5e53073934a2b? value)
        {
            value = Shared44c5e53073934a2b;
            return IsShared44c5e53073934a2b;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared44c5e53073934a2b PickShared44c5e53073934a2b() => Shared44c5e53073934a2b is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared44c5e53073934a2b' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared2a792fc701a6e66d(global::Vercel.AutoSDKSharedb38a5d43be350768 value) => new AutoSDKShared2a792fc701a6e66d((global::Vercel.AutoSDKSharedb38a5d43be350768?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedb38a5d43be350768?(AutoSDKShared2a792fc701a6e66d @this) => @this.Sharedb38a5d43be350768;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2a792fc701a6e66d(global::Vercel.AutoSDKSharedb38a5d43be350768? value)
        {
            Sharedb38a5d43be350768 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared2a792fc701a6e66d FromSharedb38a5d43be350768(global::Vercel.AutoSDKSharedb38a5d43be350768? value) => new AutoSDKShared2a792fc701a6e66d(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared2a792fc701a6e66d(global::Vercel.AutoSDKShared44c5e53073934a2b value) => new AutoSDKShared2a792fc701a6e66d((global::Vercel.AutoSDKShared44c5e53073934a2b?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared44c5e53073934a2b?(AutoSDKShared2a792fc701a6e66d @this) => @this.Shared44c5e53073934a2b;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2a792fc701a6e66d(global::Vercel.AutoSDKShared44c5e53073934a2b? value)
        {
            Shared44c5e53073934a2b = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared2a792fc701a6e66d FromShared44c5e53073934a2b(global::Vercel.AutoSDKShared44c5e53073934a2b? value) => new AutoSDKShared2a792fc701a6e66d(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2a792fc701a6e66d(
            global::Vercel.AutoSDKSharedb38a5d43be350768? sharedb38a5d43be350768,
            global::Vercel.AutoSDKShared44c5e53073934a2b? shared44c5e53073934a2b
            )
        {
            Sharedb38a5d43be350768 = sharedb38a5d43be350768;
            Shared44c5e53073934a2b = shared44c5e53073934a2b;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared44c5e53073934a2b as object ??
            Sharedb38a5d43be350768 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedb38a5d43be350768?.ToString() ??
            Shared44c5e53073934a2b?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedb38a5d43be350768 && !IsShared44c5e53073934a2b || !IsSharedb38a5d43be350768 && IsShared44c5e53073934a2b;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedb38a5d43be350768, TResult>? sharedb38a5d43be350768 = null,
            global::System.Func<global::Vercel.AutoSDKShared44c5e53073934a2b, TResult>? shared44c5e53073934a2b = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedb38a5d43be350768 is { } __value0 && sharedb38a5d43be350768 != null)
            {
                return sharedb38a5d43be350768(__value0);
            }
            else if (Shared44c5e53073934a2b is { } __value1 && shared44c5e53073934a2b != null)
            {
                return shared44c5e53073934a2b(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedb38a5d43be350768>? sharedb38a5d43be350768 = null,

            global::System.Action<global::Vercel.AutoSDKShared44c5e53073934a2b>? shared44c5e53073934a2b = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedb38a5d43be350768 is { } __value0)
            {
                sharedb38a5d43be350768?.Invoke(__value0);
            }
            else if (Shared44c5e53073934a2b is { } __value1)
            {
                shared44c5e53073934a2b?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedb38a5d43be350768>? sharedb38a5d43be350768 = null,
            global::System.Action<global::Vercel.AutoSDKShared44c5e53073934a2b>? shared44c5e53073934a2b = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedb38a5d43be350768 is { } __value0)
            {
                sharedb38a5d43be350768?.Invoke(__value0);
            }
            else if (Shared44c5e53073934a2b is { } __value1)
            {
                shared44c5e53073934a2b?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedb38a5d43be350768,
                typeof(global::Vercel.AutoSDKSharedb38a5d43be350768),
                Shared44c5e53073934a2b,
                typeof(global::Vercel.AutoSDKShared44c5e53073934a2b),
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
        public bool Equals(AutoSDKShared2a792fc701a6e66d other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedb38a5d43be350768?>.Default.Equals(Sharedb38a5d43be350768, other.Sharedb38a5d43be350768) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared44c5e53073934a2b?>.Default.Equals(Shared44c5e53073934a2b, other.Shared44c5e53073934a2b)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared2a792fc701a6e66d obj1, AutoSDKShared2a792fc701a6e66d obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared2a792fc701a6e66d>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared2a792fc701a6e66d obj1, AutoSDKShared2a792fc701a6e66d obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared2a792fc701a6e66d o && Equals(o);
        }
    }
}
