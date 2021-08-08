using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public abstract class ProjectDirectoryElementBase : ElementBase<ProjectDirectoryElement>
    {
        public override ProjectDirectoryElement ParentObject { get; protected set; }
        public override bool IsComposite => true;

        public IList<ProjectDirectoryElement> Directories { get; protected set; }

        protected ProjectDirectoryElementBase()
        {
            Directories = new List<ProjectDirectoryElement>();
        }

        public override void Add(ProjectDirectoryElement projectDirectory)
        {
            if (projectDirectory.ParentObject != null)
            {
                // das Kindobjekt ist bereits Kind eines anderen Elternobjekts
            }

            if (Directories.Contains(projectDirectory))
            {
                // dieses Kindobjekt ist bereits enthalten
            }

            var tempParentObject = projectDirectory.ParentObject;

            while (tempParentObject != null)
            {
                if (tempParentObject == projectDirectory)
                {
                    // keine Schleifen erlaubt, sonst würde man ewig warten
                }

                tempParentObject = tempParentObject.ParentObject;
            }

            projectDirectory.ParentObject = (ProjectDirectoryElement) this;

            Directories.Add(projectDirectory);
        }

        public void AddRange(IList<ProjectRoot> projectDirectory)
        {
            if (projectDirectory == null)
            {
                throw new ArgumentNullException(nameof(projectDirectory));
            }

            //foreach (var directory in projectDirectory)
            //{
            //    var element = new ProjectDirectoryElement(directory.Name, directory.ReadOnly);
            //    element.AddRange(directory.Folders);
            //    element.ParentObject = (ProjectDirectoryElement) this;
            //    Directories.Add(element);
            //}
        }


        public override void Remove(ProjectDirectoryElement projectDirectory)
        {
            Directories.Remove(projectDirectory);
        }
    }
}