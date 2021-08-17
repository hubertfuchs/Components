using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfAppX.Annotations;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace WpfAppX
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand TestCommand { get; set; }

        private ObservableCollection<ProjectFolder> _projectFolders = new ObservableCollection<ProjectFolder>();

        private uint _currentProjectNumber;
        private ProjectRoot _projectRootDirectory;

        public uint CurrentProjectNumber
        {
            get => _currentProjectNumber;
            set
            {
                _currentProjectNumber = value;
                OnPropertyChanged();
            }
        }

        public ProjectRoot ProjectRootDirectory
        {
            get => _projectRootDirectory;
            set
            {
                _projectRootDirectory = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ProjectFolder> ProjectFolders
        {
            get => _projectFolders;
            set
            {
                _projectFolders = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            CurrentProjectNumber = 2210002;

            ProjectRootDirectory = new ProjectRoot()
            {
                Path = @"C:\Projekte\2021",
                Timestamp = "2021-07-08-21-10-00",
            };

            var projectFolders = new List<ProjectFolder>();

            projectFolders.Add(new ProjectFolder()
            {
                Name = "2210001 - Test Kaufland",
                HashValue = "xxx",
                Mapping = @"\...\",
                ReadOnly = true,
            });

            projectFolders.Add(new ProjectFolder()
            {
                Name = "2210002 - Test Real",
                HashValue = "yyy",
                Mapping = @"\...\",
                ReadOnly = true,
                ProjectFolders = new List<ProjectFolder>()
                {
                    new ProjectFolder()
                    {
                        Name = "subfolder 1",
                    },
                    new ProjectFolder()
                    {
                        Name = "subfolder 2",
                    },
                    new ProjectFolder()
                    {
                        Name = "subfolder 3",
                    },
                }
            } );

            projectFolders.Add(new ProjectFolder()
            {
                Name = "2210003 - Test Brunold GmbH",
                HashValue = "zzz",
                Mapping = @"\...\",
                ReadOnly = true,
            });

            foreach (var projectFolder in projectFolders.Where(x => x.Name.StartsWith(CurrentProjectNumber.ToString())))
            {
                ProjectFolders.Add(projectFolder);
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
