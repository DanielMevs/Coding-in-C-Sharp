﻿namespace DotNetUnderTheHood.Exercises
{
    public class AllLinesFromTextFileReader : IDisposable
    {
        private readonly StreamReader _streamReader;

        public AllLinesFromTextFileReader(string filePath)
        {
            _streamReader = new StreamReader(filePath);
        }

        public List<string> ReadAllLines()
        {
            var result = new List<string>();
            while (!_streamReader.EndOfStream)
            {
                result.Add(_streamReader.ReadLine());
            }

            return result;
        }

        public void Dispose()
        {
            _streamReader.Dispose();
        }
    }
}
