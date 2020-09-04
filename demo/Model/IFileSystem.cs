﻿namespace Demo.Model
{
    using System.IO;

    public interface IFileSystem
    {
        Stream OpenRead(string filename);

        bool Exists(string fileName);
    }
}
