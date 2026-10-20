#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedef431bb3026a2de5 : global::System.IEquatable<AutoSDKSharedef431bb3026a2de5>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15be? Sharede3c00aaf9d3a15be { get; init; }
#else
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15be? Sharede3c00aaf9d3a15be { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharede3c00aaf9d3a15be))]
#endif
        public bool IsSharede3c00aaf9d3a15be => Sharede3c00aaf9d3a15be != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharede3c00aaf9d3a15be(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharede3c00aaf9d3a15be? value)
        {
            value = Sharede3c00aaf9d3a15be;
            return IsSharede3c00aaf9d3a15be;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15be PickSharede3c00aaf9d3a15be() => Sharede3c00aaf9d3a15be is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharede3c00aaf9d3a15be' but the value was {ToString()}.");

        /// <summary>
        /// Vercel CI check run without a parent `check` (no `checkId` field).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660? Shareddb8a6ccf5b64d660 { get; init; }
#else
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660? Shareddb8a6ccf5b64d660 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shareddb8a6ccf5b64d660))]
#endif
        public bool IsShareddb8a6ccf5b64d660 => Shareddb8a6ccf5b64d660 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShareddb8a6ccf5b64d660(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShareddb8a6ccf5b64d660? value)
        {
            value = Shareddb8a6ccf5b64d660;
            return IsShareddb8a6ccf5b64d660;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660 PickShareddb8a6ccf5b64d660() => Shareddb8a6ccf5b64d660 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shareddb8a6ccf5b64d660' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedef431bb3026a2de5(global::Vercel.AutoSDKSharede3c00aaf9d3a15be value) => new AutoSDKSharedef431bb3026a2de5((global::Vercel.AutoSDKSharede3c00aaf9d3a15be?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharede3c00aaf9d3a15be?(AutoSDKSharedef431bb3026a2de5 @this) => @this.Sharede3c00aaf9d3a15be;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedef431bb3026a2de5(global::Vercel.AutoSDKSharede3c00aaf9d3a15be? value)
        {
            Sharede3c00aaf9d3a15be = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedef431bb3026a2de5 FromSharede3c00aaf9d3a15be(global::Vercel.AutoSDKSharede3c00aaf9d3a15be? value) => new AutoSDKSharedef431bb3026a2de5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedef431bb3026a2de5(global::Vercel.AutoSDKShareddb8a6ccf5b64d660 value) => new AutoSDKSharedef431bb3026a2de5((global::Vercel.AutoSDKShareddb8a6ccf5b64d660?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareddb8a6ccf5b64d660?(AutoSDKSharedef431bb3026a2de5 @this) => @this.Shareddb8a6ccf5b64d660;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedef431bb3026a2de5(global::Vercel.AutoSDKShareddb8a6ccf5b64d660? value)
        {
            Shareddb8a6ccf5b64d660 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedef431bb3026a2de5 FromShareddb8a6ccf5b64d660(global::Vercel.AutoSDKShareddb8a6ccf5b64d660? value) => new AutoSDKSharedef431bb3026a2de5(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedef431bb3026a2de5(
            global::Vercel.AutoSDKSharede3c00aaf9d3a15be? sharede3c00aaf9d3a15be,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660? shareddb8a6ccf5b64d660
            )
        {
            Sharede3c00aaf9d3a15be = sharede3c00aaf9d3a15be;
            Shareddb8a6ccf5b64d660 = shareddb8a6ccf5b64d660;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shareddb8a6ccf5b64d660 as object ??
            Sharede3c00aaf9d3a15be as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharede3c00aaf9d3a15be?.ToString() ??
            Shareddb8a6ccf5b64d660?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharede3c00aaf9d3a15be && !IsShareddb8a6ccf5b64d660 || !IsSharede3c00aaf9d3a15be && IsShareddb8a6ccf5b64d660;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharede3c00aaf9d3a15be, TResult>? sharede3c00aaf9d3a15be = null,
            global::System.Func<global::Vercel.AutoSDKShareddb8a6ccf5b64d660, TResult>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharede3c00aaf9d3a15be is { } __value0 && sharede3c00aaf9d3a15be != null)
            {
                return sharede3c00aaf9d3a15be(__value0);
            }
            else if (Shareddb8a6ccf5b64d660 is { } __value1 && shareddb8a6ccf5b64d660 != null)
            {
                return shareddb8a6ccf5b64d660(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharede3c00aaf9d3a15be>? sharede3c00aaf9d3a15be = null,

            global::System.Action<global::Vercel.AutoSDKShareddb8a6ccf5b64d660>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharede3c00aaf9d3a15be is { } __value0)
            {
                sharede3c00aaf9d3a15be?.Invoke(__value0);
            }
            else if (Shareddb8a6ccf5b64d660 is { } __value1)
            {
                shareddb8a6ccf5b64d660?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharede3c00aaf9d3a15be>? sharede3c00aaf9d3a15be = null,
            global::System.Action<global::Vercel.AutoSDKShareddb8a6ccf5b64d660>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharede3c00aaf9d3a15be is { } __value0)
            {
                sharede3c00aaf9d3a15be?.Invoke(__value0);
            }
            else if (Shareddb8a6ccf5b64d660 is { } __value1)
            {
                shareddb8a6ccf5b64d660?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharede3c00aaf9d3a15be,
                typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be),
                Shareddb8a6ccf5b64d660,
                typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660),
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
        public bool Equals(AutoSDKSharedef431bb3026a2de5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharede3c00aaf9d3a15be?>.Default.Equals(Sharede3c00aaf9d3a15be, other.Sharede3c00aaf9d3a15be) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareddb8a6ccf5b64d660?>.Default.Equals(Shareddb8a6ccf5b64d660, other.Shareddb8a6ccf5b64d660)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedef431bb3026a2de5 obj1, AutoSDKSharedef431bb3026a2de5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedef431bb3026a2de5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedef431bb3026a2de5 obj1, AutoSDKSharedef431bb3026a2de5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedef431bb3026a2de5 o && Equals(o);
        }
    }
}
