#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared1b28a5d7512c83d2 : global::System.IEquatable<AutoSDKShared1b28a5d7512c83d2>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared12773eaec07789a9? Shared12773eaec07789a9 { get; init; }
#else
        public global::Vercel.AutoSDKShared12773eaec07789a9? Shared12773eaec07789a9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared12773eaec07789a9))]
#endif
        public bool IsShared12773eaec07789a9 => Shared12773eaec07789a9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared12773eaec07789a9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared12773eaec07789a9? value)
        {
            value = Shared12773eaec07789a9;
            return IsShared12773eaec07789a9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared12773eaec07789a9 PickShared12773eaec07789a9() => Shared12773eaec07789a9 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared12773eaec07789a9' but the value was {ToString()}.");

        /// <summary>
        /// Vercel CI check run without a parent `check` (no `checkId` field).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared429cd580a486c43e? Shared429cd580a486c43e { get; init; }
#else
        public global::Vercel.AutoSDKShared429cd580a486c43e? Shared429cd580a486c43e { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared429cd580a486c43e))]
#endif
        public bool IsShared429cd580a486c43e => Shared429cd580a486c43e != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared429cd580a486c43e(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared429cd580a486c43e? value)
        {
            value = Shared429cd580a486c43e;
            return IsShared429cd580a486c43e;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared429cd580a486c43e PickShared429cd580a486c43e() => Shared429cd580a486c43e is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared429cd580a486c43e' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared1b28a5d7512c83d2(global::Vercel.AutoSDKShared12773eaec07789a9 value) => new AutoSDKShared1b28a5d7512c83d2((global::Vercel.AutoSDKShared12773eaec07789a9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared12773eaec07789a9?(AutoSDKShared1b28a5d7512c83d2 @this) => @this.Shared12773eaec07789a9;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared1b28a5d7512c83d2(global::Vercel.AutoSDKShared12773eaec07789a9? value)
        {
            Shared12773eaec07789a9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared1b28a5d7512c83d2 FromShared12773eaec07789a9(global::Vercel.AutoSDKShared12773eaec07789a9? value) => new AutoSDKShared1b28a5d7512c83d2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared1b28a5d7512c83d2(global::Vercel.AutoSDKShared429cd580a486c43e value) => new AutoSDKShared1b28a5d7512c83d2((global::Vercel.AutoSDKShared429cd580a486c43e?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared429cd580a486c43e?(AutoSDKShared1b28a5d7512c83d2 @this) => @this.Shared429cd580a486c43e;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared1b28a5d7512c83d2(global::Vercel.AutoSDKShared429cd580a486c43e? value)
        {
            Shared429cd580a486c43e = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared1b28a5d7512c83d2 FromShared429cd580a486c43e(global::Vercel.AutoSDKShared429cd580a486c43e? value) => new AutoSDKShared1b28a5d7512c83d2(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared1b28a5d7512c83d2(
            global::Vercel.AutoSDKShared12773eaec07789a9? shared12773eaec07789a9,
            global::Vercel.AutoSDKShared429cd580a486c43e? shared429cd580a486c43e
            )
        {
            Shared12773eaec07789a9 = shared12773eaec07789a9;
            Shared429cd580a486c43e = shared429cd580a486c43e;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared429cd580a486c43e as object ??
            Shared12773eaec07789a9 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared12773eaec07789a9?.ToString() ??
            Shared429cd580a486c43e?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared12773eaec07789a9 && !IsShared429cd580a486c43e || !IsShared12773eaec07789a9 && IsShared429cd580a486c43e;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared12773eaec07789a9, TResult>? shared12773eaec07789a9 = null,
            global::System.Func<global::Vercel.AutoSDKShared429cd580a486c43e, TResult>? shared429cd580a486c43e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared12773eaec07789a9 is { } __value0 && shared12773eaec07789a9 != null)
            {
                return shared12773eaec07789a9(__value0);
            }
            else if (Shared429cd580a486c43e is { } __value1 && shared429cd580a486c43e != null)
            {
                return shared429cd580a486c43e(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared12773eaec07789a9>? shared12773eaec07789a9 = null,

            global::System.Action<global::Vercel.AutoSDKShared429cd580a486c43e>? shared429cd580a486c43e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared12773eaec07789a9 is { } __value0)
            {
                shared12773eaec07789a9?.Invoke(__value0);
            }
            else if (Shared429cd580a486c43e is { } __value1)
            {
                shared429cd580a486c43e?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared12773eaec07789a9>? shared12773eaec07789a9 = null,
            global::System.Action<global::Vercel.AutoSDKShared429cd580a486c43e>? shared429cd580a486c43e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared12773eaec07789a9 is { } __value0)
            {
                shared12773eaec07789a9?.Invoke(__value0);
            }
            else if (Shared429cd580a486c43e is { } __value1)
            {
                shared429cd580a486c43e?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared12773eaec07789a9,
                typeof(global::Vercel.AutoSDKShared12773eaec07789a9),
                Shared429cd580a486c43e,
                typeof(global::Vercel.AutoSDKShared429cd580a486c43e),
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
        public bool Equals(AutoSDKShared1b28a5d7512c83d2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared12773eaec07789a9?>.Default.Equals(Shared12773eaec07789a9, other.Shared12773eaec07789a9) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared429cd580a486c43e?>.Default.Equals(Shared429cd580a486c43e, other.Shared429cd580a486c43e)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared1b28a5d7512c83d2 obj1, AutoSDKShared1b28a5d7512c83d2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared1b28a5d7512c83d2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared1b28a5d7512c83d2 obj1, AutoSDKShared1b28a5d7512c83d2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared1b28a5d7512c83d2 o && Equals(o);
        }
    }
}
