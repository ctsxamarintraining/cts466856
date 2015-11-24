using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
using System.IO;

namespace XamarinForms_App
{
	public class FootballPlayerListViewModel : INotifyPropertyChanged
	{
//		private FootballPlayerViewModel selectedplayerItem;
//		public FootballPlayerViewModel SelectedPlayer{
//			set{
//				if (selectedplayerItem.Equals( value)) {
//					selectedplayerItem = value;
//					OnPropertyChanged ("SelectedPlayer");
//				}					
//			}
//			get{
//				return selectedplayerItem;
//			}
//		}

		private ObservableCollection<FootballPlayerViewModel> thePlayerViewModelList;
		public ObservableCollection<FootballPlayerViewModel> PlayerViewModelList{
			set{
				if (thePlayerViewModelList != value) {
					thePlayerViewModelList = value;
					OnPropertyChanged ("PlayerViewModelList");
				}					
			}
			get{
				return thePlayerViewModelList;
			}
		}

		public FootballPlayerListViewModel ()
		{	
		}

		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
				//OnPropertyChanged ("PropertyChanged");
			}
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}

