using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    [Composite]
    public class ProjectDirectoryElement : ProjectDirectoryElementBase
    {
        private readonly string _name;
        private readonly bool _readOnly;

        public string Name => _name;

        public ProjectDirectoryElement(
            string name,
            bool readOnly)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _readOnly = readOnly;
        } 

        public override string GetPath()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (!_readOnly)
            {
                stringBuilder.Append(_name);

                var tempParentObject = ParentObject;

                while (tempParentObject != null)
                {
                    stringBuilder.Insert(0, @"\");
                    stringBuilder.Insert(0, tempParentObject.Name);

                    tempParentObject = tempParentObject.ParentObject;
                }

                stringBuilder.Append("\n");
            }

            foreach (var directory in Directories)
            {
                stringBuilder.Append(directory.GetPath());
            }

            return stringBuilder.ToString();
        }

        // public override string GetByLevel(byte level) 
        // {
        //     StringBuilder stringBuilder = new StringBuilder();
        // 
        //     foreach (var element in _elements.Where(x => x.Level == level))
        //     {
        //         stringBuilder.Append(element.Name);
        //         stringBuilder.Append(">");
        //         //stringBuilder.Append( directory.Operation() );
        //     }
        // 
        //     return stringBuilder.ToString();
        // }
    }
}