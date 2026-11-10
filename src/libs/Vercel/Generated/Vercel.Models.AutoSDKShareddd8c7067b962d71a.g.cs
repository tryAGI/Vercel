#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShareddd8c7067b962d71a : global::System.IEquatable<AutoSDKShareddd8c7067b962d71a>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? Sharedd9480afa024ae3ea { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? Sharedd9480afa024ae3ea { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedd9480afa024ae3ea))]
#endif
        public bool IsSharedd9480afa024ae3ea => Sharedd9480afa024ae3ea != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedd9480afa024ae3ea(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? value)
        {
            value = Sharedd9480afa024ae3ea;
            return IsSharedd9480afa024ae3ea;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8> PickSharedd9480afa024ae3ea() => Sharedd9480afa024ae3ea is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedd9480afa024ae3ea' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? Shared7c2d806b1e52ea93 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? Shared7c2d806b1e52ea93 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared7c2d806b1e52ea93))]
#endif
        public bool IsShared7c2d806b1e52ea93 => Shared7c2d806b1e52ea93 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared7c2d806b1e52ea93(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? value)
        {
            value = Shared7c2d806b1e52ea93;
            return IsShared7c2d806b1e52ea93;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc> PickShared7c2d806b1e52ea93() => Shared7c2d806b1e52ea93 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared7c2d806b1e52ea93' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareddd8c7067b962d71a(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>? sharedd9480afa024ae3ea,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>? shared7c2d806b1e52ea93
            )
        {
            Sharedd9480afa024ae3ea = sharedd9480afa024ae3ea;
            Shared7c2d806b1e52ea93 = shared7c2d806b1e52ea93;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared7c2d806b1e52ea93 as object ??
            Sharedd9480afa024ae3ea as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedd9480afa024ae3ea?.ToString() ??
            Shared7c2d806b1e52ea93?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedd9480afa024ae3ea && !IsShared7c2d806b1e52ea93 || !IsSharedd9480afa024ae3ea && IsShared7c2d806b1e52ea93;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>, TResult>? sharedd9480afa024ae3ea = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>, TResult>? shared7c2d806b1e52ea93 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd9480afa024ae3ea is { } __value0 && sharedd9480afa024ae3ea != null)
            {
                return sharedd9480afa024ae3ea(__value0);
            }
            else if (Shared7c2d806b1e52ea93 is { } __value1 && shared7c2d806b1e52ea93 != null)
            {
                return shared7c2d806b1e52ea93(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>>? sharedd9480afa024ae3ea = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>>? shared7c2d806b1e52ea93 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd9480afa024ae3ea is { } __value0)
            {
                sharedd9480afa024ae3ea?.Invoke(__value0);
            }
            else if (Shared7c2d806b1e52ea93 is { } __value1)
            {
                shared7c2d806b1e52ea93?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>>? sharedd9480afa024ae3ea = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>>? shared7c2d806b1e52ea93 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd9480afa024ae3ea is { } __value0)
            {
                sharedd9480afa024ae3ea?.Invoke(__value0);
            }
            else if (Shared7c2d806b1e52ea93 is { } __value1)
            {
                shared7c2d806b1e52ea93?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedd9480afa024ae3ea,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>),
                Shared7c2d806b1e52ea93,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>),
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
        public bool Equals(AutoSDKShareddd8c7067b962d71a other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared8df5bff0bb4332b8>?>.Default.Equals(Sharedd9480afa024ae3ea, other.Sharedd9480afa024ae3ea) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda861c3cb40ec56dc>?>.Default.Equals(Shared7c2d806b1e52ea93, other.Shared7c2d806b1e52ea93)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShareddd8c7067b962d71a obj1, AutoSDKShareddd8c7067b962d71a obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShareddd8c7067b962d71a>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShareddd8c7067b962d71a obj1, AutoSDKShareddd8c7067b962d71a obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShareddd8c7067b962d71a o && Equals(o);
        }
    }
}
