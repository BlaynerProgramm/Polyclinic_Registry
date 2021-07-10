using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Polyclinic_Registry.Model
{
	public class Doctor
	{
		public string FullName { get; set; }

		public Doctor(string fullName)
		{
			FullName = fullName;
		}
	}
}
