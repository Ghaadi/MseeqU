﻿namespace Bdeir.Quizzer.Core
{
    public interface IStorage
    {
        string Read(string fileName);
        void Write(string fileName, string content);
        bool Exists(string fileName);
    }
}