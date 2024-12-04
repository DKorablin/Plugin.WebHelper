using System;
using System.Collections.Generic;

namespace Plugin.WebHelper
{
	public static class ListExtensions
	{
		public static T Find<T>(this IList<T> list, Predicate<T> match)
		{
			_ = match ?? throw new ArgumentNullException(nameof(match));

			for(int i = 0; i < list.Count; i++)
				if(match(list[i]))
					return list[i];

			return default;
		}
	}
}