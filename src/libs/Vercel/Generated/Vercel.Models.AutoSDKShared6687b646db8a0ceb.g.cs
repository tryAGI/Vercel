#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared6687b646db8a0ceb : global::System.IEquatable<AutoSDKShared6687b646db8a0ceb>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared8df5bff0bb4332b8? Shared8df5bff0bb4332b8 { get; init; }
#else
        public global::Vercel.AutoSDKShared8df5bff0bb4332b8? Shared8df5bff0bb4332b8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared8df5bff0bb4332b8))]
#endif
        public bool IsShared8df5bff0bb4332b8 => Shared8df5bff0bb4332b8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared8df5bff0bb4332b8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared8df5bff0bb4332b8? value)
        {
            value = Shared8df5bff0bb4332b8;
            return IsShared8df5bff0bb4332b8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared8df5bff0bb4332b8 PickShared8df5bff0bb4332b8() => Shared8df5bff0bb4332b8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared8df5bff0bb4332b8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShareda861c3cb40ec56dc? Shareda861c3cb40ec56dc { get; init; }
#else
        public global::Vercel.AutoSDKShareda861c3cb40ec56dc? Shareda861c3cb40ec56dc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shareda861c3cb40ec56dc))]
#endif
        public bool IsShareda861c3cb40ec56dc => Shareda861c3cb40ec56dc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShareda861c3cb40ec56dc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShareda861c3cb40ec56dc? value)
        {
            value = Shareda861c3cb40ec56dc;
            return IsShareda861c3cb40ec56dc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShareda861c3cb40ec56dc PickShareda861c3cb40ec56dc() => Shareda861c3cb40ec56dc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shareda861c3cb40ec56dc' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6687b646db8a0ceb(global::Vercel.AutoSDKShared8df5bff0bb4332b8 value) => new AutoSDKShared6687b646db8a0ceb((global::Vercel.AutoSDKShared8df5bff0bb4332b8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared8df5bff0bb4332b8?(AutoSDKShared6687b646db8a0ceb @this) => @this.Shared8df5bff0bb4332b8;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6687b646db8a0ceb(global::Vercel.AutoSDKShared8df5bff0bb4332b8? value)
        {
            Shared8df5bff0bb4332b8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6687b646db8a0ceb FromShared8df5bff0bb4332b8(global::Vercel.AutoSDKShared8df5bff0bb4332b8? value) => new AutoSDKShared6687b646db8a0ceb(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6687b646db8a0ceb(global::Vercel.AutoSDKShareda861c3cb40ec56dc value) => new AutoSDKShared6687b646db8a0ceb((global::Vercel.AutoSDKShareda861c3cb40ec56dc?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShareda861c3cb40ec56dc?(AutoSDKShared6687b646db8a0ceb @this) => @this.Shareda861c3cb40ec56dc;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6687b646db8a0ceb(global::Vercel.AutoSDKShareda861c3cb40ec56dc? value)
        {
            Shareda861c3cb40ec56dc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6687b646db8a0ceb FromShareda861c3cb40ec56dc(global::Vercel.AutoSDKShareda861c3cb40ec56dc? value) => new AutoSDKShared6687b646db8a0ceb(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6687b646db8a0ceb(
            global::Vercel.AutoSDKShared8df5bff0bb4332b8? shared8df5bff0bb4332b8,
            global::Vercel.AutoSDKShareda861c3cb40ec56dc? shareda861c3cb40ec56dc
            )
        {
            Shared8df5bff0bb4332b8 = shared8df5bff0bb4332b8;
            Shareda861c3cb40ec56dc = shareda861c3cb40ec56dc;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shareda861c3cb40ec56dc as object ??
            Shared8df5bff0bb4332b8 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared8df5bff0bb4332b8?.ToString() ??
            Shareda861c3cb40ec56dc?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared8df5bff0bb4332b8 && !IsShareda861c3cb40ec56dc || !IsShared8df5bff0bb4332b8 && IsShareda861c3cb40ec56dc;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared8df5bff0bb4332b8, TResult>? shared8df5bff0bb4332b8 = null,
            global::System.Func<global::Vercel.AutoSDKShareda861c3cb40ec56dc, TResult>? shareda861c3cb40ec56dc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared8df5bff0bb4332b8 is { } __value0 && shared8df5bff0bb4332b8 != null)
            {
                return shared8df5bff0bb4332b8(__value0);
            }
            else if (Shareda861c3cb40ec56dc is { } __value1 && shareda861c3cb40ec56dc != null)
            {
                return shareda861c3cb40ec56dc(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? shared8df5bff0bb4332b8 = null,

            global::System.Action<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? shareda861c3cb40ec56dc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared8df5bff0bb4332b8 is { } __value0)
            {
                shared8df5bff0bb4332b8?.Invoke(__value0);
            }
            else if (Shareda861c3cb40ec56dc is { } __value1)
            {
                shareda861c3cb40ec56dc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? shared8df5bff0bb4332b8 = null,
            global::System.Action<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? shareda861c3cb40ec56dc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared8df5bff0bb4332b8 is { } __value0)
            {
                shared8df5bff0bb4332b8?.Invoke(__value0);
            }
            else if (Shareda861c3cb40ec56dc is { } __value1)
            {
                shareda861c3cb40ec56dc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared8df5bff0bb4332b8,
                typeof(global::Vercel.AutoSDKShared8df5bff0bb4332b8),
                Shareda861c3cb40ec56dc,
                typeof(global::Vercel.AutoSDKShareda861c3cb40ec56dc),
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
        public bool Equals(AutoSDKShared6687b646db8a0ceb other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared8df5bff0bb4332b8?>.Default.Equals(Shared8df5bff0bb4332b8, other.Shared8df5bff0bb4332b8) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShareda861c3cb40ec56dc?>.Default.Equals(Shareda861c3cb40ec56dc, other.Shareda861c3cb40ec56dc)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared6687b646db8a0ceb obj1, AutoSDKShared6687b646db8a0ceb obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared6687b646db8a0ceb>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared6687b646db8a0ceb obj1, AutoSDKShared6687b646db8a0ceb obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared6687b646db8a0ceb o && Equals(o);
        }
    }
}
