#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared9e8f7cd3a066bfd9 : global::System.IEquatable<AutoSDKShared9e8f7cd3a066bfd9>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? Shared694e6a1101718234 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? Shared694e6a1101718234 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared694e6a1101718234))]
#endif
        public bool IsShared694e6a1101718234 => Shared694e6a1101718234 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared694e6a1101718234(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? value)
        {
            value = Shared694e6a1101718234;
            return IsShared694e6a1101718234;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d> PickShared694e6a1101718234() => IsShared694e6a1101718234
            ? Shared694e6a1101718234!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared694e6a1101718234' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>? Sharedb521a95e9ebe9a14 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>? Sharedb521a95e9ebe9a14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedb521a95e9ebe9a14))]
#endif
        public bool IsSharedb521a95e9ebe9a14 => Sharedb521a95e9ebe9a14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedb521a95e9ebe9a14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>? value)
        {
            value = Sharedb521a95e9ebe9a14;
            return IsSharedb521a95e9ebe9a14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0> PickSharedb521a95e9ebe9a14() => IsSharedb521a95e9ebe9a14
            ? Sharedb521a95e9ebe9a14!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedb521a95e9ebe9a14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared9e8f7cd3a066bfd9(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? shared694e6a1101718234,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>? sharedb521a95e9ebe9a14
            )
        {
            Shared694e6a1101718234 = shared694e6a1101718234;
            Sharedb521a95e9ebe9a14 = sharedb521a95e9ebe9a14;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedb521a95e9ebe9a14 as object ??
            Shared694e6a1101718234 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared694e6a1101718234?.ToString() ??
            Sharedb521a95e9ebe9a14?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared694e6a1101718234 && !IsSharedb521a95e9ebe9a14 || !IsShared694e6a1101718234 && IsSharedb521a95e9ebe9a14;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>, TResult>? shared694e6a1101718234 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>, TResult>? sharedb521a95e9ebe9a14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared694e6a1101718234 && shared694e6a1101718234 != null)
            {
                return shared694e6a1101718234(Shared694e6a1101718234!);
            }
            else if (IsSharedb521a95e9ebe9a14 && sharedb521a95e9ebe9a14 != null)
            {
                return sharedb521a95e9ebe9a14(Sharedb521a95e9ebe9a14!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>>? shared694e6a1101718234 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>>? sharedb521a95e9ebe9a14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared694e6a1101718234)
            {
                shared694e6a1101718234?.Invoke(Shared694e6a1101718234!);
            }
            else if (IsSharedb521a95e9ebe9a14)
            {
                sharedb521a95e9ebe9a14?.Invoke(Sharedb521a95e9ebe9a14!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>>? shared694e6a1101718234 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>>? sharedb521a95e9ebe9a14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared694e6a1101718234)
            {
                shared694e6a1101718234?.Invoke(Shared694e6a1101718234!);
            }
            else if (IsSharedb521a95e9ebe9a14)
            {
                sharedb521a95e9ebe9a14?.Invoke(Sharedb521a95e9ebe9a14!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared694e6a1101718234,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>),
                Sharedb521a95e9ebe9a14,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>),
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
        public bool Equals(AutoSDKShared9e8f7cd3a066bfd9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>?>.Default.Equals(Shared694e6a1101718234, other.Shared694e6a1101718234) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared383028c008cc4ae0>?>.Default.Equals(Sharedb521a95e9ebe9a14, other.Sharedb521a95e9ebe9a14)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared9e8f7cd3a066bfd9 obj1, AutoSDKShared9e8f7cd3a066bfd9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared9e8f7cd3a066bfd9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared9e8f7cd3a066bfd9 obj1, AutoSDKShared9e8f7cd3a066bfd9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared9e8f7cd3a066bfd9 o && Equals(o);
        }
    }
}
