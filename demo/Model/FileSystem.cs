﻿namespace Demo.Model
{
    using System.IO;

    public class FileSystem : IFileSystem
    {
        public Stream OpenRead(string filename) => File.OpenRead(filename);

        public bool Exists(string fileName) => File.Exists(fileName);
    }
}
