using System;

namespace Polyclinic_Registry.Model
{
	/// <summary>
	///Пациент
	/// </summary>
	public class Patient
	{
		public string FullName { get; init; }
		public string Address { get; init; }
		public string Phone { get; init; }

		public Patient(string fullName, string address, string phone)
		{
			if (!string.IsNullOrWhiteSpace(fullName) || !string.IsNullOrWhiteSpace(address) ||
			    !string.IsNullOrWhiteSpace(phone))
			{
				FullName = fullName;
				Address = address;
				Phone = phone;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}
		/// <summary>
		/// Для сериализации в Json
		/// </summary>
		public Patient(){}
	}
}