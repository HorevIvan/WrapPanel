using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WrapPanel2
{
    public static class ContentRepository
    {
        public static IEnumerable<ContentItem> GetTop(Int32 count)
        {
            return GenerateTop(count);
        }

        public static IEnumerable<ContentItem> GetNew(Int32 last)
        {
            return GenerateNew(last);
        }

        public static IEnumerable<ContentItem> GetOld(Int32 first, Int32 count)
        {
            return GenerateOld(first, count);
        }

        #region Generate

        private static readonly Random Random = new Random();

        private static IEnumerable<ContentItem> GenerateTop(Int32 count)
        {
            var startNumber = Random.Next(1000, 2000);

            for (var i = (startNumber - count); i < startNumber; i++)
            {
                yield return Generate(i);
            }
        }

        private static IEnumerable<ContentItem> GenerateNew(Int32 last)
        {
            var count = Random.Next(-5, 5);

            for (var i = 0; i < count; i++)
            {
                yield return Generate(last + i);
            }
        }

        private static IEnumerable<ContentItem> GenerateOld(Int32 first, Int32 count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return Generate(first);
            }
        }

        private static ContentItem Generate(Int32 number)
        {
            return
                new ContentItem
                {
                    Number = number,
                };
        }

        #endregion
    }

    public class ContentItem
    {
        public Int32 Number { set; get; }
    }
}