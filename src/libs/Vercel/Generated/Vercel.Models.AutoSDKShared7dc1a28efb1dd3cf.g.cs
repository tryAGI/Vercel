#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared7dc1a28efb1dd3cf : global::System.IEquatable<AutoSDKShared7dc1a28efb1dd3cf>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>? Sharedacd8c1d4318adbff { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>? Sharedacd8c1d4318adbff { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedacd8c1d4318adbff))]
#endif
        public bool IsSharedacd8c1d4318adbff => Sharedacd8c1d4318adbff != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedacd8c1d4318adbff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>? value)
        {
            value = Sharedacd8c1d4318adbff;
            return IsSharedacd8c1d4318adbff;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217> PickSharedacd8c1d4318adbff() => Sharedacd8c1d4318adbff is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedacd8c1d4318adbff' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>? Shared995845ab6176de6a { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>? Shared995845ab6176de6a { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared995845ab6176de6a))]
#endif
        public bool IsShared995845ab6176de6a => Shared995845ab6176de6a != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared995845ab6176de6a(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>? value)
        {
            value = Shared995845ab6176de6a;
            return IsShared995845ab6176de6a;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833> PickShared995845ab6176de6a() => Shared995845ab6176de6a is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared995845ab6176de6a' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared7dc1a28efb1dd3cf(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>? sharedacd8c1d4318adbff,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>? shared995845ab6176de6a
            )
        {
            Sharedacd8c1d4318adbff = sharedacd8c1d4318adbff;
            Shared995845ab6176de6a = shared995845ab6176de6a;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared995845ab6176de6a as object ??
            Sharedacd8c1d4318adbff as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedacd8c1d4318adbff?.ToString() ??
            Shared995845ab6176de6a?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedacd8c1d4318adbff && !IsShared995845ab6176de6a || !IsSharedacd8c1d4318adbff && IsShared995845ab6176de6a;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>, TResult>? sharedacd8c1d4318adbff = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>, TResult>? shared995845ab6176de6a = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedacd8c1d4318adbff is { } __value0 && sharedacd8c1d4318adbff != null)
            {
                return sharedacd8c1d4318adbff(__value0);
            }
            else if (Shared995845ab6176de6a is { } __value1 && shared995845ab6176de6a != null)
            {
                return shared995845ab6176de6a(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>>? sharedacd8c1d4318adbff = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>>? shared995845ab6176de6a = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedacd8c1d4318adbff is { } __value0)
            {
                sharedacd8c1d4318adbff?.Invoke(__value0);
            }
            else if (Shared995845ab6176de6a is { } __value1)
            {
                shared995845ab6176de6a?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>>? sharedacd8c1d4318adbff = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>>? shared995845ab6176de6a = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedacd8c1d4318adbff is { } __value0)
            {
                sharedacd8c1d4318adbff?.Invoke(__value0);
            }
            else if (Shared995845ab6176de6a is { } __value1)
            {
                shared995845ab6176de6a?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedacd8c1d4318adbff,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>),
                Shared995845ab6176de6a,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>),
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
        public bool Equals(AutoSDKShared7dc1a28efb1dd3cf other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0695a89a4e02b217>?>.Default.Equals(Sharedacd8c1d4318adbff, other.Sharedacd8c1d4318adbff) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6df91f8a45eab833>?>.Default.Equals(Shared995845ab6176de6a, other.Shared995845ab6176de6a)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared7dc1a28efb1dd3cf obj1, AutoSDKShared7dc1a28efb1dd3cf obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared7dc1a28efb1dd3cf>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared7dc1a28efb1dd3cf obj1, AutoSDKShared7dc1a28efb1dd3cf obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared7dc1a28efb1dd3cf o && Equals(o);
        }
    }
}
