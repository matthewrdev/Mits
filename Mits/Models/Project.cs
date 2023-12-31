﻿using System;
using System.IO;
using Mits.Models;

namespace Mits.Models
{
	public class Project
	{
        public Project(FileInfo fileInfo, ProjectKind projectKind)
        {
            FileInfo = fileInfo ?? throw new ArgumentNullException(nameof(fileInfo));
            ProjectKind = projectKind;
        }

		public FileInfo FileInfo { get; }

		public ProjectKind ProjectKind { get; }

		public string FilePath => FileInfo.FullName;

		public string Name => FileInfo.Name;

        public string Folder => FileInfo.Directory.FullName;

        public override string ToString()
        {
            return Name + $" ({ProjectKind}) at '{FilePath}'";
        }
    }
}

