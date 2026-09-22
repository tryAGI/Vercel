#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedb141477327f89107 : global::System.IEquatable<AutoSDKSharedb141477327f89107>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>? Sharedd4b653fb5dd38455 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>? Sharedd4b653fb5dd38455 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedd4b653fb5dd38455))]
#endif
        public bool IsSharedd4b653fb5dd38455 => Sharedd4b653fb5dd38455 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedd4b653fb5dd38455(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>? value)
        {
            value = Sharedd4b653fb5dd38455;
            return IsSharedd4b653fb5dd38455;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25> PickSharedd4b653fb5dd38455() => IsSharedd4b653fb5dd38455
            ? Sharedd4b653fb5dd38455!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedd4b653fb5dd38455' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>? Shared55f646a1bfab79c6 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>? Shared55f646a1bfab79c6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared55f646a1bfab79c6))]
#endif
        public bool IsShared55f646a1bfab79c6 => Shared55f646a1bfab79c6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared55f646a1bfab79c6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>? value)
        {
            value = Shared55f646a1bfab79c6;
            return IsShared55f646a1bfab79c6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c> PickShared55f646a1bfab79c6() => IsShared55f646a1bfab79c6
            ? Shared55f646a1bfab79c6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared55f646a1bfab79c6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedb141477327f89107(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>? sharedd4b653fb5dd38455,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>? shared55f646a1bfab79c6
            )
        {
            Sharedd4b653fb5dd38455 = sharedd4b653fb5dd38455;
            Shared55f646a1bfab79c6 = shared55f646a1bfab79c6;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared55f646a1bfab79c6 as object ??
            Sharedd4b653fb5dd38455 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedd4b653fb5dd38455?.ToString() ??
            Shared55f646a1bfab79c6?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedd4b653fb5dd38455 && !IsShared55f646a1bfab79c6 || !IsSharedd4b653fb5dd38455 && IsShared55f646a1bfab79c6;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>, TResult>? sharedd4b653fb5dd38455 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>, TResult>? shared55f646a1bfab79c6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedd4b653fb5dd38455 && sharedd4b653fb5dd38455 != null)
            {
                return sharedd4b653fb5dd38455(Sharedd4b653fb5dd38455!);
            }
            else if (IsShared55f646a1bfab79c6 && shared55f646a1bfab79c6 != null)
            {
                return shared55f646a1bfab79c6(Shared55f646a1bfab79c6!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>>? sharedd4b653fb5dd38455 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>>? shared55f646a1bfab79c6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedd4b653fb5dd38455)
            {
                sharedd4b653fb5dd38455?.Invoke(Sharedd4b653fb5dd38455!);
            }
            else if (IsShared55f646a1bfab79c6)
            {
                shared55f646a1bfab79c6?.Invoke(Shared55f646a1bfab79c6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>>? sharedd4b653fb5dd38455 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>>? shared55f646a1bfab79c6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedd4b653fb5dd38455)
            {
                sharedd4b653fb5dd38455?.Invoke(Sharedd4b653fb5dd38455!);
            }
            else if (IsShared55f646a1bfab79c6)
            {
                shared55f646a1bfab79c6?.Invoke(Shared55f646a1bfab79c6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedd4b653fb5dd38455,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>),
                Shared55f646a1bfab79c6,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>),
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
        public bool Equals(AutoSDKSharedb141477327f89107 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4a7c153fe760e25>?>.Default.Equals(Sharedd4b653fb5dd38455, other.Sharedd4b653fb5dd38455) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared990c7cda5d679d8c>?>.Default.Equals(Shared55f646a1bfab79c6, other.Shared55f646a1bfab79c6)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedb141477327f89107 obj1, AutoSDKSharedb141477327f89107 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedb141477327f89107>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedb141477327f89107 obj1, AutoSDKSharedb141477327f89107 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedb141477327f89107 o && Equals(o);
        }
    }
}
