﻿namespace LabWebApi.contracts.Helpers
{
    public class ImageSettings
    {
        public int MaxSize { get; set; }
        public string Type { get; set; }
        public string[] Subtypes { get; set; }
        public string Path { get; set; }
    }
}
