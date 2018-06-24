using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinApp_crossplatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailNavigationMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailNavigationMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailNavigationMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailNavigationMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailNavigationMenuItem> MenuItems { get; set; }
            
            public MasterDetailNavigationMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailNavigationMenuItem>(new[]
                {
                    new MasterDetailNavigationMenuItem { Id = 0, Title = "Home"},
                    new MasterDetailNavigationMenuItem { Id = 0, Title = "History", TargetType=typeof(PageHistory)},
                    new MasterDetailNavigationMenuItem { Id = 1, Title = "Graphs", TargetType=typeof(PageGraphs)},
                    new MasterDetailNavigationMenuItem { Id = 1, Title = "Estimations", TargetType=typeof(PageEstimations)},
                    new MasterDetailNavigationMenuItem { Id = 2, Title = "Plans", TargetType=typeof(PagePlanner)},
                    new MasterDetailNavigationMenuItem { Id = 1, Title = "Statistics", TargetType=typeof(PageStatistics)},
                    new MasterDetailNavigationMenuItem { Id = 3, Title = "SMS templates", TargetType=typeof(PageSmsAnalyzerSetup) },
                    new MasterDetailNavigationMenuItem { Id = 4, Title = "Settings", TargetType=typeof(PageSettings)},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}