﻿using System;

namespace CloudDrive.Domain.Model
{
    public class CloudFile
    {
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public string ContentMD5 { get; set; }

        public byte[] Data { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}