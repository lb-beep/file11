﻿using System;
using System.IO;

namespace BakeryShoppingCart
{
    public class FileManagerClass
    {
        public FileManagerClass()
        {
        }
        public void CreateAFile(string path)
        {
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                Console.WriteLine("File Already Exist");
                DateTime creattionTime =
                     File.GetCreationTime(path);

                Console.WriteLine("File was created on: " +
                    creattionTime);
                DateTime modifiedTime =
                    File.GetLastWriteTime(path);

                Console.WriteLine("File was modified on: "
                    + modifiedTime);


            }
            else
            {
                Console.WriteLine("You have created the the file " +
                    path);
                File.Create(path);
            }
        }
        public void MoveFile(string source, string destination)
        {
            bool fileExist = File.Exists(source);

            if (fileExist)
            {
                File.Move(source, destination);
                Console.WriteLine("You have moved the file.");
            }
            else
            {
                Console.WriteLine("File doesn't exist.");

            }
        }
        public void CreateDirectory(string path)
        {
            bool directoryExists = Directory.Exists(path);

            if (directoryExists)
            {
                Console.WriteLine("The directory already exists.");

                DateTime creationTime = Directory.GetCreationTime(path);
                Console.WriteLine("The directory was created on: "
                    + creationTime);


                DateTime modifiedTime = Directory.GetLastWriteTime(path);
                Console.WriteLine("The directory was modified on: " + modifiedTime);
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }
        public void MoveDirectory(string source, string destination)
        {
            bool directoryExists = Directory.Exists(source);
            if (directoryExists)
            {
                Directory.Move(source, destination);
                Console.WriteLine("You have mved the directory");
            }
            else
            {
                Console.WriteLine("Directory does not exists.");
            }
        }
    }
}

