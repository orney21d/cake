﻿using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;

namespace Cake.IO.Compression
{
    public static class ZipExtensions
    {
        public static void Zip(this ICakeContext context, DirectoryPath root, FilePath output, IEnumerable<FilePath> files)
        {
            var zipper = new Zipper(context.FileSystem, context.Environment, context.Log);
            zipper.Zip(root, output, files);
        }
    }
}