

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoOptionsCollection
	{
		nsIDOMHTMLOptionsCollection DOMHTMLElement;
		internal GeckoOptionsCollection(nsIDOMHTMLOptionsCollection element)
		{
			this.DOMHTMLElement = element;
		}
		public uint Length {
			get { return DOMHTMLElement.GetLengthAttribute(); }
			set { DOMHTMLElement.SetLengthAttribute(value); }
		}

		public GeckoNode item(uint index)
		{
			return new GeckoNode(DOMHTMLElement.Item(index));
		}

		public GeckoNode namedItem(string name)
		{
			return new GeckoNode(DOMHTMLElement.NamedItem(new nsAString(name)));
		}

	}
}

