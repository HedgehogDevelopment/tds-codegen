using System.Collections.Generic;

namespace HedgehogDevelopment.CodeGeneration.Extensions
{
    public static class GeneralExtensions
    {
        /// <summary>
        /// Returns all elements in the collection except the last 'n'.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="n">The number of elements to skip.</param>
        /// <example> 
        /// This sample shows how to call the <see cref="SkipLast"/> method.
        /// <code>
        ///     int[] ary = new int[5]{ 1, 2, 3, 4, 5};
        ///     IEnumerable&lt;int&gt; results = ary.SkipLast(2);
        /// </code>
        /// The results variable would contain elements 1, 2, and 3.
        /// </example>
        /// <returns>All <typeparamref name="T"/> elements in the source collection except the last 'n'.</returns>
        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source, int n)
        {
            var it = source.GetEnumerator();
            bool hasRemainingItems = false;
            var cache = new Queue<T>(n + 1);

            do
            {
                if (hasRemainingItems = it.MoveNext())
                {
                    cache.Enqueue(it.Current);
                    if (cache.Count > n)
                        yield return cache.Dequeue();
                }
            } while (hasRemainingItems);
        }

        /// <summary>
        /// Gets the value of the item in the dictionary at the specified key.
        /// if the key is not found, returns an empty string.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <remarks>This method is very useful within a T4 file to pull out a specific value of the <c>SitecoreFields</c> property.</remarks>
        /// <returns>The value at the specifed entry, or "" if the key does not exist.</returns>
        public static string GetValue(this Dictionary<string, string> dictionary, string key)
        {
            string @out;
            if (!dictionary.TryGetValue(key, out @out))
            {
                @out = "";
            }
            return @out;
        }
    }
}
