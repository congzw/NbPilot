using System;
using System.Linq.Expressions;

namespace NbCloud.Common.Extensions
{
    public static class CommonExtension
    {
        /// <summary>
        /// 扩展的字符串比较
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str2"></param>
        /// <param name="stringComparison"></param>
        /// <param name="trimSpaceBeforeCompare"></param>
        /// <returns></returns>
        public static bool NbEquals(this String value, string str2, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase, bool trimSpaceBeforeCompare = true)
        {
            if (value == null)
            {
                return false;
            }

            if (str2 == null)
            {
                return false;
            }

            if (trimSpaceBeforeCompare)
            {
                return value.Trim().Equals(str2.Trim(), stringComparison);
            }

            return value.Equals(str2, stringComparison);
        }

        public static String NameOf<T, TT>(this Expression<Func<T, TT>> accessor)
        {
            return _nameof(accessor.Body);
        }

        public static String NameOf<T>(this Expression<Func<T>> accessor)
        {
            return _nameof(accessor.Body);
        }

        public static String NameOf<T, TT>(this T obj, Expression<Func<T, TT>> propertyAccessor)
        {
            return _nameof(propertyAccessor.Body);
        }

        private static String _nameof(Expression expression)
        {
            if (expression.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = expression as MemberExpression;
                if (memberExpression == null)
                    return null;
                return memberExpression.Member.Name;
            }
            return null;
        }
    }
}
