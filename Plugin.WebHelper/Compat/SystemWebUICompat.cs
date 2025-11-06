#if !NETFRAMEWORK
using System;

namespace System.Web.UI
{
	/// <summary>Pair class for .NET 8 (compatibility layer for System.Web.UI.Pair)</summary>
	public sealed class Pair
	{
		public Object First { get; set; }
		public Object Second { get; set; }

		public Pair()
		{
		}

		public Pair(Object x, Object y)
		{
			this.First = x;
			this.Second = y;
		}
	}

	/// <summary>Triplet class for .NET 8 (compatibility layer for System.Web.UI.Triplet)</summary>
	public sealed class Triplet
	{
		public Object First { get; set; }
		public Object Second { get; set; }
		public Object Third { get; set; }

		public Triplet()
		{
		}

		public Triplet(Object x, Object y, Object z)
		{
			this.First = x;
			this.Second = y;
			this.Third = z;
		}
	}

	/// <summary>IndexedString class for .NET 8 (compatibility layer for System.Web.UI.IndexedString)</summary>
	internal sealed class IndexedString
	{
		public String Value { get; }

		public IndexedString(String s)
			=> this.Value = s;
	}
}
#endif