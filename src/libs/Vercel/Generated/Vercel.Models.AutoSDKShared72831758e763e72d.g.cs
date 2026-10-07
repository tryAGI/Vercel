#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared72831758e763e72d : global::System.IEquatable<AutoSDKShared72831758e763e72d>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedebbc2ea34af24e22? Sharedebbc2ea34af24e22 { get; init; }
#else
        public global::Vercel.AutoSDKSharedebbc2ea34af24e22? Sharedebbc2ea34af24e22 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedebbc2ea34af24e22))]
#endif
        public bool IsSharedebbc2ea34af24e22 => Sharedebbc2ea34af24e22 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedebbc2ea34af24e22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedebbc2ea34af24e22? value)
        {
            value = Sharedebbc2ea34af24e22;
            return IsSharedebbc2ea34af24e22;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedebbc2ea34af24e22 PickSharedebbc2ea34af24e22() => Sharedebbc2ea34af24e22 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedebbc2ea34af24e22' but the value was {ToString()}.");

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
        public static implicit operator AutoSDKShared72831758e763e72d(global::Vercel.AutoSDKSharedebbc2ea34af24e22 value) => new AutoSDKShared72831758e763e72d((global::Vercel.AutoSDKSharedebbc2ea34af24e22?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedebbc2ea34af24e22?(AutoSDKShared72831758e763e72d @this) => @this.Sharedebbc2ea34af24e22;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared72831758e763e72d(global::Vercel.AutoSDKSharedebbc2ea34af24e22? value)
        {
            Sharedebbc2ea34af24e22 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared72831758e763e72d FromSharedebbc2ea34af24e22(global::Vercel.AutoSDKSharedebbc2ea34af24e22? value) => new AutoSDKShared72831758e763e72d(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared72831758e763e72d(global::Vercel.AutoSDKShareddb8a6ccf5b64d660 value) => new AutoSDKShared72831758e763e72d((global::Vercel.AutoSDKShareddb8a6ccf5b64d660?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareddb8a6ccf5b64d660?(AutoSDKShared72831758e763e72d @this) => @this.Shareddb8a6ccf5b64d660;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared72831758e763e72d(global::Vercel.AutoSDKShareddb8a6ccf5b64d660? value)
        {
            Shareddb8a6ccf5b64d660 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared72831758e763e72d FromShareddb8a6ccf5b64d660(global::Vercel.AutoSDKShareddb8a6ccf5b64d660? value) => new AutoSDKShared72831758e763e72d(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared72831758e763e72d(
            global::Vercel.AutoSDKSharedebbc2ea34af24e22? sharedebbc2ea34af24e22,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660? shareddb8a6ccf5b64d660
            )
        {
            Sharedebbc2ea34af24e22 = sharedebbc2ea34af24e22;
            Shareddb8a6ccf5b64d660 = shareddb8a6ccf5b64d660;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shareddb8a6ccf5b64d660 as object ??
            Sharedebbc2ea34af24e22 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedebbc2ea34af24e22?.ToString() ??
            Shareddb8a6ccf5b64d660?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedebbc2ea34af24e22 && !IsShareddb8a6ccf5b64d660 || !IsSharedebbc2ea34af24e22 && IsShareddb8a6ccf5b64d660;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedebbc2ea34af24e22, TResult>? sharedebbc2ea34af24e22 = null,
            global::System.Func<global::Vercel.AutoSDKShareddb8a6ccf5b64d660, TResult>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedebbc2ea34af24e22 is { } __value0 && sharedebbc2ea34af24e22 != null)
            {
                return sharedebbc2ea34af24e22(__value0);
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
            global::System.Action<global::Vercel.AutoSDKSharedebbc2ea34af24e22>? sharedebbc2ea34af24e22 = null,

            global::System.Action<global::Vercel.AutoSDKShareddb8a6ccf5b64d660>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedebbc2ea34af24e22 is { } __value0)
            {
                sharedebbc2ea34af24e22?.Invoke(__value0);
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
            global::System.Action<global::Vercel.AutoSDKSharedebbc2ea34af24e22>? sharedebbc2ea34af24e22 = null,
            global::System.Action<global::Vercel.AutoSDKShareddb8a6ccf5b64d660>? shareddb8a6ccf5b64d660 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedebbc2ea34af24e22 is { } __value0)
            {
                sharedebbc2ea34af24e22?.Invoke(__value0);
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
                Sharedebbc2ea34af24e22,
                typeof(global::Vercel.AutoSDKSharedebbc2ea34af24e22),
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
        public bool Equals(AutoSDKShared72831758e763e72d other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedebbc2ea34af24e22?>.Default.Equals(Sharedebbc2ea34af24e22, other.Sharedebbc2ea34af24e22) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareddb8a6ccf5b64d660?>.Default.Equals(Shareddb8a6ccf5b64d660, other.Shareddb8a6ccf5b64d660)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared72831758e763e72d obj1, AutoSDKShared72831758e763e72d obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared72831758e763e72d>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared72831758e763e72d obj1, AutoSDKShared72831758e763e72d obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared72831758e763e72d o && Equals(o);
        }
    }
}
