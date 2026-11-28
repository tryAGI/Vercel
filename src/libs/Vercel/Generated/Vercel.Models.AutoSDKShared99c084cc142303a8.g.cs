#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared99c084cc142303a8 : global::System.IEquatable<AutoSDKShared99c084cc142303a8>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? Shared9b57ea33f990577c { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? Shared9b57ea33f990577c { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared9b57ea33f990577c))]
#endif
        public bool IsShared9b57ea33f990577c => Shared9b57ea33f990577c != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared9b57ea33f990577c(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? value)
        {
            value = Shared9b57ea33f990577c;
            return IsShared9b57ea33f990577c;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5> PickShared9b57ea33f990577c() => Shared9b57ea33f990577c is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared9b57ea33f990577c' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>? Sharedfde22618724ae074 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>? Sharedfde22618724ae074 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedfde22618724ae074))]
#endif
        public bool IsSharedfde22618724ae074 => Sharedfde22618724ae074 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedfde22618724ae074(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>? value)
        {
            value = Sharedfde22618724ae074;
            return IsSharedfde22618724ae074;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7> PickSharedfde22618724ae074() => Sharedfde22618724ae074 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedfde22618724ae074' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared99c084cc142303a8(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>? shared9b57ea33f990577c,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>? sharedfde22618724ae074
            )
        {
            Shared9b57ea33f990577c = shared9b57ea33f990577c;
            Sharedfde22618724ae074 = sharedfde22618724ae074;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedfde22618724ae074 as object ??
            Shared9b57ea33f990577c as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared9b57ea33f990577c?.ToString() ??
            Sharedfde22618724ae074?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared9b57ea33f990577c && !IsSharedfde22618724ae074 || !IsShared9b57ea33f990577c && IsSharedfde22618724ae074;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>, TResult>? shared9b57ea33f990577c = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>, TResult>? sharedfde22618724ae074 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared9b57ea33f990577c is { } __value0 && shared9b57ea33f990577c != null)
            {
                return shared9b57ea33f990577c(__value0);
            }
            else if (Sharedfde22618724ae074 is { } __value1 && sharedfde22618724ae074 != null)
            {
                return sharedfde22618724ae074(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>>? shared9b57ea33f990577c = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>>? sharedfde22618724ae074 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared9b57ea33f990577c is { } __value0)
            {
                shared9b57ea33f990577c?.Invoke(__value0);
            }
            else if (Sharedfde22618724ae074 is { } __value1)
            {
                sharedfde22618724ae074?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>>? shared9b57ea33f990577c = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>>? sharedfde22618724ae074 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared9b57ea33f990577c is { } __value0)
            {
                shared9b57ea33f990577c?.Invoke(__value0);
            }
            else if (Sharedfde22618724ae074 is { } __value1)
            {
                sharedfde22618724ae074?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared9b57ea33f990577c,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>),
                Sharedfde22618724ae074,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>),
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
        public bool Equals(AutoSDKShared99c084cc142303a8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda3e211e8bee7aaa5>?>.Default.Equals(Shared9b57ea33f990577c, other.Shared9b57ea33f990577c) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2b02cf1378da97a7>?>.Default.Equals(Sharedfde22618724ae074, other.Sharedfde22618724ae074)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared99c084cc142303a8 obj1, AutoSDKShared99c084cc142303a8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared99c084cc142303a8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared99c084cc142303a8 obj1, AutoSDKShared99c084cc142303a8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared99c084cc142303a8 o && Equals(o);
        }
    }
}
