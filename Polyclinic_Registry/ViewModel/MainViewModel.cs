using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using Polyclinic_Registry.Model;

namespace Polyclinic_Registry.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<Patient> Patients { get; set; }

		public MainViewModel()
		{
			string json;
			using (StreamReader stream = new("Patients.json", Encoding.UTF8))
			{
				json = stream.ReadToEnd();
			}

			Patients = JsonSerializer.Deserialize<ObservableCollection<Patient>>(json);
		}

		public ICommand AddPatientCommand
		{
			get;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged([CallerMemberName] string prop = "") => 
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
}
