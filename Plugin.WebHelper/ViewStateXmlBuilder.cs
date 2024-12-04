using System;
using System.Collections;
using System.Collections.Specialized;
using System.Web.UI;
using System.Xml;
using System.Reflection;

namespace Plugin.WebHelper
{
	public class ViewStateXmlBuilder
	{
		private static void BuildElement(XmlDocument dom, XmlElement elem, Object treeNode, ref XmlDocument controlstateDom)
		{
			if(treeNode != null)
			{
				XmlElement element;
				Type type = treeNode.GetType();
				if(type == typeof(Triplet))
				{
					element = dom.CreateElement(ViewStateXmlBuilder.GetShortTypename(treeNode));
					elem.AppendChild(element);
					ViewStateXmlBuilder.BuildElement(dom, element, ((Triplet)treeNode).First, ref controlstateDom);
					ViewStateXmlBuilder.BuildElement(dom, element, ((Triplet)treeNode).Second, ref controlstateDom);
					ViewStateXmlBuilder.BuildElement(dom, element, ((Triplet)treeNode).Third, ref controlstateDom);
				} else if(type == typeof(Pair))
				{
					element = dom.CreateElement(ViewStateXmlBuilder.GetShortTypename(treeNode));
					elem.AppendChild(element);
					ViewStateXmlBuilder.BuildElement(dom, element, ((Pair)treeNode).First, ref controlstateDom);
					ViewStateXmlBuilder.BuildElement(dom, element, ((Pair)treeNode).Second, ref controlstateDom);
				} else if(type == typeof(ArrayList))
				{
					element = dom.CreateElement(ViewStateXmlBuilder.GetShortTypename(treeNode));
					elem.AppendChild(element);
					foreach(Object obj2 in (ArrayList)treeNode)
						ViewStateXmlBuilder.BuildElement(dom, element, obj2, ref controlstateDom);
				} else if(treeNode is Array)
				{
					element = dom.CreateElement("Array");
					elem.AppendChild(element);
					foreach(Object obj3 in (Array)treeNode)
						ViewStateXmlBuilder.BuildElement(dom, element, obj3, ref controlstateDom);
				} else if(treeNode is HybridDictionary)
				{
					element = controlstateDom.CreateElement(ViewStateXmlBuilder.GetShortTypename(treeNode));
					controlstateDom.DocumentElement.AppendChild(element);
					foreach(Object obj4 in (HybridDictionary)treeNode)
						ViewStateXmlBuilder.BuildElement(controlstateDom, element, obj4, ref controlstateDom);
				} else if(treeNode is DictionaryEntry)
				{
					element = dom.CreateElement(GetShortTypename(treeNode));
					elem.AppendChild(element);
					DictionaryEntry entry = (DictionaryEntry)treeNode;
					BuildElement(dom, element, entry.Key, ref controlstateDom);
					DictionaryEntry entry2 = (DictionaryEntry)treeNode;
					BuildElement(dom, element, entry2.Value, ref controlstateDom);
				} else
				{
					element = dom.CreateElement(GetShortTypename(treeNode));
					if(type == typeof(IndexedString))
						element.InnerText = ((IndexedString)treeNode).Value;
					else
						element.InnerText = treeNode.ToString();
					elem.AppendChild(element);
				}
			}
		}

		public static XmlDocument BuildXml(Object tree, out XmlDocument controlStateDom)
		{
			XmlDocument dom = new XmlDocument();
			controlStateDom = new XmlDocument();
			PropertyInfo isLoading = typeof(XmlDocument).GetProperty("IsLoading", BindingFlags.NonPublic | BindingFlags.Instance);
			isLoading.SetValue(dom, true, null);
			isLoading.SetValue(controlStateDom, true, null);

			dom.AppendChild(dom.CreateElement("viewstate"));
			controlStateDom.AppendChild(controlStateDom.CreateElement("controlstate"));
			ViewStateXmlBuilder.BuildElement(dom, dom.DocumentElement, tree, ref controlStateDom);
			return dom;
		}

		private static String GetShortTypename(Object obj)
		{
			String str = obj.GetType().ToString();
			Int32 indexOfGeneric = str.IndexOf('[');
			if(indexOfGeneric == -1)
				return str.Substring(str.LastIndexOf(".") + 1);
			else
			{
				Int32 indexOfNamespace=str.LastIndexOf('.',indexOfGeneric)+1;
				return str.Substring(indexOfNamespace);
			}
		}
	}
}