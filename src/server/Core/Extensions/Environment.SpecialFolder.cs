﻿namespace Core;

partial class XExtensions
{
    public static DirectoryInfo Directory(this Environment.SpecialFolder folder)
    {
        return Environment.GetFolderPath(folder).AsDirectory();
    }

    public static DirectoryInfo Directory(this Environment.SpecialFolder folder,
        string relativeSubDirectory)
    {
        return folder.Directory().GetSubDirectory(relativeSubDirectory);
    }

    public static FileInfo GetFile(this Environment.SpecialFolder folder, string relativePath)
    {
        return folder.Directory().GetFile(relativePath);
    }
}