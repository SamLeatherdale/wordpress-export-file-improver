using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordPress_Duplicate_Resolver
{
	public class DisplayItem
	{
		public string DisplayMember;
		public object ValueMember;
		 public DisplayItem() { }
		public DisplayItem(string DisplayMember,object ValueMember)
		{
			this.DisplayMember = DisplayMember;
			this.ValueMember = ValueMember;
		}
		public override string ToString()
		{
			return DisplayMember;
		}
	}
}
